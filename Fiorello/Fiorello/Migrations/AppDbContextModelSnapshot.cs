// <auto-generated />
using Fiorello.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiorello.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiorello.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h3-video-img.jpg",
                            Subtitle = "Where flowers are our inspiration to create lasting memories. Whatever the occasion...",
                            Title = "<h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.AboutList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutLists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h1-custom-icon.png",
                            Title = "Hand picked just for you."
                        },
                        new
                        {
                            Id = 2,
                            Image = "h1-custom-icon.png",
                            Title = "Unique flower arrangements"
                        },
                        new
                        {
                            Id = 3,
                            Image = "h1-custom-icon.png",
                            Title = "Best way to say you care."
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Fiorello.Models.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h3-team-img-1.png",
                            Name = "CRYSTAL BROOKS",
                            Position = "Florist"
                        },
                        new
                        {
                            Id = 2,
                            Image = "h3-team-img-2.png",
                            Name = "SHIRLEY HARRIS",
                            Position = "Manager"
                        },
                        new
                        {
                            Id = 3,
                            Image = "h3-team-img-3.png",
                            Name = "BEVERLY CLARK",
                            Position = "Florist"
                        },
                        new
                        {
                            Id = 4,
                            Image = "h3-team-img-4.png",
                            Name = "AMANDA WATKINS",
                            Position = "Florist"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Infos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "testimonial-img-1.png",
                            Name = "Anna Barnes",
                            Position = "Florist",
                            Subtitle = "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus lingua."
                        },
                        new
                        {
                            Id = 2,
                            Image = "testimonial-img-2.png",
                            Name = "Jasmine White",
                            Position = "Florist",
                            Subtitle = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget."
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Fiorello.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h3-slider-background.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Image = "h3-slider-background-2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Image = "h3-slider-background-3.jpg"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.SliderData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SliderDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "h2-sign-img.png",
                            Subtitle = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.",
                            Title = "<h1>Send <span>flowers</span> like</h1><h1> you mean it </h1>"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Product", b =>
                {
                    b.HasOne("Fiorello.Models.Category", "Category")
                        .WithMany("Prooducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Fiorello.Models.Category", b =>
                {
                    b.Navigation("Prooducts");
                });
#pragma warning restore 612, 618
        }
    }
}
