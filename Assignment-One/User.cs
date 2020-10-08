using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_One
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public User(string firstName, string lastName, string address)
        {
            Id = IdSequence.Next;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public void GetMessage(Message message)
        {
            Console.WriteLine($"Title: {message.Title}, Content: {message.Content}");
        }

    }
}
