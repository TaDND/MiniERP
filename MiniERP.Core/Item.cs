namespace MiniERP.Core
{
    public class Item : StockItem
    {

        public override string ToString()
        {
            return "Item #" + this.StockItemId;
        }
        public override void Save()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(@"C:\temp\" + this.StockItemId + ".json", json);



        }
        public static Item Load (int id)
        {
            string json = System.IO.File.ReadAllText(@"C:\temp\" + id + ".json");

            Item i = Newtonsoft.Json.JsonConvert.DeserializeObject(json,typeof(Item)) as Item;
            return i;
        }
    }
}
