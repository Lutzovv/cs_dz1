using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Computer
    {
        private string model;
        private double frequency;
        private int amountOfRAM;
        private int hardDriveCapacity;

        public Computer(string model, 
            double frequency, 
            int amountOfRAM, 
            int hardDriveCapacity)
        {
            this.model = model;
            this.frequency = frequency;
            this.amountOfRAM = amountOfRAM;
            this.hardDriveCapacity = hardDriveCapacity;
        }

        public void Info()
        {
            Console.WriteLine($"Модель: {model}\n" +
                $"Тактовая частота процессора: {frequency}\n" +
                $"Объём ОЗУ: {amountOfRAM}\n" +
                $"Объём жёсткого диска: {hardDriveCapacity}");
        }
    }
}
