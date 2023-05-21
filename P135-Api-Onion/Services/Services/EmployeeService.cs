using AutoMapper;
using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using Services.DTOs.Employee;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Xml.Linq;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public EmployeeService(IEmployeeRepository employeeRepo,IMapper mapper, AppDbContext context)
        {
            _employeeRepo = employeeRepo; 
            _mapper = mapper;
            _context = context;
        }

        public async Task CreateAsync(EmployeeCreateDto employee) => await _employeeRepo.CreateAsync(_mapper.Map<Employee>(employee));
      
        public async Task<IEnumerable<EmployeeDto>> GetAllAsync() => _mapper.Map<IEnumerable<EmployeeDto>>(await _employeeRepo.FindAllAsync());

        public async Task<EmployeeDto> GetByIdAsync(int? id) => _mapper.Map<EmployeeDto>(await _employeeRepo.GetByIdAsync(id));

        public async Task DeleteAsync(int? id) => await _employeeRepo.DeleteAsync(await _employeeRepo.GetByIdAsync(id));

        public async Task SoftDeleteAsync(int id)
        {
            Employee employee = await _employeeRepo.GetByIdAsync(id);
            await _employeeRepo.SoftDeleteAsync(employee);
        }


        public async Task UpdateAsync(int id, EmployeeUpdateDto employee)
        {
            if (id == null) throw new ArgumentNullException();

            var data = await _employeeRepo.GetByIdAsync(id);
            if (data == null) throw new NullReferenceException();

            _mapper.Map(employee, data);
            await _employeeRepo.UpdateAsync(data);
        }



        public async Task<IEnumerable<EmployeeDto>> SearchAsync(string searchText)
        {
            if (searchText is null)
                return _mapper.Map<IEnumerable<EmployeeDto>>(await _employeeRepo.FindAllAsync());
            return _mapper.Map<IEnumerable<EmployeeDto>>(await _employeeRepo.FindAllAsync(m => m.FullName.Contains(searchText)));
        }



    }
}
