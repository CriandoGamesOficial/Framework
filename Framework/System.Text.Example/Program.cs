using System;
using System.Text;

namespace System.Text.Example
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StringBuilder _stringBuilder = new StringBuilder();

            _stringBuilder.Append("Carlos ");
            _stringBuilder.Append("Castro");


            //Insert After six words
            _stringBuilder.Insert(6, " Alberto ");

            //Remove After six Words, eight Words
            _stringBuilder.Remove(6, 8);

            //Replace 
            _stringBuilder.Replace(" ", "-");

            Console.WriteLine(_stringBuilder);
            Console.ReadKey();
        }
    }
}
