using System; // standard for 'interface' same as class but with interface
using System.Collections.Generic; // standard for 'interface' same as class but with interface
using System.Text; // standard for 'interface' same as class but with interface
using Domain_Layer.Entities.Base_Models; // for inheritance
using System.Threading.Tasks; // for 'Task'

namespace Contracts.Factories // standard for 'interface' same as class but with interface
{
    // 
    public interface IEntityFactory<T> where T : BaseEntity// standard for 'interface' same as class but with interface
    {
        Task<bool> CreateAsync(T entity); // new Task return type boolean, createasync with type T
        Task<T> GetAsync(int id); // new Task return type T, GetAsync with int id
        Task<bool> RemoveAsync(int id);
        Task<ICollection<T>> GetAsync(); //ICollection from line 2
    }
}