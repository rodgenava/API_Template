using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITempalate.Domain;
using static System.Net.Mime.MediaTypeNames;

namespace WebAPITempalate.Infrastructure
{
    public class Pricebook2ItemsRepo : IPricebook2ItemsRepo
    {
        private readonly AppDBContext _dbContext;
        public Pricebook2ItemsRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Pricebook2Items> Testconnection()
        {
            try
            {

                var test = await _dbContext.Pricebook2Items
                    .Where(a => a.Store.Equals(201)).FirstOrDefaultAsync();

                return test;
            }
            catch (Exception ex)
            {

                return null;
            }
            //return await _dbContext.Pricebook2Items.Where(a => a.Store.Equals(201)).FirstOrDefaultAsync();
        }
    }
}
