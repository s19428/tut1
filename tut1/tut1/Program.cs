using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tut1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            int? i = null;
            Console.WriteLine("Hello World!");

            Person p = new Person();
            p.Print();

            var url = @"https://www.pja.edu.pl/en/";
            var httpClient = new HttpClient();
            using (var response = await httpClient.GetAsync(url))
            {
                var content = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z]+\\.[a-z]+", RegexOptions.IgnoreCase);
                var matches = regex.Matches(content);
                foreach (var match in matches)
                {
                    Console.WriteLine(match + "");
                }
            }
            //response.Dispose();
        }
    }
}