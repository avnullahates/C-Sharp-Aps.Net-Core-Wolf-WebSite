using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-FA6RBVRG; database=KorayWebsite ; user=sa; password=1234; TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server = LAPTOP-FA6RBVRG; database = KorayWebsite; Persist Security Info = False; user =sa; Password = 123; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False; Connection Timeout = 30; ");
        }

        public DbSet<AboutUs> AboutUses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeaturesItem> FeaturesItems { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioTypes> PortfolioTypes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SubAboutUs> SubAboutUses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Meta> Metas { get; set; }

    }


}
