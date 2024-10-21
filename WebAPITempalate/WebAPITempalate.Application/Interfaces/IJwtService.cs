using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITempalate.Domain;

namespace WebAPITempalate.Application
{
    public interface IJwtService
    {
        string CreateToken(LoginModel login);
    }
}
