using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wahyudingultom_test.Model;

namespace Wahyudingultom_test.Interfaces
{
    interface IModuitApi
    {
        IConfiguration configuration { set; get; }
        ModelOne GetApiOne();
        List<ModelTwo> GetApiTwo(string stringContain, string tags, int limit);
        List<ModelOne> GetApiThree();
    }
}
