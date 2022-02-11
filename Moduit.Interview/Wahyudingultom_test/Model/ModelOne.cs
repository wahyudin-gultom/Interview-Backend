using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wahyudingultom_test.Model
{
    public class ModelOne
    {
        public int id { get; set; }
        public int category { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string footer { get; set; }
        public string[] tags { get; set; }
        public DateTime? createdAt { get; set; }
    }
}
