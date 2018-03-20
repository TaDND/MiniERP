using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core
{
    public class Warehouse
    {
        private StockItem[] items;

        public int Counter
        {
            get
            {
                return this.counter;
            }
        }
        private int counter;
        public Warehouse()
        {
            counter = 0;
            items = new StockItem[100];
        }


        public StockItem []Items
        {
            get
            {
                return this.items;
            }
            set
            {
                items = value;
            }
        }
        public void Add(StockItem item)
        {
            items[counter] = item;
            counter++;


        }

        public void Save()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(@"C:\temp\warehouse.json", json);
        }
        public static Warehouse Load ()
        {
            string json = System.IO.File.ReadAllText(@"C:\temp\warehouse.json");

            Warehouse w = Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(Warehouse)) as Warehouse;
            return w;
        }
    }
}
