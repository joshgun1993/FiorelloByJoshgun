using Fiorello.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderData> SliderDatas { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasData(new Slider
            {
                Id = 1, Image = "h3-slider-background.jpg",
            }, new Slider
            {
                Id = 2, Image = "h3-slider-background-2.jpg",
            }, new Slider
            {
                Id = 3, Image = "h3-slider-background-3.jpg"
            });
            modelBuilder.Entity<SliderData>().HasData(new SliderData
            {
              Id= 1, Title= "<h1>Send <span>flowers</span> like</h1><h1> you mean it </h1>", Subtitle= "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.", Image = "h2-sign-img.png"
            });
            modelBuilder.Entity<About>().HasData(new About
            {
                Id = 1, Title = "<h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>", Subtitle = "Where flowers are our inspiration to create lasting memories. Whatever the occasion...", Image = "h3-video-img.jpg"
            });
            modelBuilder.Entity<AboutList>().HasData(new AboutList
            {
                Id = 1, Title= "Hand picked just for you.", Image = "h1-custom-icon.png"
            }, new AboutList
            {
                Id = 2, Title = "Unique flower arrangements", Image = "h1-custom-icon.png"
            }, new AboutList
            {
                Id = 3, Title = "Best way to say you care.", Image = "h1-custom-icon.png"
            });
            modelBuilder.Entity<Expert>().HasData(new Expert
            {
                Id = 1, Name = "CRYSTAL BROOKS", Position = "Florist", Image = "h3-team-img-1.png"
            }, new Expert
            {
                Id = 2, Name = "SHIRLEY HARRIS", Position = "Manager", Image = "h3-team-img-2.png"
            }, new Expert
            {
                Id = 3, Name = "BEVERLY CLARK", Position = "Florist", Image = "h3-team-img-3.png"
            }, new Expert
            {
                Id = 4, Name = "AMANDA WATKINS", Position = "Florist", Image = "h3-team-img-4.png"
            });
            modelBuilder.Entity<Info>().HasData(new Info
            {
                Id = 1, Name = "Anna Barnes", Position = "Florist", Subtitle = "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus lingua.", Image = "testimonial-img-1.png"
            }, new Info
            {
                Id = 2, Name = "Jasmine White", Position = "Florist", Subtitle = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget.", Image = "testimonial-img-2.png"
            });
        }

    }
}
