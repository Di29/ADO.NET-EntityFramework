using OnlineShop_EntFrm_.Data;
using OnlineShop_EntFrm_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_EntFrm_
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Item> items = null;
            using (var context = new ShopContext())
            {
                context.Items.Add(new Item
                {
                    Name = "tea",
                    Price = 300
                });

                context.SaveChanges();

                items = context.Items.ToList();
            }

            foreach(var item in items)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
