using System;
using System.Collections;
using System.Collections.Generic;

namespace UsersService.Entity
{
    public class MockEntity
    {
        public MockEntity()
        {

        }

        public IEnumerable<User> GetMockUsers()
        {
            IList list = new List<User>();

            var user = new User()
            {
                ID =  "Nila0001",
                FirstName = "Scottish",
                LastName = "Plubmcer",
                BillingAddress = new Address()
                {
                    Address1 = "133 ELM Street",
                    Address2 = "",
                    City = "Wembley",
                    Country = "UK",
                    Zipcode = "98012"
                },
                DOB = DateTime.Parse("12/10/2009"),
                JoinDate = DateTime.Parse("12/10/2019"),
                MailingAddress = new Address()
                {
                    Address1 = "133 ELM Street",
                    Address2 = "",
                    City = "Wembley",
                    Country = "UK",
                    Zipcode = "98012"
                },
                TypeOfUser = UserType.ServiceProvider
            };
            list.Add(user);

             user = new User()
            {
                 ID =  "Nila0002",
                FirstName = "Robert",
                LastName = "Clave",
                BillingAddress = new Address()
                {
                    Address1 = "133 Swat Street",
                    Address2 = "",
                    City = "Hillsboro",
                    Country = "OR",
                    Zipcode = "98133"
                },
                DOB = DateTime.Parse("12/10/1974"),
                JoinDate = DateTime.Parse("12/10/2001"),
                MailingAddress = new Address()
                {
                    Address1 = "133 Noname Street",
                    Address2 = "",
                    City = "Hillsboro",
                    Country = "OR",
                    Zipcode = "98133"
                },
                TypeOfUser = UserType.Customer
            };
            list.Add(user);
            return (IEnumerable<User>)list;
        }
    }
}