using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagement.Repository;
using SmallBusinessManagement.BLL;


namespace SmallBusinessManagement.Model
{
    public class Supplier
    {
        public int id { set; get; }
        public int code { set; get; }
        public string name { set; get; }
        public string address { set; get; }
        public string email { set; get; }
        public string contact { set; get; }
        public string contactperson { set; get; }
    }
}
