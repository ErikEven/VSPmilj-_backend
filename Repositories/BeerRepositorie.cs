using VSPmiljø_backend.Models;

namespace VSPmiljø_backend.Repositories
{
    public static class BeerRepositorie

    {
        public static List<BeerModel> Beers = new()
        {
            new() { Id = 1, Name = "Corona", Description = "Perfect silky smooth blend that lights up your day" },
            new() { Id = 2, Name = "Heineken", Description = "Easy , light and smooth for your belly" },
            new() { Id = 3, Name = "Norrlands Guld", Description = "The swedish wonder beer from lappland" },
            new() { Id = 4, Name = "Carlsberg", Description = "Danish brewed , danish taste" },
            new() { Id = 5, Name = "Tuborg", Description = "The norwegian brewed shit beer " }
        };
    }
}