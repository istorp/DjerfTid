using DjerfTid.DataAccess.Data;
using DjerfTid.DataAccess.Repository.IRepository;
using DjerfTid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DjerfTid.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;

                _db.SaveChanges();
            }
        }
    }
}
