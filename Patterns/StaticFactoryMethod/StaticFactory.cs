using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.StaticFactoryMethod
{
    public class StaticFactory
    {
        //для упрощения создания объектов

        public static User CreateDefaultUser()
        {
            User user = new User();
            user.firstName = "Alex";
            user.lastName = "Portnov";
            user.age = 25;

            return user;
        }

        public static User CreateUserByBirthYear(int year)
        {
            User user = new User();
            user.age = 2017 - year;

            return user;
        }
    }
}
