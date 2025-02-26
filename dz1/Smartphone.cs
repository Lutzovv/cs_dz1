using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Smartphone
    {
        private string model;
        private double frequency;
        private int amountOfRAM;
        private int memoryCapacity;
        private string oc;

        public Smartphone(string model,
            double frequency,
            int amountOfRAM,
            int memoryCapacity,
            string oc)
        {
            this.model = model;
            this.frequency = frequency;
            this.amountOfRAM = amountOfRAM;
            this.memoryCapacity = memoryCapacity;
            this.oc = oc;
        }

        public void Info()
        {
            Console.WriteLine($"Модель: {model}\n" +
                $"Тактовая частота процессора: {frequency}\n" +
                $"Объём ОЗУ: {amountOfRAM}\n" +
                $"Объём памяти: {memoryCapacity}\n" +
                $"Операционная система: {oc}");
        }
    }
}
