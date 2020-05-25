using System;
using System.Collections.Generic;
using System.Text;

namespace FoodMap_Model
{
   public class Order
    {
        public string IconOrder { set; get; }
        public string Id { set; get; }
        int stausAction;
        public int StatusAction { set; get; }
        public string OrderTitle { set; get; }
        public string Price { set; get; }
        public string Date_Created { set; get; }
    }
}
