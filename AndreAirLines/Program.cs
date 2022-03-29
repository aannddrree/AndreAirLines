using Data;
using File;
using Model;
using System;
using System.Collections.Generic;

namespace AndreAirLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Passenger> lst = ReadFileJson.getData(@"C:\Users\André\source\repos\AndreAirLines\File\file\dados.json");
            
            foreach (Passenger p in lst)
            {
                new PassegerDB().InsertPassenger(p);
            }

            Console.WriteLine("Dados Carregados!");
        }
    }
}



/*Passenger p = new Passenger()
{
    Cpf = "12312312398",
    DateBirth = new DateTime(2000, 12, 01),
    Email = "teste@teste.com",
    Name = "Teste Passenger",
    Telephone = "16 9 88883333",
    Address = new Address()
    {
        Number = 10,
        CEP = "1231234",
        Cidy = "Araraquara",
        Complement = "A",
        Country = "Brasil",
        State = "SP",
        Street = "rua ",
        District = "Centro"
    }
};

new PassegerDB().InsertPassenger(p);*/
