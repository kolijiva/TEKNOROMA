using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class CategorySeed
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category{ID=1,CategoryName="ComputerHardware",Description="This Category About Computer Hardwares"},
            new Category{ID=2,CategoryName="MobilePhone",Description="This Category About Mobile Phones"},
            new Category{ID=3,CategoryName="Camera",Description="This Category About Cameras"},
            new Category{ID=4,CategoryName="PhotographicCamera",Description="This Category About Photographic Cameras"},
            new Category{ID=5,CategoryName="PackageSoftware",Description="This Category About Package Softwares"}
        };
    }
}
