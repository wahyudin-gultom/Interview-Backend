using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wahyudingultom_test.Lib
{
    interface IMyLib
    {
        T ApiGetMethod<T>(string baseURL, string urlParam);
        T ApiPostMethod<T>();
    }
}
