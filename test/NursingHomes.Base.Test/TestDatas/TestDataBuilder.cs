using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NursingHomes.Base.DbContext;

namespace NursingHomes.Base.Test.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BaseContext _context;

        public TestDataBuilder(BaseContext context)
        {
            _context = context;
        }

        public void Build()
        {
            CreateProducts();
        }

        private void CreateProducts()
        {
        }
    }
}
