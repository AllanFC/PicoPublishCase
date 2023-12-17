using Microsoft.EntityFrameworkCore;
using MVC.Models.Domain;

namespace MVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product("iPhone 13 Pro", "Apples flagskibs-smartphone med en kraftfuld A15 Bionic-chip og avanceret kamera."),
                new Product("Samsung Galaxy S21 Ultra", "Samsungs premium-telefon med en imponerende skærm, alsidigt kamera og kraftfuld ydeevne."),
                new Product("Google Pixel 6 Pro", "Googles smartphone kendt for dens exceptionelle kamerakapaciteter og AI-drevne funktioner."),
                new Product("OnePlus 9 Pro", "OnePlus' flagskibs-enhed med hurtig ydeevne, en glat skærm og fantastiske kameraer."),
                new Product("Xiaomi Mi 11 Ultra", "Xiaomis high-end telefon med et kvalitetskamera-setup og en smuk AMOLED-skærm."),
                new Product("Huawei P50 Pro", "Huaweis premium smartphone med et kraftfuldt kamera-system og imponerende design."),
                new Product("Sony Xperia 1 III", "Sonys flagskibs-enhed kendt for dens 4K OLED-skærm og avancerede kamerafunktioner."),
                new Product("OnePlus Nord 2", "OnePlus' mellemklasse-telefon med god ydeevne og et kompetent kamera-system."),
                new Product("Realme GT Master Edition", "Realmes overkommelige smartphone med et unikt design og god ydelse."),
                new Product("Motorola Edge 20 Pro", "Motorolas telefon med en skærm med høj opdateringshastighed og god batterilevetid."),
                new Product("Samsung Galaxy Z Fold 3", "Samsungs foldbare smartphone med imponerende skærmteknologi og alsidig brug."),
                new Product("Google Pixel 5a", "Googles mellemklasse-smartphone med et pålideligt kamera og lang batterilevetid."),
                new Product("OnePlus 8T", "OnePlus' tidligere flagskibs-enhed med god ydeevne og hurtig opladning."),
                new Product("Xiaomi Redmi Note 10", "Xiaomis prisvenlige telefon med en god skærm og solid ydeevne."),
                new Product("Huawei Mate 40 Pro", "Huaweis avancerede smartphone med kraftfuld processor og avanceret kamera."),
                new Product("Sony Xperia 5 III", "Sonys kraftfulde telefon kendt for sit kompakte design og imponerende skærm."),
                new Product("Realme Narzo 50A", "Realmes budgetvenlige smartphone med anstændige specifikationer og god batterilevetid."),
                new Product("Motorola Moto G Power", "Motorolas telefon kendt for sin lange batterilevetid og pålidelige ydeevne."),
                new Product("Nokia XR20", "Nokias robuste telefon designet til at modstå barske forhold og holde længe."),
                new Product("Asus Zenfone 8", "Asus' kompakte smartphone med stærk ydeevne og fremragende skærmkvalitet."),
                new Product("Xiaomi Redmi 10", "Xiaomis prisvenlige smartphone med en god skærm og lang batterilevetid."),
                new Product("Motorola Moto G Stylus", "Motorolas telefon med en stylus-pen og pålidelig ydeevne."),
                new Product("Realme GT Neo 2", "Realmes hurtige smartphone med avancerede specifikationer og stilfuldt design."),
                new Product("OnePlus Nord CE 5G", "OnePlus' 5G-mid-range telefon med hurtig ydeevne og et slankt design."),
                new Product("Sony Xperia 10 III", "Sonys mellemklasse-smartphone med lang batterilevetid og god skærmkvalitet."),
                new Product("Samsung Galaxy A52s 5G", "Samsungs 5G-telefon med en skarp skærm og alsidige funktioner."),
                new Product("Google Pixel 4a", "Googles prisvenlige smartphone med god kamerateknologi og brugervenlig oplevelse."),
                new Product("Xiaomi Poco X3 Pro", "Xiaomis telefon med stærk ydeevne og imponerende batterilevetid."),
                new Product("Motorola Moto E7", "Motorolas budgetvenlige smartphone med grundlæggende funktioner og lang batterilevetid."),
                new Product("Nokia G50", "Nokias prisvenlige 5G-smartphone med en pålidelig ydeevne og robust design."),
                new Product("Asus ROG Phone 5", "Asus' gaming-telefon med kraftfuld hardware og avancerede spilfunktioner.")

            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
