using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MiniERP.Core.StockItem i = new Core.StockItem();
            i.StockItemId = 1;
            i.Name = "My Item";
            i.Price = 10;
            i.SKU = 100;

            Console.WriteLine(i);

            i.Save();


            MiniERP.Core.StockItem i2 = MiniERP.Core.StockItem.Load(1);


            //MiniERP.Core.Warehouse w = new Core.Warehouse();
            //w.Add(i);
            //w.Add(new Core.StockItem { StockItemId = 2, Name = "My Item 2", Price = 50, SKU = 20 });
            //w.Save();

            MiniERP.Core.Warehouse w2 = MiniERP.Core.Warehouse.Load();
        }
    }
}
