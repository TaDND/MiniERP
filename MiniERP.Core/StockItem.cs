using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Core
{
    public abstract class StockItem
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

        //public int StockItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public StockItem()
        {
            this.Name = "";
        }

        public abstract void Save();

    }
}
