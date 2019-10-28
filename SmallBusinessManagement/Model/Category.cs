using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagement.Repository;
using SmallBusinessManagement.BLL;


namespace SmallBusinessManagement.Model
{
   public class Category
    {
        public int Id { set; get; }
       
        public string Code { set; get; }
        public string Name { set; get; }
       
    }
}
