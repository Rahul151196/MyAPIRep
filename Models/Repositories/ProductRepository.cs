using MyWebApiRep.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApiRep.Models.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(DatabaseContext dbContext) : base(dbContext)
        {

        }

        public List<Product> Search(string keyword)
        {

            return GetAll().Where(p => p.Name.Contains(keyword)).ToList();
        }

        public List<Product> Search(double min, double max)
        {
            return GetAll().Where(p => p.Price >= min && p.Price <= max).ToList();
        }
    }
}
