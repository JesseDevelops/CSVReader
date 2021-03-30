using System;
using System.Collections.Generic;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Store all contents from csv file into string array
            string[] rawCSVData = System.IO.File.ReadAllLines(@"C:\Users\Jesse\Desktop\username.csv");

            var userName = new List<string>();
            var Id = new List<int>();
            var firstName = new List<string>();
            var lastName = new List<string>();

            //split each row into column data
            for (int i = 1; i < rawCSVData.Length; i++)
            {
                string[] rowData = rawCSVData[i].Split(',');
                
                userName.Add(rowData[0]);
                int identifier = Convert.ToInt32(rowData[1]);
                Id.Add(identifier);
                firstName.Add(rowData[2]);
                lastName.Add(rowData[3]);

            }
           
            //output through another loop using a list of usernames, can do it through anything really.
            for (int j = 0; j < userName.Count; j++)
            {

                Console.WriteLine("User number: " + j);
                Console.WriteLine("Username: " + userName[j]);
                Console.WriteLine("Id: " + Id[j]);
                Console.WriteLine("First Name: " + firstName[j]);
                Console.WriteLine("Last Name: " + lastName[j]);
                Console.WriteLine(" ");
            }

        }
    }
}
