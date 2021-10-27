using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class FakeSportStorRepository : ISportsStoreRepository
    {
        public IEnumerable<Product> Products => new List<Product> { 
            new Product
            {
                Name="Football",
                Price= 25,
            },
            new Product
            {
                Name="Surfboard",
                Price=179
            },
            new Product
            {
                Name="Running Shoes",
                Price=95
            }
            
        };
        
    }
}
