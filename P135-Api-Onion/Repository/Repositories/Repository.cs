﻿using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            if(entity == null) {  throw new ArgumentNullException(nameof(entity)); }
            await entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null) { throw new ArgumentNullException(nameof(entity)); }

            entities.Remove(entity);

            await _context.SaveChangesAsync();
        }



        public async Task<T> GetByIdAsync(int? id)
        {
            if(id == null) throw new ArgumentNullException(); 

            T entity = await entities.FindAsync(id);

            if(entity == null) throw new NullReferenceException("Notfound data"); 

            return entity;
        }


        public async Task UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException();

            entities.Update(entity);

            await _context.SaveChangesAsync();

        }

        public async Task SoftDeleteAsync(T entity)
        {
            T model = await entities.FirstOrDefaultAsync(m => m.Id == entity.Id);

            if (model == null) throw new NullReferenceException();

            model.SoftDelete = true;

            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> expression = null)
        {
            return expression != null ? await entities.Where(expression).ToListAsync() : await entities.ToListAsync();
        }
    }
}
