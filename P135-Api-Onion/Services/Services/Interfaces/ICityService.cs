using Services.DTOs.City;
using Services.DTOs.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllAsync();
        Task<CityDto> GetByIdAsync(int? id);
        Task CreateAsync(CityCreateDto country);
        Task DeleteAsync(int? id);
        Task SoftDeleteAsync(int id);
        Task UpdateAsync(int id, CityUpdateDto country);
    }
}
