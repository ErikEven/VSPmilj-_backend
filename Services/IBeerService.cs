using VSPmiljø_backend.Models;

namespace VSPmiljø_backend.Services
{
    public interface IBeerService
    {
        public BeerModel Create(BeerModel Beer);
        public BeerModel? Get(int id);
        public List<BeerModel> List();
        public BeerModel? Update(BeerModel Beer);
        public bool Delete(int id);
    }
}
