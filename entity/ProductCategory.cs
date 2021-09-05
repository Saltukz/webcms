namespace entity
{
    public class ProductCategory
    {
        public int CategoryId { get; set; }

        public Category ThermoformCategory { get; set; }

        public int ProductId { get; set; }

        public Product ThermoformProduct { get; set; }
    }
}