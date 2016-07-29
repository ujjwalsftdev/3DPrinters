

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3D_printers
{
    public class prin
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string image { get; set; }
        public string review { get; set; }


        public prin(int id, string name, double price, string image, string review)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.image = image;
            this.review = review;
        }
    }
}