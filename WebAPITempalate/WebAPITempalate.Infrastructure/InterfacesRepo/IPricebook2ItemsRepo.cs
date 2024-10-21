using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITempalate.Domain;

namespace WebAPITempalate.Infrastructure
{
    public interface IPricebook2ItemsRepo
    {
        Task<Pricebook2Items> Testconnection();
    }
}
