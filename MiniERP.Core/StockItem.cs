namespace MiniERP.Core
{
    public class StockItem : StockItemBase
    {

        public override string ToString()
        {
            return "Item #" + this.StockItemId;
        }
        //public override void Save()
        //{
        //    string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
        //    System.IO.File.WriteAllText(@"C:\temp\" + this.StockItemId + ".json", json);



        //}
        public static StockItem Load (int id)
        {
            string json = System.IO.File.ReadAllText(@"C:\temp\" + id + ".json");

            StockItem i = Newtonsoft.Json.JsonConvert.DeserializeObject(json,typeof(StockItem)) as StockItem;
            return i;
        }
    }
}
