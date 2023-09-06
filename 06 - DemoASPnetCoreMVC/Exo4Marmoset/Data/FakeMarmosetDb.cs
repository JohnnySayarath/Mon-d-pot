using Exo4Marmoset.Models;

namespace Exo4Marmoset.Data
{
    public class FakeMarmosetDb
    {
        private List<Marmoset> _marmosets;
        private int _lastIndex = 0;

        public FakeMarmosetDb()
        {
            _marmosets = new List<Marmoset>()
            {
                new Marmoset {Id = ++_lastIndex, Name = "Babouche", Age = 1 }
            };
        }
        public List<Marmoset> GetAll()
        {
            return _marmosets;
        }

        public Marmoset? GetById(int id)
        {
            return _marmosets.FirstOrDefault(m => m.Id == id);
        }



        public bool Add(Marmoset marmoset)
        {
            marmoset.Id = ++_lastIndex;
            _marmosets.Add(marmoset);
            return true; // l'ajout s'est bien passé
        }

        public bool Edit(Marmoset marmoset)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var marmoset = GetById(id);
            if (marmoset == null)
                return false;
            _marmosets.Remove(marmoset);
            return true;
        }
    }
}
