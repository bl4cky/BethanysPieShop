using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;
        public MockPieRepository()
        {
            if(_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>()
            {
                new Pie{}
            }
        }

        public IEnumerable<Pie> GetAllPies()
        {
            throw new NotImplementedException();
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
