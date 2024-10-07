using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIPGoodAndBad
{

    public class ProductService 
    {
        // Bad Injection

        //private readonly ProductRepositoryFromSqlServer _repository;

        //public ProductService(ProductRepositoryFromSqlServer repository)
        //{
        //    _repository = repository;
        //}


        // Good Injection
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetAll() 
        {
            return _repository.GetAll();
        }

    }

    public class ProductRepositoryFromSqlServer  : IRepository
    {
        public List<string> GetAll() 
        {
            return new List<string>() { "SQL Server Kalem 1", "SQL Server Kalem 2" };
        }
    }


    public class ProductRepositoryFromOracleServer : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "Oracle Server Kalem 1", "Oracle Server Kalem 2" };
        }
    }


    public interface IRepository 
    {
        List<string> GetAll();
    }

}
