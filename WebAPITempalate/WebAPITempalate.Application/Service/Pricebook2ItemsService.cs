using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITempalate.Domain;
using WebAPITempalate.Infrastructure;

namespace WebAPITempalate.Application
{
    public class Pricebook2ItemsService : IPricebook2ItemsService
    {
        private readonly IPricebook2ItemsRepo _pricebook2ItemsRepo;
        public Pricebook2ItemsService(IPricebook2ItemsRepo pricebook2ItemsRepo)
        {
            _pricebook2ItemsRepo = pricebook2ItemsRepo;
        }
        public async Task<Pricebook2Items> Testconnection()
        {
            var test = await _pricebook2ItemsRepo.Testconnection();

            return test;
        }
    }
}
