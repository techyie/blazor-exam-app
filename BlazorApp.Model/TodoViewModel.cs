using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Model
{
    public class TodoViewModel
    {
        public TodoViewModel()
        {
            uuid = Guid.NewGuid().ToString();
        }

        public int id { get; set; }
        public string uuid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public DateTime dateAdded { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}
