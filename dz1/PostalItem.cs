using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class PostalItem
    {
        private int index;
        private string city;
        private string street;
        private int house;
        private string building;
        private int apartment;
        private string mail;

        public PostalItem(int index, 
            string city, 
            string street, 
            int house, 
            string building, 
            int apartment, 
            string mail)
        {
            this.index = index;
            this.city = city;
            this.street = street;
            this.house = house;
            this.building = building;
            this.apartment = apartment;

            this.mail = mail;
        }

        public void PrintAdress()
        {
            Console.WriteLine($"Почтовый индекс: {index}\n" +
                $"Город: {city}\n" +
                $"Улица: {street}\n" +
                $"Дом: {house}\n" +
                $"Корпус: {building}\n" +
                $"Квартира: {apartment}");
        }
    }
}
