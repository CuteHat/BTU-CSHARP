using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_One
{
    static class Post
    {
        public static void SendMessage(User user,Message message)
        {
            user.GetMessage(message);
        }
    }
}
