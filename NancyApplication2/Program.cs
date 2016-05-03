namespace NancyApplication2
{
    using System;
    using Nancy.Hosting.Self;
    using Microsoft.Owin.Hosting;
    class Program
    {
        static void Main(string[] args)
        {
            var uri =
                new Uri("http://localhost:3579");

          
            using (WebApp.Start<Startup>(uri.ToString()))
            {
                Console.WriteLine("Your application is running on " + uri);
                Console.WriteLine("Press any [Enter] to close the host.");
                Console.ReadLine();
            }

        }
    }
}
