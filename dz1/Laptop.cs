using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Laptop
    {
        private string model;
        private double frequency;
        private int amountOfRAM;
        private int hardDriveCapacity;
        private double weight;

        public Laptop(string model,
            double frequency,
            int amountOfRAM,
            int hardDriveCapacity,
            double weight)
        {
            this.model = model;
            this.frequency = frequency;
            this.amountOfRAM = amountOfRAM;
            this.hardDriveCapacity = hardDriveCapacity;
            this.weight = weight;
        }

        public void Info()
        {
            Console.WriteLine($"Модель: {model}\n" +
                $"Тактовая частота процессора: {frequency}\n" +
                $"Объём ОЗУ: {amountOfRAM}\n" +
                $"Объём жёсткого диска: {hardDriveCapacity}\n" +
                $"Масса: {weight}");
        }
    }
}
