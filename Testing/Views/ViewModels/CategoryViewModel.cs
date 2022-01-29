using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Testing.Views.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<ToDoListModel> ListModels { get; set; }

        public string currentCategory { get; set; }

        public string Name { get; set; }

        public string id { get; set; }
    }
}
