using System;

namespace figures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"This is {}. CLR Type is {}. Square is {}.");
        }
    }
}
interface IFigures
{
    void Square()
    {

    }
}
class Circle : IFigures
{
    
    public Circle(int radius)
    {
        radius =Convert.ToInt32(Console.ReadLine());
    }

}
class Kvadrat : IFigures
{ 

}
class Triangle : IFigures
{

}
