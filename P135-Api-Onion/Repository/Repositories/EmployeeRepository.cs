using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository //EmployeeRepository Umumi repositoryden miras alirki tekrar olaraq Crud-lari implement etmek lazim olmasin
    {
        public EmployeeRepository(AppDbContext context) : base(context) { } //umumi Repository nin contructoru arqument teleb edir, bizde miras almiwiq deye mecburi constructora arqument olaraq data gonderirik 
    }
}

