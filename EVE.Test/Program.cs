using EVE.ApiModels.Catalog;
using EVE.Commons.Response;
using EVE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
           await gate();
        }

        static async Task gate()
        {
            var logonResponse = await HttpUtils<ClientResponse<School>>
                .Get($"http://localhost:19001/School/getById",
                new SchoolGetByIdReq
                {
                   SchoolId =1
                });
        }
    }
}
