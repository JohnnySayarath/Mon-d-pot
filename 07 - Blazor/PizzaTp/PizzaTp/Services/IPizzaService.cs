using PizzaTp.Models;

namespace PizzaTp.Services
{
    public interface IPizzaService
    {

        public bool Post(Pizza pizza);

        public List<Pizza> Get(Pizza pizza);

        public bool Put(Pizza pizza);

        public bool Delete(int id);

        public bool AjouterAuPanier(Pizza pizza);
        public bool ViderPanier();
    }
}
