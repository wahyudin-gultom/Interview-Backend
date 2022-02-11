using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Wahyudingultom_test.Interfaces;
using Wahyudingultom_test.Model;

namespace Wahyudingultom_test.Repository
{
    public class ModuitApi : IModuitApi
    {
        private string baseApi = string.Empty;
        public IConfiguration configuration { set; get; }
        public ModuitApi()
        {

        }

        public ModelOne GetApiOne()
        {
            var result = new ModelOne();
            var myLib = new Lib.MyLib();

            baseApi = configuration.GetValue<string>("HostUrl");
            result = myLib.ApiGetMethod<ModelOne>(baseApi, "/backend/question/One");
            return result;
        }

        public List<ModelOne> GetApiThree()
        {
            List<ModelOne> result = new List<ModelOne>();
            ModelOne detail = null;
            var myLib = new Lib.MyLib();

            baseApi = configuration.GetValue<string>("HostUrl");
            var sresult = myLib.ApiGetMethod<List<ModelThree>>(baseApi, "/backend/question/Three");
            
            foreach(ModelThree item in sresult)
            {
                detail = new ModelOne();
                if (item.items != null)
                {
                    foreach(Item dt in item.items)
                    {
                        detail.id = item.id;
                        detail.category = item.category.HasValue ? item.category.Value : 0;
                        detail.tags = item.tags != null ? item.tags.ToArray() : null;
                        detail.createdAt = item.createdAt;
                        detail.title = dt.title;
                        detail.description = dt.description;
                        detail.footer = dt.footer;
                        
                        result.Add(detail);
                    }
                }
                
            }

            return result;
        }

        public List<ModelTwo> GetApiTwo(string stringContain, string tags, int limit)
        {
            var result = new List<ModelTwo>();
            var myLib = new Lib.MyLib();

            baseApi = configuration.GetValue<string>("HostUrl");
            var sresult = myLib.ApiGetMethod<List<ModelTwo>>(baseApi, "/backend/question/Two");

            result = sresult.Where(m => m.description.Contains(stringContain) || m.title.Contains(stringContain)
            || m.tags != null ? m.tags.Contains(tags): false).OrderByDescending(m => m.id).Take(limit).ToList();
            
            return result;
        }
    }
}
