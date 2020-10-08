using System;
using System.Collections.Generic;

namespace Assignment_One
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = GetUsers();
            Console.WriteLine("Choose user");
            for (int i = 0; i < users.Count; i++)
            {
                var user = users[i];
                Console.WriteLine($"{i}->{user[UserKey.FirstName]} {user[UserKey.LastName]} ");
            }
            int index = Convert.ToInt32(Console.ReadLine());
            User chosenUser = new User(users[index][UserKey.FirstName], users[index][UserKey.LastName], users[index][UserKey.Address]);

            Console.WriteLine("Enter title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter message");
            string content = Console.ReadLine();

            Post.SendMessage(chosenUser, new Message(title, content));
            Console.ReadLine();
        }

        private static List<Dictionary<UserKey, string>> GetUsers()
        {
            var usersList = new List<Dictionary<UserKey, string>>();

            usersList.Add(new Dictionary<UserKey, string>
            {
                {UserKey.FirstName,"Eric" },
                {UserKey.LastName,"Cartman" },
                {UserKey.Address,"Somewhere at colorado" },
            });
            usersList.Add(new Dictionary<UserKey, string>
            {
                {UserKey.FirstName,"Kyle" },
                {UserKey.LastName,"Broflovski" },
                {UserKey.Address,"Somewhere at colorado" },
            });
            usersList.Add(new Dictionary<UserKey, string>
            {
                {UserKey.FirstName,"Stan" },
                {UserKey.LastName,"Marsh" },
                {UserKey.Address,"Somewhere at colorado" },
            });
            usersList.Add(new Dictionary<UserKey, string>
            {
                {UserKey.FirstName,"Token" },
                {UserKey.LastName,"Black" },
                {UserKey.Address,"Somewhere at colorado" },
            });
            usersList.Add(new Dictionary<UserKey, string>
            {
                {UserKey.FirstName,"Mr" },
                {UserKey.LastName,"Slave" },
                {UserKey.Address,"highly classified" },
            });

            return usersList;
        }

        enum UserKey { FirstName, LastName, Address }
    }
}
