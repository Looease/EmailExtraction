using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DemoEmailExtraction{
    class Program
    {
        static void Main(string[] args)
        {
            var content = File.ReadAllText("sample.txt");
            var regex = new Regex(@"@softwire\.com");

            var results = regex.Matches(content);
            Console.WriteLine(results.Count);
        }       
    }

}

 // The below example is correct but long winded and not using Regex
        // {
        //     var content = File.ReadAllText("sample.txt");

        //     var searchTerm = "@softwire.com";

        //     var numberOfSoftwireEmails = 0;

        //     for(var i = 0; i < content.Length - searchTerm.Length; i++)
        //     {
        //         var substring = content.Substring(i,searchTerm.Length);
        //         if (substring == searchTerm){
        //             numberOfSoftwireEmails++;
        //         }
        //     }
        //     Console.WriteLine(numberOfSoftwireEmails);
        // }