using Bogus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LiteDB;

namespace Demo.Framework4.Core
{
    public class PersonService
    {
        private readonly string _connectionString;
        private readonly string _dbFilePath;

        public PersonService()
        {
            _dbFilePath = "";
            string apppath = Directory.GetCurrentDirectory();
            _dbFilePath = Path.Combine(apppath,"MyContacts.db");
        }


        private void InitDb()
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {

            }
        }


        public List<Person> GenerateListOfPersons()
        {
            var personFaker = new Faker<Person>("fr_CA")
                .RuleFor(p=>p.Id, f=>f.UniqueIndex)
            .RuleFor(p => p.FirstName, f => f.Name.FirstName()) // Generate a random first name
            .RuleFor(p => p.LastName, f => f.Name.LastName())   // Generate a random last name
            .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.FirstName, p.LastName, "mousquetaires.com"));

            List<Person> persons = personFaker.Generate(50);

            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Email: {person.Email}");
            }

            return persons;
        }

    }
}
