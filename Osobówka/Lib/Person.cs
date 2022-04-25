using System;

namespace Osobówka.Lib
{
    public class Person
    {
        private readonly string _name;
        private readonly string _lastName;
        private readonly DateTime _birthDate;

        public Person(string name, string lastName, DateTime birthDate)
        {
            _name = name;
            _lastName = lastName;
            _birthDate = birthDate;
        }
    }
}