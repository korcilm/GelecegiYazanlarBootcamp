using System;

namespace StringMethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello world! I am here";

            var result = sentence.Length;
            var result2 = sentence.ToUpper();
            var result3 = sentence.ToLower();
            var contains = sentence.Contains("world");
            Console.WriteLine(contains);
            var startsWith = sentence.StartsWith("Hel");
            Console.WriteLine(startsWith);
            var indexOf = sentence.IndexOf("world");
            Console.WriteLine(indexOf);
            var lastIndexOf = sentence.LastIndexOf("I");
            Console.WriteLine(lastIndexOf);
            var insert = sentence.Insert(5, " (hi)");
            Console.WriteLine(insert);
            var replace = sentence.Replace("!", ",");
            Console.WriteLine(replace);
            var substring = sentence.Substring(6, 9);
            Console.WriteLine(substring);


        }
    }
}
