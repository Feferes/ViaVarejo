using Localizador.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Localizador.Domain.Interfaces
{
    public interface IService<T> where T : Base
    {
        T Post<V>(T obj);

        T Put<V>(T obj);

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
