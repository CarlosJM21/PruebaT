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

        Task<Search<SPerson>> searchpeople(String offset, String size, String[] agg);

        Task<Search<SOpp>> searchoppt(String offset, String size, String[] agg);

    }
}
