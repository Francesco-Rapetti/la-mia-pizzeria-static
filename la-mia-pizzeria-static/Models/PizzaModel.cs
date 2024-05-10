namespace la_mia_pizzeria_static.Models
{
    public class PizzaModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        public PizzaModel(string name, string description, double price, string image = "/img/pizza-placeholder.png")
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Price = price;
        }
    }
}
