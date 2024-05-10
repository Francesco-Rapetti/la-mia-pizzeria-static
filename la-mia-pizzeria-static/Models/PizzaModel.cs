namespace la_mia_pizzeria_static.Models
{
    public class PizzaModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        public PizzaModel(string name, string description, double price, string image = "https://www.creativefabrica.com/wp-content/uploads/2020/04/23/single-slice-italian-pizza-cartoon-flat-Graphics-3933838-1-1-580x387.jpg")
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Price = price;
        }
    }
}
