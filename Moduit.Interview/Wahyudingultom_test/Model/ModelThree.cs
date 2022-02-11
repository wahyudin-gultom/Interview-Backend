using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wahyudingultom_test.Model
{
    public class ModelThree
    {
        public int id { get; set; }
        public int? category { get; set; }
        public List<Item> items { get; set; }
        public DateTime? createdAt { get; set; }
        public List<string> tags { get; set; }
    }

    public class Item
    {
        public string title { get; set; }
        public string description { get; set; }
        public string? footer { get; set; }
    }
}
