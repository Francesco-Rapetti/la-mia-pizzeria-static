namespace la_mia_pizzeria_static.Models
{
    public class PizzeriaModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<PizzaModel> Pizzas { get; set; }

        public PizzeriaModel(string name, string description, string image = "https://static.vecteezy.com/system/resources/previews/002/977/249/original/pizzeria-store-front-illustration-in-flat-style-vector.jpg")
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Pizzas = new List<PizzaModel>();
        }

        public void AddPizza(PizzaModel pizza) => Pizzas.Add(pizza);
        public void RemovePizza(PizzaModel pizza) => Pizzas.Remove(pizza);
    }
}
