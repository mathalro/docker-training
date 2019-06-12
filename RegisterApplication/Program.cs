using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace RegisterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {   
            ServicePointManager
            .ServerCertificateValidationCallback += 
            (sender, cert, chain, sslPolicyErrors) => true;
            if (args.Length == 2) 
            {
                HttpClient client = new HttpClient();

                var person = new Dictionary<string, string> 
                {
                    { args[0], args[1] }
                };

                var content = new FormUrlEncodedContent(person);
                var response = await client.PostAsync(" http://localhost:5000/api/register", content);
            }
            else 
            {
                Console.WriteLine("The programs wait for <FirstName> <LastName> params!");
            }

        }
    }
}
