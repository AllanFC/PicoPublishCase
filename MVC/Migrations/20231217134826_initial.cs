using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0664de50-3698-433d-b060-2013b7a62bf7"), "Samsungs premium-telefon med en imponerende skærm, alsidigt kamera og kraftfuld ydeevne.", "Samsung Galaxy S21 Ultra" },
                    { new Guid("16ec312b-9c3f-45db-ba3a-655f2f7bd534"), "Huaweis premium smartphone med et kraftfuldt kamera-system og imponerende design.", "Huawei P50 Pro" },
                    { new Guid("17a26cf1-d574-4ff8-8202-f4e4d007b4c7"), "Huaweis avancerede smartphone med kraftfuld processor og avanceret kamera.", "Huawei Mate 40 Pro" },
                    { new Guid("2af31e92-6f95-4cb4-b4cf-dcff6a5e6115"), "OnePlus' flagskibs-enhed med hurtig ydeevne, en glat skærm og fantastiske kameraer.", "OnePlus 9 Pro" },
                    { new Guid("2cd2e696-36f6-4368-b346-449a7a792490"), "Realmes overkommelige smartphone med et unikt design og god ydelse.", "Realme GT Master Edition" },
                    { new Guid("31988d6d-e555-452d-98fe-9e844b4c760a"), "Googles smartphone kendt for dens exceptionelle kamerakapaciteter og AI-drevne funktioner.", "Google Pixel 6 Pro" },
                    { new Guid("45696051-17ab-4460-a47f-21586674ea0f"), "Xiaomis high-end telefon med et kvalitetskamera-setup og en smuk AMOLED-skærm.", "Xiaomi Mi 11 Ultra" },
                    { new Guid("5896effa-75da-4b99-9ad4-87953c1e6dfa"), "OnePlus' 5G-mid-range telefon med hurtig ydeevne og et slankt design.", "OnePlus Nord CE 5G" },
                    { new Guid("61f001c7-efc8-49cc-aafc-4669ab951a6a"), "Motorolas budgetvenlige smartphone med grundlæggende funktioner og lang batterilevetid.", "Motorola Moto E7" },
                    { new Guid("65c35b53-520c-401a-9501-6d9a4bbdb1a4"), "Apples flagskibs-smartphone med en kraftfuld A15 Bionic-chip og avanceret kamera.", "iPhone 13 Pro" },
                    { new Guid("7d63bd70-b2a8-4093-95f6-276fb311ef84"), "Xiaomis telefon med stærk ydeevne og imponerende batterilevetid.", "Xiaomi Poco X3 Pro" },
                    { new Guid("83f4e414-72d8-43f2-9742-665a05bb9b57"), "Sonys flagskibs-enhed kendt for dens 4K OLED-skærm og avancerede kamerafunktioner.", "Sony Xperia 1 III" },
                    { new Guid("879adddc-5b3b-40fd-a92a-f96dbadb5bef"), "Asus' kompakte smartphone med stærk ydeevne og fremragende skærmkvalitet.", "Asus Zenfone 8" },
                    { new Guid("9c57be99-eadf-47e8-8ca9-ec1f2e0a668f"), "Sonys kraftfulde telefon kendt for sit kompakte design og imponerende skærm.", "Sony Xperia 5 III" },
                    { new Guid("a90e6a18-8b7d-4a05-b44b-9f279c55256c"), "Samsungs 5G-telefon med en skarp skærm og alsidige funktioner.", "Samsung Galaxy A52s 5G" },
                    { new Guid("b12c5bb0-cb60-4ff9-a56f-731bf213be08"), "Realmes budgetvenlige smartphone med anstændige specifikationer og god batterilevetid.", "Realme Narzo 50A" },
                    { new Guid("b72358f4-b72d-42fe-ba61-a6bd8509976b"), "Googles prisvenlige smartphone med god kamerateknologi og brugervenlig oplevelse.", "Google Pixel 4a" },
                    { new Guid("bb7bf306-5868-4106-a566-dab617750626"), "Xiaomis prisvenlige smartphone med en god skærm og lang batterilevetid.", "Xiaomi Redmi 10" },
                    { new Guid("d2023d12-b9b3-4d49-9306-56b59365f22a"), "Xiaomis prisvenlige telefon med en god skærm og solid ydeevne.", "Xiaomi Redmi Note 10" },
                    { new Guid("d206ba73-794a-4f4d-b5a6-a73c86638f5a"), "Samsungs foldbare smartphone med imponerende skærmteknologi og alsidig brug.", "Samsung Galaxy Z Fold 3" },
                    { new Guid("d307b89d-9371-4465-af89-11c8f9806e65"), "Nokias robuste telefon designet til at modstå barske forhold og holde længe.", "Nokia XR20" },
                    { new Guid("d3f6704c-4864-4ed4-8d10-5536e5f201e1"), "Nokias prisvenlige 5G-smartphone med en pålidelig ydeevne og robust design.", "Nokia G50" },
                    { new Guid("d8af5558-3d60-4140-833c-225abfbfe828"), "Motorolas telefon kendt for sin lange batterilevetid og pålidelige ydeevne.", "Motorola Moto G Power" },
                    { new Guid("e1527334-20ee-4272-92c4-eaffcf7c0243"), "Asus' gaming-telefon med kraftfuld hardware og avancerede spilfunktioner.", "Asus ROG Phone 5" },
                    { new Guid("e2a02188-1f1e-4952-940d-e1151dd5d9d7"), "Sonys mellemklasse-smartphone med lang batterilevetid og god skærmkvalitet.", "Sony Xperia 10 III" },
                    { new Guid("e419bb07-9b2c-4640-bcb4-62607383cbc9"), "Googles mellemklasse-smartphone med et pålideligt kamera og lang batterilevetid.", "Google Pixel 5a" },
                    { new Guid("e87defdc-9f56-4da1-a1c0-64316c00db85"), "OnePlus' tidligere flagskibs-enhed med god ydeevne og hurtig opladning.", "OnePlus 8T" },
                    { new Guid("f94a591b-eefd-4e16-a4e8-f99ba3ed4e64"), "Motorolas telefon med en stylus-pen og pålidelig ydeevne.", "Motorola Moto G Stylus" },
                    { new Guid("fb996825-0dc5-406a-a275-016404635fba"), "OnePlus' mellemklasse-telefon med god ydeevne og et kompetent kamera-system.", "OnePlus Nord 2" },
                    { new Guid("fbb8814e-54f5-4d33-85c4-36e1f3a037de"), "Motorolas telefon med en skærm med høj opdateringshastighed og god batterilevetid.", "Motorola Edge 20 Pro" },
                    { new Guid("ff1d5953-3cf9-4114-add1-fe959fb915f5"), "Realmes hurtige smartphone med avancerede specifikationer og stilfuldt design.", "Realme GT Neo 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
