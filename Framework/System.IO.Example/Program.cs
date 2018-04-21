using System;
using System.IO;
using System.Text;

namespace System.IO.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("My name is carlos , i have one dog j");
            File.AppendAllText(@"C:\Users\POSITIVO\Desktop\1.txt", stringBuilder.ToString());

            //string[] line = { "line 1", "line 2 ", "line 3" };
            // File.AppendAllLines(@"C:\Users\POSITIVO\Desktop\2.txt", line);

            //Encrypt File 
            // File.Encrypt(@"C:\Users\POSITIVO\Desktop\2.txt");


            File.Decrypt(@"C:\Users\POSITIVO\Desktop\2.txt");

        }
    }
}
