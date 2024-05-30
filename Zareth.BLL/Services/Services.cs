using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zareth.BLL.IServices;
using Zareth.DAL.Repositories;

namespace Zareth.BLL.Services
{
    public class GenericService<T> : GenericRepository<T>, IGenericService<T> where T : class
    {
    }
}
