﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zareth.DAL.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Listar();
        bool Insertar(T obj);
        bool Actualizar(T obj);
        bool Eliminar(int Id);

    }
}
