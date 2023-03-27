using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class PlanetServices
    {
        private static List<Planets> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The Smallest Planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#298347"),
                Images = new()
                {
                    "https://nineplanets.org/wp-content/uploads/2019/09/mercury.png"
                }
            }

        };

        public static List<Planets> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizedPlanets = PlanetServices.OrderBy(ItemDelegateList => rnd.Next());

            return randomizedPlanets.Take(2).ToList();
        }
    }
}
