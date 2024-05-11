using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    internal interface IDataService<T>
    {
        
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> Create(T entity); 
        Task<T> Update(int id ,T entity);

        Task<bool> Delete(int id);
            
    }
}
