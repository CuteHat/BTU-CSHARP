using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_One
{
    class Message
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Message(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
