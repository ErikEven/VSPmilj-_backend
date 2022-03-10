using VSPmiljø_backend.Models;
using VSPmiljø_backend.Repositories;

namespace VSPmiljø_backend.Services
{
    public class BeerService : IBeerService
    {
        public BeerModel Create(BeerModel Beer)
        {
            Beer.Id = BeerRepositorie.Beers.Count + 1;
            BeerRepositorie.Beers.Add(Beer);

            return Beer;
        }

        public BeerModel? Get(int id)
        {
            var Beer = BeerRepositorie.Beers.FirstOrDefault(o => o.Id == id);

            if (Beer is null) return null;

            return Beer;
        }

        public List<BeerModel> List()
        {
            var Beers = BeerRepositorie.Beers;

            return Beers;
        }

        public BeerModel? Update(BeerModel newBeer)
        {
            var oldBeer = BeerRepositorie.Beers.FirstOrDefault(o => o.Id == newBeer.Id);

            if (oldBeer is null) return null;

            oldBeer.Name = newBeer.Name;
            oldBeer.Description = newBeer.Description;

            return newBeer;
        }

        public bool Delete(int id)
        {
            var oldBeer = BeerRepositorie.Beers.FirstOrDefault(o => o.Id == id);

            if (oldBeer is null) return false;

            BeerRepositorie.Beers.Remove(oldBeer);

            return true;
        }
    }
}