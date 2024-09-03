using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class ProductSeed
    {
        public static List<Product> products = new List<Product>()
        {
            new Product{ID=1,ProductName="Intel i9-12900K",Description="Intel Processor",Price=15000,StockQuantity=1000,CategoryID=1,SupplierID=1},
            new Product{ID=2,ProductName="AMD Ryzen 9 9950X ",Description="AMD Processor",Price=20000,StockQuantity=750,CategoryID=1,SupplierID=1},
            new Product{ID=3,ProductName="Asus ROG Strix X670E-E",Description="Asus Motherborad",Price=17500,StockQuantity=1250,CategoryID=1,SupplierID=1},
            new Product{ID=4,ProductName="GSKILL 64GB (2x32GB) DDR4 4000MHz CL18",Description="GSKILL RAM",Price=10000,StockQuantity=500,CategoryID=1,SupplierID=1},
            new Product{ID=5,ProductName="Samsung 980 PRO NVMe™ M.2 SSD 1 TB",Description="Samsung SSD",Price=7500,StockQuantity=2000,CategoryID=1,SupplierID=1},

            new Product{ID=6,ProductName="Apple iPhone 15 Pro Max 256 GB",Description="Apple Mobile Phone",Price=80000,StockQuantity=2500,CategoryID=2,SupplierID=2},
            new Product{ID=7,ProductName="Samsung Galaxy S23 Ultra 256 GB",Description="Samsung Mobile Phone",Price=65000,StockQuantity=1500,CategoryID=2,SupplierID=2},
            new Product{ID=8,ProductName="Xiaomi Mi 11 Ultra 256 GB",Description="Xiaomi Mobile Phone",Price=25000,StockQuantity=3000,CategoryID=2,SupplierID=2},
            new Product{ID=9,ProductName="Apple iPhone SE 2 (2020) 64 GB",Description="Apple Mobile Phone",Price=40000,StockQuantity=3500,CategoryID=2,SupplierID=2},
            new Product{ID=10,ProductName="Samsung Galaxy Z Flip 3 128 GB",Description="Samsung Mobile Phone",Price=72500,StockQuantity=1750,CategoryID=2,SupplierID=2},

            new Product{ID=11,ProductName="TP-Link Tapo C420S2, 2K 4MP QHD",Description="TP-Link Camera",Price=15000,StockQuantity=5000,CategoryID=3,SupplierID=3},
            new Product{ID=12,ProductName="Jadfezy WiFi Action Camera Ultra HD 1080p",Description="Jadfezy Camera",Price=22250,StockQuantity=4500,CategoryID=3,SupplierID=3},
            new Product{ID=13,ProductName="Sony FX30 Body Süper 35 Digital Cinema Camera",Description="Sony Camera",Price=35000,StockQuantity=2500,CategoryID=3,SupplierID=3},
            new Product{ID=14,ProductName="Xiaomi Smart Camera C300 Spherical IP Security Camera",Description="Xiaomi Camera",Price=12500,StockQuantity=4750,CategoryID=3,SupplierID=3},
            new Product{ID=15,ProductName="Canon EOS 2000D BK 18-55 EU26 DSLR",Description="Canon Camera",Price=37500,StockQuantity=2750,CategoryID=3,SupplierID=3},

            new Product{ID=16,ProductName="Nikon D7500 20.9MP DSLR",Description="Nikon Photographic Camera",Price=50000,StockQuantity=3000,CategoryID=4,SupplierID=4},
            new Product{ID=17,ProductName="Panasonic LUMIX G85 4K Digital Camera",Description="Panasonic Photographic Camera",Price=37500,StockQuantity=7500,CategoryID=4,SupplierID=4},
            new Product{ID=18,ProductName="Sony Alpha a6400 Mirrorless Camera",Description="Sony Photographic Camera",Price=25000,StockQuantity=1500,CategoryID=4,SupplierID=4},
            new Product{ID=19,ProductName="Fujifilm X-T5 Mirrorless Digital Camera",Description="Fujifilm Photographic Camera",Price=45000,StockQuantity=4500,CategoryID=4,SupplierID=4},
            new Product{ID=20,ProductName="Canon EOS REBEL SL3 (BK) + EF-S18-55mm",Description="Canon Photographic Camera",Price=32500,StockQuantity=7750,CategoryID=4,SupplierID=4},

            new Product{ID=21,ProductName="Microsoft Office 365 Personal",Description="Microsoft Office Package Software",Price=5000,StockQuantity=10000,CategoryID=5,SupplierID=5},
            new Product{ID=22,ProductName="Internet Download Manager Lifetime License",Description="Internet Download Manager Package Software",Price=2500,StockQuantity=7000,CategoryID=5,SupplierID=5},
            new Product{ID=23,ProductName="CCleaner Pro Plus",Description="CCleaner Package Software",Price=3000,StockQuantity=5000,CategoryID=5,SupplierID=5},
            new Product{ID=24,ProductName="WinRAR SINGLE-USER - LICENSE",Description="WinRAR Package Software",Price=1500,StockQuantity=2500,CategoryID=5,SupplierID=5},
            new Product{ID=25,ProductName="Revo Uninstaller PRO PORTABLE",Description="Revo Uninstaller Package Software",Price=4250,StockQuantity=7500,CategoryID=5,SupplierID=5}
        };
    }
}
