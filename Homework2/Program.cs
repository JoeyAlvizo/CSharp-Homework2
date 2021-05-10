using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            //1
            var helloPassword = from user in users
                                where user.Password == "hello"
                                select new { name = user.Name };
            Console.WriteLine("Users that have the password \"Hello\":");
            helloPassword.ToList().ForEach(user => Console.WriteLine(user.name));

            //2
            users.RemoveAll(t => t.Name.ToLower().Equals(t.Password));

            /*var namePasswordMatch = from user in users
                                    where !(user.Name.ToLower().Equals(user.Password))
                                    select new { name = user.Name };*///First attempt

            //3

            users.Remove(users.First(t => t.Password=="hello"));

            /*var temp = users.ToList();
            //temp.RemoveAll(user => user.Password.Equals("hello"));
            Models.User search = new Models.User { Password = "hello" };
            temp.Remove(search);
            users = temp;
            Console.WriteLine("Remove the first user with the password \"hello\":");*/// First attempt

            //4
            Console.WriteLine("Remaining users after deletion:");
            users.ToList().ForEach(user => Console.WriteLine(user.Name));
        }
    }
}
