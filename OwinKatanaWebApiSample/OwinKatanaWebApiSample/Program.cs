using System;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using System.Net.Http;

namespace OwinKatanaWebApiSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var address = "http://localhost:5000/";
            using(WebApp.Start<StartUp>(address))
            {
                Console.Write("server start at: " + address);
                Console.ReadKey();
                Console.Write("server stop");
            }
        }
    }
}
