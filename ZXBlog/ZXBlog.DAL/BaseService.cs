using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXBlog.Model;
using ZXBlog.IDAL;
using System.Linq.Expressions;

namespace ZXBlog.DAL
{
    public class BaseService<T> : IBaseService<T> where T:BaseEntity,new()
    {
        public readonly ZXBlogContext _db;
        public BaseService(Model.ZXBlogContext db)
        {
            _db = db;
        }

        public Task CreateAsync(T model, bool saved = true)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public Task EditAsync(T model, bool saved = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T model, bool saved = true)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
