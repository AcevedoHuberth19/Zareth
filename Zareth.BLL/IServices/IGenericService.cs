using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zareth.DAL.IRepositories;

namespace Zareth.BLL.IServices
{
    public interface IGenericService<T> : IGenericRepository<T> where T : class
    {
    }
}
