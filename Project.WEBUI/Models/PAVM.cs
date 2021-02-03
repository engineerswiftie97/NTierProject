using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WEBUI.Models
{
    public class PAVM
    {
        public Product Product { get; set; }

        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }

        //Todo: Pagination işlemleri (Alısveris)
    }
}