using DemoASPnetCoreMVC.Models;

namespace DemoASPnetCoreMVC.Data
{
    public class FakeContactDb // représente une fausse base de données (équivalent à un DbContext ou un Repository)
    {
        private List<Contact> _contacts; // équivalent de la base de données

        public FakeContactDb()
        {
            _contacts = new List<Contact>() // équivalent du data seed (données par défaut)
            {
            new Contact { Id = 1, FirstName = "Bob", LastName = "Marley", Email = "bobo@ganjamail.com", Phone = "0607080910" },
                new Contact { Id = 2, FirstName = "Elvis", LastName = "Presley", Email = "elvis@rock.com", Phone = "0607080911" },
                new Contact { Id = 3, FirstName = "Michael", LastName = "Jackson", Email = "mj@popking.com", Phone = "0607080912" },
            };
        }

        public List<Contact> GetAll()
        {
            return _contacts;
        }

        public Contact? GetById(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        public bool Add(Contact contact)
        {
            _contacts.Add(contact);
            return true; // l'ajout s'est bien passé 
        }

        public bool Edit(Contact contact)
        {
            // modification
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var contact = GetById(id);
            if (contact == null)
                return false;
            _contacts.Remove(contact);
            return true;
        }
    }
}
