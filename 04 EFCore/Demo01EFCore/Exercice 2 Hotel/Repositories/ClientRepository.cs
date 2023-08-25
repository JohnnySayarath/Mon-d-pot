using Exercice02Hotel.Data;
using Exercice02Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02Hotel.Repositories
{
    internal class ClientRepository : IRepository<Client>
    {
        private ApplicationDbContext _dbContext;

        public ClientRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //CREATE
        public bool Add(Client entity)
        {
            throw new NotImplementedException();
        }

        //READ
        public Client Get(int entityId)
        {
            throw new NotImplementedException();
        }

        public Client Get(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        //UPDATE
        public bool Update(Client entity)
        {
            throw new NotImplementedException();
        }

        //DELETE
        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
