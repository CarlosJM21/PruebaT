using PruebaT.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Helpers
{
    public interface ITorreHelper
    {

        Task<Bio> bio(string Username);

        Task<Opportunity> Job(string id);

    }
}
