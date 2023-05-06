using System;
using System.Text;

namespace StringBuilderC_
{
    // string is an immutable object -> if new one is created it's saved on the heap
    // if the string we've created changes, a new object is created in a different memory location -> can hurt performance
    // string builder solves this problem -> changes the actual string on the same memory location
    internal class Program
    {
        static void Main(string[] args)
        {
            string regularString = "this is a regular string";
            regularString = "meaning that if it's changed, it creates a new string object";
            regularString = "this new string object will be saved in a different memory location";
            regularString = "all these strings refers to different memory locations";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("This is a string builder");
            stringBuilder.Append("it does not create a new string object every time we change the string");
            stringBuilder.Append("instead, it changes the same string object in the same memory location");
            stringBuilder.Append("all this refers to the same memory location");

            // if we have to change a string many times, be sure to use a StringBuilder
        }
    }
}
