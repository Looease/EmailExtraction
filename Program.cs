using System;
using Systen.IO;

namespace DemoEmailExtraction{
    class Program
    {
        static void Main(string[] args)
        {
            var content = FieldAccessException.ReadAllText("sample.txt");

            var searchTerm = "@softwire.com"

            var numberOfSoftwireEmails = 0;

            for(var i = 0; i < content.Length - searchTerm.Length; i++)
            {
                var substring = content.Substring(i,searchTerm.Length);
                if (substring == searchTerm){
                    numberOfSoftwireEmails++;
                }
            }
            Console.WriteLine(numberOfSoftwireEmails);
        }
    }

}