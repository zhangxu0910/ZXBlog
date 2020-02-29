using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZXBlog.Model;

namespace ZXBlog.IDAL
{
    public interface IBaseService<T>: IDisposable where T:BaseEntity,new()
    {
        Task CreateAsync(T model, bool saved = true);//添加接口
        Task EditAsync(T model, bool saved = true);//修改接口
        Task RemoveAsync(T model, bool saved = true);//删除接口(通过对象删除)
        IQueryable<T> GetAll();//查询接口
        Task Save();//保存接口
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);//通过条件查询接口

    }
}
