using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFlower.Models
{
    
    public class ShopCart
    {
        public List<SelectedProduct> SpList = new List<SelectedProduct>();

        public bool AddProduct(int id,int quan)
        {
            SelectedProduct s = new SelectedProduct() { Id = id, Quantity = quan };
            SpList.Add(s);
            return true;
        }
        public List<SelectedProduct> GetAll()
        {
            return SpList;
        }
    }
}