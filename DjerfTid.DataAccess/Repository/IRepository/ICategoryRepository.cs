using DjerfTid.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DjerfTid.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);
    }
}
