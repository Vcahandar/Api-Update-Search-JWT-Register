using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(AppDbContext context) : base(context) { }
    }
}
