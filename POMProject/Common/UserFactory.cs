using POMProject.Users;

namespace POMProject.Common
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Ventsi",
                LastName = "Batman",
                Year = "1989",
                Month = "3",
                Date = "3",
                Password = "gdsjafgujdsw",
                Gender = "male",
                PostCode = "54422",
                RealFirstName = "John",
                RealLastName = "Smith",
                Address = "Somwhere",
                City = "Pernik",
                State = "5",
                Alias = "alabala",
                Country = "COunty",
                Phone = "3423476786998"              
            };
        }

        public static RegistrationUser CreateInvalidZipUser()
        {
            return new RegistrationUser
            {
                FirstName = "Ventsi",
                LastName = "Batman",
                Year = "1989",
                Month = "3",
                Date = "3",
                Password = "gdsjafgujdsw",
                Gender = "male",
                PostCode = "54422333",
                RealFirstName = "John",
                RealLastName = "Smith",
                Address = "Somwhere",
                City = "Pernik",
                State = "5",
                Alias = "alabala",
                Country = "COunty",
                Phone = "3423476786998"
            };
        }

        public static RegistrationUser CreateInvalidFirstnameUser()
        {
            return new RegistrationUser
            {
                FirstName = "",
                LastName = "Batman",
                Year = "1990",
                Month = "3",
                Date = "3",
                Password = "gdsjafgujdsw",
                Gender = "male",
                PostCode = "54422",
                RealFirstName = "John",
                RealLastName = "Smith",
                Address = "Somwhere",
                City = "Pernik",
                State = "5",
                Alias = "alabala",
                Country = "COunty",
                Phone = "3423476786998"
            };
        }
    }
}
