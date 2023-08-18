using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
    public class ParksApiContext : DbContext
    {
        public DbSet<Park> Parks { get; set; }

        public ParksApiContext(DbContextOptions<ParksApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Acadia National Park", State = "Maine", Type = "National", Description = "Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes." },
                    new Park { ParkId = 2, Name = "American Samoa", State = "American Samoa", Type = "National", Description = "The southernmost national park is on three Samoan islands in the South Pacific. It protects coral reefs, rainforests, volcanic mountains, and white beaches." },
                    new Park { ParkId = 3, Name = "Arches National Park", State = "Utah", Type = "National", Description = "This site features more than 2,000 natural sandstone arches." },
                    new Park { ParkId = 4, Name = "Badlands National Park", State = "South Dakota", Type = "National", Description = "They contain the largest known assemblage of late Eocene and Oligocene mammal fossils." },
                    new Park { ParkId = 5, Name = "Big Bend National Park", State = "Texas", Type = "National", Description = "Its main attraction is backcountry recreation in the arid Chisos Mountains and in canyons along the river" },

                    new Park { ParkId = 6, Name = "Lake Owyhee State Park", State = "Oregon", Type = "State", Description = "A remote oasis catering to camping and boating on the shore of a scenic desert canyon reservoir." },
                    new Park { ParkId = 7, Name = "Hat Rock State Park", State = "Oregon", Type = "State", Description = "Hat Rock is a geological formation that, along with another outcropping rock in the park called Boat Rock, are thought to be exposed remnants of a 12-million-year-old basalt flow." },
                    new Park { ParkId = 8, Name = "Tumalo State Park", State = "Oregon", Type = "State", Description = "Tumalo State Park is located in the Deschutes River canyon, running along both sides of the river." },
                    new Park { ParkId = 9, Name = "Humbug Mountain State Park", State = "Oregon", Type = "State", Description = "It covers 1,842 acres (7.45 km2) of land around 1,759-foot (536 m) Humbug Mountain, one of the tallest headlands on the Oregon coast." },
                    new Park { ParkId = 10, Name = "Cape Blanco State Park", State = "Oregon", Type = "State", Description = "Cape Blanco extends farther west than any point of land in the contiguous United States (lower 48 states) except portions of the Olympic Peninsula in Washington." }
                );
        }
    }
}