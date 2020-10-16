using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov
{
    class DayofBrithday
    {
        public string _name;
        private int _age;
        public int _personalBonus = 0;
    }
    public static void Bonus()
    {
        Console.WriteLine("Do you want register on our shop");
        Console.WriteLine("Enter your name");
        DayofBrithday people = new DayofBrithday();
        people._name = Console.ReadLine();
        Console.WriteLine("Ener your age");
        people
    }
}
