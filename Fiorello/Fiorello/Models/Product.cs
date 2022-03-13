namespace Fiorello.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        // buradaki int tipinden CategoryId-ni nullable true olmamasi ucun yaratdiq.
    }
}
