using Localizador.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Localizador.Domain.Interfaces
{
    public interface IRepository<T> where T : Base
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
