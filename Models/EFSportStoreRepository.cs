using SportStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class EFSportStoreRepository : ISportsStoreRepository
    {
        private SportStoreDbContext context;
        public EFSportStoreRepository(SportStoreDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> Products => throw new NotImplementedException();
    }
}
