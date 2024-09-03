using TEKNOROMA.MODEL.Entities;
using TEKNOROMA.MODEL.Enums;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class CustomerSeed
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer{ID=1,IdentificationNumber="93769866866",FirstName="Paul S.",LastName="Thrower",Gender=Gender.Male,Email="paulthrower@gmail.com"},
            new Customer{ID=2,IdentificationNumber="56992551143",FirstName="John J.",LastName="Barnhart",Gender=Gender.Male,Email="johnbarnhart@outlook.com"},
            new Customer{ID=3,IdentificationNumber="74991120461",FirstName="Modesto E.",LastName="Clark",Gender=Gender.Female,Email="modestoclark@yahoo.com"},
            new Customer{ID=4,IdentificationNumber="37196481028",FirstName="Roger J.",LastName="Crawford",Gender=Gender.Male,Email="rogercrawford@gmail.com"},
            new Customer{ID=5,IdentificationNumber="87266168646",FirstName="Jesse E.",LastName="Jorge",Gender=Gender.Female,Email="jessejorge@outlook.com"},
            new Customer{ID=6,IdentificationNumber="77474758025",FirstName="Keith N.",LastName="Neville",Gender=Gender.Female,Email="keithneville@yahoo.com"},
            new Customer{ID=7,IdentificationNumber="78798330914",FirstName="Jeff M.",LastName="Morse",Gender=Gender.Male,Email="jeffmorse@gmail.com"},
            new Customer{ID=8,IdentificationNumber="58633320397",FirstName="Thomas J.",LastName="Crouch",Gender=Gender.Male,Email="thomascrouch@outlook.com"},
            new Customer{ID=9,IdentificationNumber="48187808613",FirstName="Armand B.",LastName="Christie",Gender=Gender.Male,Email="armandchristie@yahoo.com"},
            new Customer{ID=10,IdentificationNumber="48596366099",FirstName="Lolita R.",LastName="Bellamy",Gender=Gender.Female,Email="lolitabellamy@gmail.com"}
        };
    }
}
