using System;
namespace UsersService.Entity
{
    public class User
    {
        public User()
        {

        }
        public string ID {get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType TypeOfUser { get; set; } 
        public DateTime DOB { get; set; }
        public DateTime JoinDate { get; set; }
        public Address MailingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }

    public enum UserType
    {
        Customer,
        ServiceProvider
    }

    public class Address
    {

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }

    }
}