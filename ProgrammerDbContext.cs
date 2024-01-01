using Microsoft.EntityFrameworkCore;

public class ProgrammerDbContext : DbContext

{

public ProgrammerDbContext(DbContextOptions<ProgrammerDbContext> options) : base(options)

{

}


public DbSet<Programmer> Programmers { get; set; }


 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     base.OnModelCreating(modelBuilder);

     modelBuilder.Entity<Programmer>().HasData(
         new Programmer
         {
             Id = 1,
             CodeName = "KyleSams",
             MobileDev = false,
             ExperienceYrs = 1,
             FullName = "Winfred Agyekum",
             PortfolioUrl = "",
         },
         new Programmer
         {
             Id = 2,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 3,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 4,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 5,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 6,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 7,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 8,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 9,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,

         },
         new Programmer
         {
             Id = 10,
             CodeName = "",
             MobileDev = true,
             FullName = "Samuel",
             PortfolioUrl = "",
             ExperienceYrs = 3,
         }
     );
 }

}

