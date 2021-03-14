using System;

namespace practice_10
{
    class Program
    {
        internal class Motorcycle
        {
            public readonly Guid Identificator = Guid.NewGuid();
            public string Model;
            public string Manufacturer;
            public int Mileage;
            public int ProdYear;
            public Engine engine;
            public class Engine
            {
                public int Volume;
                public int HorsePower;
            }
            public void Reset()
            {
                Model = String.Empty;
                Manufacturer = String.Empty;
                Mileage = 0;
                ProdYear = 0;
                engine.Volume = 0;
                engine.HorsePower = 0;
            }
        }
        static void Main(string[] args)
        {
            Motorcycle[] Moto = new Motorcycle[3];
            string date1;
            for (int i = 0; i < Moto.Length; i++)
            {
                Moto[i] = new Motorcycle();
                Console.WriteLine("Введите модель");
                string model = Console.ReadLine();
                if (!String.IsNullOrEmpty(model))
                    Moto[i].Model = model;
                else
                    Console.WriteLine("Неверное имя модели");
                Console.WriteLine("Введите наименование изготовителя");
                string manufacturer = Console.ReadLine();
                if (!String.IsNullOrEmpty(manufacturer) && manufacturer.Length > 1)
                    Moto[i].Manufacturer = manufacturer;
                else
                    Console.WriteLine("Неверное имя изготовителя");
                Console.WriteLine("Введите пробег");
                int mileage = Convert.ToInt32(Console.ReadLine());
                if (mileage >= 0 && mileage <= 100)
                    Moto[i].Mileage = mileage;
                else
                    Console.WriteLine("Пробег должен быть в пределах 0-100");
                Console.WriteLine("Введите объем двигателя");
                Moto[i].engine = new Motorcycle.Engine();
                int volume = Convert.ToInt32(Console.ReadLine());
                if (volume >= 125 && volume <= 3200)
                    Moto[i].engine.Volume = volume;
                else
                    Console.WriteLine("Объем должен быть в пределах 125-3200");
                Console.WriteLine("Введите мощность двигателя");
                int horsePower = Convert.ToInt32(Console.ReadLine());
                if (horsePower >= 50 && horsePower <= 300)
                    Moto[i].engine.HorsePower = horsePower;
                else
                    Console.WriteLine("Мощность должена быть в пределах 50-300");
                date1 = DateTime.Now.Year.ToString();
                Moto[i].ProdYear = int.Parse(date1);
            }
            for (int i = 0; i < Moto.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Мотоцикл(Производитель): {Moto[i].Manufacturer}, Модель: {Moto[i].Model}, Идентификатор: {Moto[i].Identificator}, Год: {Moto[i].ProdYear}");
                Console.WriteLine($"{i + 1}.1 Двигатель(Объем): {Moto[i].engine.Volume}, Мощность: {Moto[i].engine.HorsePower}");
                Moto[i].Reset();
            }
            Console.ReadLine();
        }
    }
}

