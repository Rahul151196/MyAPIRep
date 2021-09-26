using MyWebApiRep.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApiRep.Models.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public List<Product> Search(string keyword);

        public List<Product> Search(double min, double max);
    }
}
