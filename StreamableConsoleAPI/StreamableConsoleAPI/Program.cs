using RestSharp;
using Streamable.dotNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamableConsoleAPI
{
    class Program
    {
        static void Main(string[] args)
        {


            string userName = "";
            string password = "";
            string filePath = "";
                //New instance of StreamableAPI.
            var streamableClient = new StreamableAPI();
                //New instance of RestSharp's RestClient calling Streamables API.
            var client = new RestClient("https://api.streamable.com/upload");


            Console.WriteLine("Please Enter Your Username Or Email. \n");
                //Fills userName string for login Auth.
            userName = Console.ReadLine();


            Console.Clear();


            Console.WriteLine("Please Enter Your Password. \n");
                //Fills password string for login Auth.
            password = Console.ReadLine();


            Console.Clear();


            Console.WriteLine("Copy And Paste The Complete File Path: \n");
            //FilePath for uploading.
            filePath = Console.ReadLine();


            Console.Clear();


            Console.WriteLine("Uploading... \n");
            //API Upload Call.
            streamableClient.Upload(filePath, userName, password);
            Console.WriteLine("--Upload Complete-- \n");

            Console.WriteLine("Press Any Key To Exit.");
            Console.ReadKey();
        }
    }
}
