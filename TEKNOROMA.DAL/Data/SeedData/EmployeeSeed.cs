using TEKNOROMA.MODEL.Entities;
using TEKNOROMA.MODEL.Enums;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class EmployeeSeed
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee{ID=1,IdentificationNumber="91154698403",FirstName="Elizabeth J.",LastName="McDowell",Gender=Gender.Female,Department="Sales Director",Position="Sales Director",Salary=1250,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=1},
            new Employee{ID=2,IdentificationNumber="12832155199",FirstName="Helen J.",LastName="Spinks",Gender=Gender.Female,Department="Sales Account Manager",Position="Sales Account Manager",Salary=2000,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=1},
            new Employee{ID=3,IdentificationNumber="07056163008",FirstName="Richie L.",LastName="Santos",Gender=Gender.Male,Department="District Sales Manager",Position="District Sales Manager",Salary=3000,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=1},

            new Employee{ID=4,IdentificationNumber="54988164456",FirstName="Melissa K.",LastName="Worcester",Gender=Gender.Female,Department="Regional Sales Manager",Position="Regional Sales Manager",Salary=2500,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=2},
            new Employee{ID=5,IdentificationNumber="46257358534",FirstName="Erin C.",LastName="Austin",Gender=Gender.Female,Department="Export Manager",Position="Export Manager",Salary=1750,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=2},
            new Employee{ID=6,IdentificationNumber="56253655019",FirstName="Michael N.",LastName="Chaparro",Gender=Gender.Male,Department="Territory Sales Manager",Position="Territory Sales Manager",Salary=2250,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 9, 30),StoreID=2},

            new Employee{ID=7,IdentificationNumber="05878968905",FirstName="Daniel E.",LastName="Horton",Gender=Gender.Male,Department="E-Commerce Director",Position="E-Commerce Director",Salary=3250,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=3},
            new Employee{ID=8,IdentificationNumber="08147563289",FirstName="Scarlet M.",LastName="Clay",Gender=Gender.Female,Department="Regional Sales Manager",Position="Regional Sales Manager",Salary=1000,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=3},
            new Employee{ID=9,IdentificationNumber="37679564411",FirstName="Julie E.",LastName="Brooks",Gender=Gender.Female,Department="District Sales Manager",Position="District Sales Manager",Salary=1500,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=3},

            new Employee{ID=10,IdentificationNumber="05911881446",FirstName="Gladys L.",LastName="Hinderliter",Gender=Gender.Female,Department="Sales Director",Position="Sales Director",Salary=1750,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=4},
            new Employee{ID=11,IdentificationNumber="25076882851",FirstName="Craig D.",LastName="Pettey",Gender=Gender.Male,Department="Export Manager",Position="Export Manager",Salary=3250,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=4},
            new Employee{ID=12,IdentificationNumber="64589309183",FirstName="Christopher M.",LastName="Lee",Gender=Gender.Male,Department="District Sales Manager",Position="District Sales Manager",Salary=2750,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=4},

            new Employee{ID=13,IdentificationNumber="08141949730",FirstName="Selina R.",LastName="Lincoln",Gender=Gender.Female,Department="Sales Account Manager",Position="Sales Account Manager",Salary=1500,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=5},
            new Employee{ID=14,IdentificationNumber="08768319219",FirstName="Jillian K.",LastName="Pope",Gender=Gender.Female,Department="E-Commerce Director",Position="E-Commerce Director",Salary=2750,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=5},
            new Employee{ID=15,IdentificationNumber="92525708751",FirstName="Nelson J.",LastName="Thompson",Gender=Gender.Male,Department="District Sales Manager",Position="District Sales Manager",Salary=3500,PaymentDate=new DateTime(2024, 7, 31),HireDate=new DateTime(2024, 7, 1),StoreID=5}
        };
    }
}
