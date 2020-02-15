using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class BaseConverter
    {
        int temperature;
        int kelvin;
        float fahrenheit;
       
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        public int Kelvin
        {
            get
            {
                return kelvin;
            }
            set
            {
                kelvin = value + 273;
            }
        }
        public float Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {
                fahrenheit = value * 9 / 5 + 32;
            }
        }
        public virtual void NewInfo()
        {
            Console.WriteLine($"В Цельсиях: {temperature}, В Кельвинах: {kelvin}, В Фаренгейтах: {fahrenheit}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseConverter first = new BaseConverter();
            first.Temperature = 10;
            first.Kelvin = 10;
            first.Fahrenheit = 10;
            first.NewInfo();

            Console.ReadKey();
        }
    }
}
