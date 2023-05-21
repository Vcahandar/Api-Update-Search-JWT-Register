using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee> //umumi IRepository interfacesinden bashqa, IEmployee yaradiriqki ozunemexsus methodlarida istifade ede bilek.yeni Irepoda olan crud lardan bashqa
    {
            
    }
}
