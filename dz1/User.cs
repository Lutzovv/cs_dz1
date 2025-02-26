using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class User
    {
        private string name;
        private string surname;
        private string patronymic;

        public User(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{name} {surname} {patronymic}");
        }
    }
}
