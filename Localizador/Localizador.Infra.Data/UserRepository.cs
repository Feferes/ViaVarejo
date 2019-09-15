using Dapper;
using Localizador.Domain.Entities;
using Localizador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Localizador.Infra.Data
{
    public class UserRepository : IRepository<User>
    {
        private IConfiguration _configuration;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public User Select(int id)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuration.GetConnectionString("Localizador")))
            {
                return conexao.QueryFirstOrDefault<User>(
                    "SELECT Id, AccessKey " +
                    "FROM dbo.Usuarios " +
                    "WHERE Id = @Id", new { Id = id });
            }
        }

        public IList<User> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
