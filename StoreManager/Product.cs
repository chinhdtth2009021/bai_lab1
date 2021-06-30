namespace StoreManager
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public override string ToString()
        {
            return $"{Id},\t\t{Name},\t\t\t{Price}";
        }
    }
}