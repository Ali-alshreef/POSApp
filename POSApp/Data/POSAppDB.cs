using POSApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.Data
{
    public class POSAppDB
    {
        public List<Product> Products { get; set; } = new();
    }
}
