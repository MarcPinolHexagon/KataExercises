# KataPaginationHelper

KATA FROM https://www.codewars.com/kata/515bb423de843ea99400000a/train/csharp

For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.

The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.

The following are some examples of how this class is used:
```
var helper = new PaginationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);
helper.PageCount(); //should == 2
helper.ItemCount(); //should == 6
helper.PageItemCount(0); //should == 4
helper.PageItemCount(1); // last page - should == 2
helper.PageItemCount(2); // should == -1 since the page is invalid

// pageIndex takes an item index and returns the page that it belongs on
helper.PageIndex(5); //should == 1 (zero based index)
helper.PageIndex(2); //should == 0
helper.PageIndex(20); //should == -1
helper.PageIndex(-10); //should == -1
```

# KataRomanNumeralsHelper

KATA FROM https://www.codewars.com/kata/51b66044bce5799a7f000003/train/csharp

Write two functions that convert a roman numeral to and from an integer value. Multiple roman numeral values will be tested for each function.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals:

1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC
2008 is written as 2000=MM, 8=VIII; or MMVIII
1666 uses each Roman symbol in descending order: MDCLXVI.
Input range : 1 <= n < 4000

In this kata 4 should be represented as IV, NOT as IIII (the "watchmaker's four").

## Examples
```
to roman:
2000 -> "MM"
1666 -> "MDCLXVI"
  86 -> "LXXXVI"
   1 -> "I"

from roman:
"MM"      -> 2000
"MDCLXVI" -> 1666
"LXXXVI"  ->   86
"I"       ->    1
```

## Help
```
+--------+-------+
| Symbol | Value |
+--------+-------+
|    M   |  1000 |
|   CM   |   900 |
|    D   |   500 |
|   CD   |   400 |
|    C   |   100 |
|   XC   |    90 |
|    L   |    50 |
|   XL   |    40 |
|    X   |    10 |
|   IX   |     9 |
|    V   |     5 |
|   IV   |     4 |
|    I   |     1 |
+--------+-------+
```
#KataEventAndDelegate

KATA FROM https://www.codewars.com/kata/5790bd38671cb57f7900012f

Please don't cheat, you need to know about event and delegate concept while developing an application in real world.

Concept of event and delegate is confusing sometimes, so this kata is going to target it.

Events and delegates help us to follow SOLID principle and develop loosely coupled application.

It provide us with a communication method (contract with specific signature) between objects which need to be decoupled.

Basically it provides notifier in one objects so that other objects can subscribe to that.

----

Suppose you have a list of strings containing names. It shows the order of people who has received some messages, and we want to notify them in every three message.

So, we start counting, and every time we count "Peter" for 3rd, 6th, 9th or n*3th times we send him a text message and Email. this is the logic how we chose a name to send a notification.

in this list:
```
List<string> peopleList = new List<string>()
            {
                "Peter", "Mike", "Peter", "Bob", "Peter", "Peter", "Bob", "Mike", "Bob", "Peter", "Peter", "Mike", "Bob"
            };
```
First we inform "Peter", then "Bob", then "Peter", then "Mike".

Here is a class that can do it:
```
public class NotPublisher
    {
        public void CountMessages(List<string> peopleList)
        {
            foreach (string person in peopleList)
            {
                /*if (some logic to count the person for 3, 6, 9, 12 ... times)
                {
                  SendTextMessage(person);
                  SendEmail(Person)
                }*/
            }
        }
    }
```
The objects and components are tightly coupled here. We notify the user by sending a test message or Email. Then what if we want to add another method to inform users by sending a VoiP message?

We need to create another function here, and it means our application is not easy to extend. We need to recompile and republish the class again.
----
Your task is to implement the class as a publisher, so text message or Email or VoiP objects can subscribe to it. So, you need to define a delegate, and then define an event based on the delegate.

PersonEventArgs class (based on EventArgs) with Name property(string) is needed to send Name of the person to the subscriber.

ContactNotify is the event handler that you need to implement in the class. Subscriber classes subscribe to this event handler.

You do not need to worry about the subscribers; they generate different types of objects for test cases.

Here is an example code of a subscriber, however you know ''ContactNotify'' is the event handler and you don't need any information about subscriber:
```
\\call the publisher and subscribe
Publisher publisher = new Publisher();
publisher.ContactNotify += TextMessageSend.Send;
publisher.CountMessages(peopleList);

\\send text message
public class TextMessageSend
{
    public static void Send(object source, PersonEventArgs e)
    {
        \\function to send text message
    }
}
```
Enjoy :)