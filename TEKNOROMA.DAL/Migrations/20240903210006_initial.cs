using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TEKNOROMA.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedDate", "Description" },
                values: new object[,]
                {
                    { 1, "ComputerHardware", new DateTime(2024, 9, 4, 0, 0, 5, 620, DateTimeKind.Local).AddTicks(3993), "This Category About Computer Hardwares" },
                    { 2, "MobilePhone", new DateTime(2024, 9, 4, 0, 0, 5, 622, DateTimeKind.Local).AddTicks(7633), "This Category About Mobile Phones" },
                    { 3, "Camera", new DateTime(2024, 9, 4, 0, 0, 5, 622, DateTimeKind.Local).AddTicks(7646), "This Category About Cameras" },
                    { 4, "PhotographicCamera", new DateTime(2024, 9, 4, 0, 0, 5, 622, DateTimeKind.Local).AddTicks(7648), "This Category About Photographic Cameras" },
                    { 5, "PackageSoftware", new DateTime(2024, 9, 4, 0, 0, 5, 622, DateTimeKind.Local).AddTicks(7649), "This Category About Package Softwares" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedDate", "Email", "FirstName", "Gender", "IdentificationNumber", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(2055), "paulthrower@gmail.com", "Paul S.", 0, "93769866866", "Thrower" },
                    { 2, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3270), "johnbarnhart@outlook.com", "John J.", 0, "56992551143", "Barnhart" },
                    { 3, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3274), "modestoclark@yahoo.com", "Modesto E.", 1, "74991120461", "Clark" },
                    { 4, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3276), "rogercrawford@gmail.com", "Roger J.", 0, "37196481028", "Crawford" },
                    { 5, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3277), "jessejorge@outlook.com", "Jesse E.", 1, "87266168646", "Jorge" },
                    { 6, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3282), "keithneville@yahoo.com", "Keith N.", 1, "77474758025", "Neville" },
                    { 7, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3283), "jeffmorse@gmail.com", "Jeff M.", 0, "78798330914", "Morse" },
                    { 8, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3285), "thomascrouch@outlook.com", "Thomas J.", 0, "58633320397", "Crouch" },
                    { 9, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3286), "armandchristie@yahoo.com", "Armand B.", 0, "48187808613", "Christie" },
                    { 10, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(3289), "lolitabellamy@gmail.com", "Lolita R.", 1, "48596366099", "Bellamy" }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ID", "Amount", "CreatedDate", "Date", "Description" },
                values: new object[,]
                {
                    { 1, 1500m, new DateTime(2024, 9, 4, 0, 0, 5, 628, DateTimeKind.Local).AddTicks(2753), new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ofis Kirası" },
                    { 2, 300m, new DateTime(2024, 9, 4, 0, 0, 5, 628, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elektrik Faturası" },
                    { 3, 100m, new DateTime(2024, 9, 4, 0, 0, 5, 628, DateTimeKind.Local).AddTicks(3557), new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internet" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "ID", "Amount", "CreatedDate", "Date", "InvoiceNumber" },
                values: new object[,]
                {
                    { 1, 2000m, new DateTime(2024, 9, 4, 0, 0, 5, 628, DateTimeKind.Local).AddTicks(5918), new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "INV001" },
                    { 2, 1500m, new DateTime(2024, 9, 4, 0, 0, 5, 628, DateTimeKind.Local).AddTicks(6729), new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "INV002" },
                    { 3, 2500m, new DateTime(2024, 9, 4, 0, 0, 5, 628, DateTimeKind.Local).AddTicks(6734), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "INV003" }
                });

            migrationBuilder.InsertData(
                table: "ServiceRequests",
                columns: new[] { "ID", "CreatedDate", "Description", "Status", "Type" },
                values: new object[] { 1, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(9642), "Uygulama Çalışmıyor.", "Aktif", "Uygulama Hatasi" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "ID", "CreatedDate", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(5360), "Istanbul", "Teknorama Istanbul" },
                    { 2, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(5998), "Ankara", "Teknorama Ankara" },
                    { 3, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(6002), "Izmir", "Teknorama Izmir" },
                    { 4, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(6003), "Antalya", "Teknorama Antalya" },
                    { 5, new DateTime(2024, 9, 4, 0, 0, 5, 625, DateTimeKind.Local).AddTicks(6004), "Bursa", "Teknorama Bursa" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "ContactInfo", "CreatedDate", "SupplierName" },
                values: new object[,]
                {
                    { 1, "(304) 403-9258", new DateTime(2024, 9, 4, 0, 0, 5, 623, DateTimeKind.Local).AddTicks(5484), "Kunde, Wyman and Lynch" },
                    { 2, "(479) 319-9089", new DateTime(2024, 9, 4, 0, 0, 5, 623, DateTimeKind.Local).AddTicks(6042), "Yost - Schaefer" },
                    { 3, "(204) 682-6716", new DateTime(2024, 9, 4, 0, 0, 5, 623, DateTimeKind.Local).AddTicks(6046), "Upton, Runte and Crist" },
                    { 4, "(435) 939-5118", new DateTime(2024, 9, 4, 0, 0, 5, 623, DateTimeKind.Local).AddTicks(6047), "Sipes and Sons" },
                    { 5, "(801) 473-0584", new DateTime(2024, 9, 4, 0, 0, 5, 623, DateTimeKind.Local).AddTicks(6048), "Kihn, McClure and Muller" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "CreatedDate", "Department", "FirstName", "Gender", "HireDate", "IdentificationNumber", "LastName", "PaymentDate", "Position", "Salary", "StoreID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(5696), "Sales Director", "Elizabeth J.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "91154698403", "McDowell", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Director", 1250m, 1 },
                    { 2, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8135), "Sales Account Manager", "Helen J.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12832155199", "Spinks", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Account Manager", 2000m, 1 },
                    { 3, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8143), "District Sales Manager", "Richie L.", 0, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "07056163008", "Santos", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "District Sales Manager", 3000m, 1 },
                    { 4, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8146), "Regional Sales Manager", "Melissa K.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "54988164456", "Worcester", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regional Sales Manager", 2500m, 2 },
                    { 5, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8149), "Export Manager", "Erin C.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "46257358534", "Austin", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Export Manager", 1750m, 2 },
                    { 6, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8154), "Territory Sales Manager", "Michael N.", 0, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "56253655019", "Chaparro", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Territory Sales Manager", 2250m, 2 },
                    { 7, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8157), "E-Commerce Director", "Daniel E.", 0, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "05878968905", "Horton", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-Commerce Director", 3250m, 3 },
                    { 8, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8175), "Regional Sales Manager", "Scarlet M.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "08147563289", "Clay", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regional Sales Manager", 1000m, 3 },
                    { 9, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8178), "District Sales Manager", "Julie E.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "37679564411", "Brooks", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "District Sales Manager", 1500m, 3 },
                    { 10, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8182), "Sales Director", "Gladys L.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "05911881446", "Hinderliter", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Director", 1750m, 4 },
                    { 11, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8184), "Export Manager", "Craig D.", 0, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "25076882851", "Pettey", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Export Manager", 3250m, 4 },
                    { 12, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8187), "District Sales Manager", "Christopher M.", 0, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "64589309183", "Lee", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "District Sales Manager", 2750m, 4 },
                    { 13, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8190), "Sales Account Manager", "Selina R.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "08141949730", "Lincoln", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales Account Manager", 1500m, 5 },
                    { 14, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8193), "E-Commerce Director", "Jillian K.", 1, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "08768319219", "Pope", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-Commerce Director", 2750m, 5 },
                    { 15, new DateTime(2024, 9, 4, 0, 0, 5, 626, DateTimeKind.Local).AddTicks(8196), "District Sales Manager", "Nelson J.", 0, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "92525708751", "Thompson", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "District Sales Manager", 3500m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "CreatedDate", "CustomerID", "OrderDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2239), 1, new DateTime(2024, 9, 5, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2243) },
                    { 2, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2942), 2, new DateTime(2024, 9, 6, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2946) },
                    { 3, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2950), 3, new DateTime(2024, 9, 7, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2951) },
                    { 4, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2952), 4, new DateTime(2024, 9, 8, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2953) },
                    { 5, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2954), 5, new DateTime(2024, 9, 9, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2955) },
                    { 6, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2959), 6, new DateTime(2024, 9, 10, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2959) },
                    { 7, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2961), 7, new DateTime(2024, 9, 11, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2961) },
                    { 8, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2963), 8, new DateTime(2024, 9, 12, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2963) },
                    { 9, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2964), 9, new DateTime(2024, 9, 13, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2965) },
                    { 10, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2967), 10, new DateTime(2024, 9, 14, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(2967) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedDate", "Description", "Price", "ProductName", "StockQuantity", "SupplierID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(6433), "Intel Processor", 15000m, "Intel i9-12900K", 1000, 1 },
                    { 2, 1, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8005), "AMD Processor", 20000m, "AMD Ryzen 9 9950X ", 750, 1 },
                    { 3, 1, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8010), "Asus Motherborad", 17500m, "Asus ROG Strix X670E-E", 1250, 1 },
                    { 4, 1, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8012), "GSKILL RAM", 10000m, "GSKILL 64GB (2x32GB) DDR4 4000MHz CL18", 500, 1 },
                    { 5, 1, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8014), "Samsung SSD", 7500m, "Samsung 980 PRO NVMe™ M.2 SSD 1 TB", 2000, 1 },
                    { 6, 2, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8019), "Apple Mobile Phone", 80000m, "Apple iPhone 15 Pro Max 256 GB", 2500, 2 },
                    { 7, 2, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8020), "Samsung Mobile Phone", 65000m, "Samsung Galaxy S23 Ultra 256 GB", 1500, 2 },
                    { 8, 2, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8022), "Xiaomi Mobile Phone", 25000m, "Xiaomi Mi 11 Ultra 256 GB", 3000, 2 },
                    { 9, 2, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8024), "Apple Mobile Phone", 40000m, "Apple iPhone SE 2 (2020) 64 GB", 3500, 2 },
                    { 10, 2, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8027), "Samsung Mobile Phone", 72500m, "Samsung Galaxy Z Flip 3 128 GB", 1750, 2 },
                    { 11, 3, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8051), "TP-Link Camera", 15000m, "TP-Link Tapo C420S2, 2K 4MP QHD", 5000, 3 },
                    { 12, 3, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8053), "Jadfezy Camera", 22250m, "Jadfezy WiFi Action Camera Ultra HD 1080p", 4500, 3 },
                    { 13, 3, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8054), "Sony Camera", 35000m, "Sony FX30 Body Süper 35 Digital Cinema Camera", 2500, 3 },
                    { 14, 3, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8056), "Xiaomi Camera", 12500m, "Xiaomi Smart Camera C300 Spherical IP Security Camera", 4750, 3 },
                    { 15, 3, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8058), "Canon Camera", 37500m, "Canon EOS 2000D BK 18-55 EU26 DSLR", 2750, 3 },
                    { 16, 4, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8060), "Nikon Photographic Camera", 50000m, "Nikon D7500 20.9MP DSLR", 3000, 4 },
                    { 17, 4, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8061), "Panasonic Photographic Camera", 37500m, "Panasonic LUMIX G85 4K Digital Camera", 7500, 4 },
                    { 18, 4, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8064), "Sony Photographic Camera", 25000m, "Sony Alpha a6400 Mirrorless Camera", 1500, 4 },
                    { 19, 4, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8066), "Fujifilm Photographic Camera", 45000m, "Fujifilm X-T5 Mirrorless Digital Camera", 4500, 4 },
                    { 20, 4, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8068), "Canon Photographic Camera", 32500m, "Canon EOS REBEL SL3 (BK) + EF-S18-55mm", 7750, 4 },
                    { 21, 5, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8070), "Microsoft Office Package Software", 5000m, "Microsoft Office 365 Personal", 10000, 5 },
                    { 22, 5, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8071), "Internet Download Manager Package Software", 2500m, "Internet Download Manager Lifetime License", 7000, 5 },
                    { 23, 5, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8073), "CCleaner Package Software", 3000m, "CCleaner Pro Plus", 5000, 5 },
                    { 24, 5, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8075), "WinRAR Package Software", 1500m, "WinRAR SINGLE-USER - LICENSE", 2500, 5 },
                    { 25, 5, new DateTime(2024, 9, 4, 0, 0, 5, 624, DateTimeKind.Local).AddTicks(8077), "Revo Uninstaller Package Software", 4250m, "Revo Uninstaller PRO PORTABLE", 7500, 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "ID", "CreatedDate", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(6975), 1, 1, 25, 15000m },
                    { 2, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8066), 2, 5, 50, 7500m },
                    { 3, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8070), 3, 10, 15, 72500m },
                    { 4, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8072), 4, 20, 45, 32500m },
                    { 5, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8073), 5, 25, 5, 4250m },
                    { 6, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8077), 6, 3, 30, 17500m },
                    { 7, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8079), 7, 7, 10, 65000m },
                    { 8, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8080), 8, 9, 35, 40000m },
                    { 9, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8082), 9, 12, 40, 22250m },
                    { 10, new DateTime(2024, 9, 4, 0, 0, 5, 627, DateTimeKind.Local).AddTicks(8084), 10, 17, 20, 37500m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StoreID",
                table: "Employees",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductID",
                table: "OrderItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
