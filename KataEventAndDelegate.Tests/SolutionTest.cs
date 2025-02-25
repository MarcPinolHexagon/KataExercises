using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KataEventAndDelegate.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTest()
        {
            List<string> peopleList = new List<string>()
            {
                "Peter", "Mike", "Peter", "Bob", "Peter", "Peter", "Bob", "Mike", "Bob", "Peter", "Peter", "Mike", "Bob"
            };
            TextMessageSend.TextMessageList = "";
            Publisher publisher = new Publisher();
            publisher.ContactNotify += TextMessageSend.Send;
            publisher.CountMessages(peopleList);
            string output = TextMessageSend.TextMessageList;
            string expected = "Peter, Bob, Peter, Mike";
            Assert.That(output, Is.EqualTo(expected).IgnoreCase);
        }
    }

    public class TextMessageSend
    {
        public static string TextMessageList { get; set; } = string.Empty;

        public static void Send(object source, PersonEventArgs e)
        {
            TextMessageList.Append<>($", {e.Name}");
        }
    }
}