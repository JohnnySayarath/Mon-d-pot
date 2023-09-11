using PizzaTp.Models;
using PizzaTp.Pages;

namespace PizzaTp.Services
{
    public class PizzaFakeDbService : IPizzaService
    {
        private int _lastId = 0;
        private List<Pizza> pizzas = new List<Pizza>();
        private List<Pizza> panier = new List<Pizza>();

        public PizzaFakeDbService()
        {
            Post(new Pizza { ImageUrl = "pizza1.jpg", Titre = "Pizza Margherita", Description = "Tomates, mozzarella, basilic", Prix = 10.99m });
            Post(new Pizza { ImageUrl = "pizza2.jpg", Titre = "Pizza Pepperoni", Description = "Pepperoni, fromage, sauce tomate", Prix = 12.99m });
        }

        public List<Pizza> GetPizzas()
        {
            return pizzas;
        }
        public bool Delete(int id)
        {
            var pizzaRemoved = pizzas.RemoveAll(p => p.Id == id);
            Console.WriteLine(pizzas.Count);
            return pizzaRemoved == 1;
        }

       

        public bool Post(Pizza pizza)
        {
            pizza.Id = ++_lastId;
            pizzas.Add(pizza);
            Console.WriteLine(pizzas.Count);
            return true;
        }

        public bool Put(Pizza pizza)
        {
            var existingPizza = pizzas.FirstOrDefault(p => p.Id == pizza.Id);
            if (existingPizza != null)
            {
                existingPizza.ImageUrl = pizza.ImageUrl;
                existingPizza.Titre = pizza.Titre;
                existingPizza.Description = pizza.Description;
                existingPizza.Prix = pizza.Prix;
            }
            return true;
        }

        public bool AjouterAuPanier (Pizza pizza)
        {
            panier.Add(pizza);
            return true;
        }

        public bool ViderPanier(Pizza pizza)
        {
            panier.Clear();
            return true;
        }

        List<Pizza> IPizzaService.Get(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        bool IPizzaService.ViderPanier()
        {
            throw new NotImplementedException();
        }
    }
}
