using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Remoting;
using System.Text;

namespace RestoCore
{
    public class Client
    {
        public int Client_Number { get; set; }
        public int Client_TableNumber { get; set; }
        public DateTime Client_Date_And_Hour_Of_Reservation { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        

        public static void CreateClients(int number, List<Client> clients)
        {
            if (number != 0)
            {
                for(int i = 0; i <= number; i++)
                {
                    clients.Add(new Client());
                }
                NumerateClients(clients); 
            }
        }

        public static void RemoveClients(int number, List<Client> clients)
        {
            for(int i = clients.Count; i >= number; i--)
            {
                clients.RemoveAt(i-1); 
            }
        }

        public static void NumerateClients(List<Client> clients)
        {
            int i = 0; 
            foreach(var client in clients)
            {
                client.Client_Number = i;
                i++; 
            }
        }
    }
}
