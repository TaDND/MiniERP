using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core
{
    public abstract class StockItemBase
    {
        private int _stockItemId;

        public int StockItemId
        {
            get { return _stockItemId; }
            set {
                if (value <= 0)
                    value = 1;
                _stockItemId = value; }
        }

        public int SKU { get; set; }
        //public int StockItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public StockItemBase()
        {
            this.Name = "";
        }

        public virtual void Save()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(@"C:\temp\" + this.StockItemId + ".json", json);
        }
    }
}
