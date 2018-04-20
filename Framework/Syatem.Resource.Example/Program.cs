using System;
using System.Resources;
namespace Syatem.Resource.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Resources.ResourceManager resourceManager = new ResourceManager(typeof(Syatem.Resource.Example.Main));
            string d = resourceManager.GetString("LION");
            Console.WriteLine(d);
            Console.ReadKey();



        }
    }
}
