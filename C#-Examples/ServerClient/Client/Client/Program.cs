using System;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //connnet to the server
            Client.Connect();
            
            while(true) {
                var read = Console.ReadLine();
                //write the bytes to the server
                Client.Write(Encoding.ASCII.GetBytes(read));
                //read the reponse from the server
                Console.WriteLine(Encoding.ASCII.GetString(Client.Read()));
            }
        }
    }
}
