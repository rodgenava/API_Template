using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITempalate.Domain;

namespace WebAPITempalate.Application
{
    public interface IPricebook2ItemsService
    {
        Task<Pricebook2Items> Testconnection();
    }
}
