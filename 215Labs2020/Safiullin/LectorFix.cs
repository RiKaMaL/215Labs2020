﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class LectorFix
    {
         {
        private string name;
        private int mark1;
        private int mark2;
        private int mark3;
        public int Mark1
        {
            get { return mark1; }
            set
            {
                if (value < 2) { mark1 = 2; }
                else if (value > 5) { mark1 = 5; }
                else { mark1 = value; }
            }
        }

        public int Mark2
        {
            get { return mark2; }
            set
            {
                if (value < 2) { mark2 = 2; }
                else if (value > 5) { mark2 = 5; }
                else { mark2 = value; }
            }
        }
        public int Mark3
        {
            get { return mark3; }
            set
            {
                if (value < 2) { mark3 = 2; }
                else if (value > 5) { mark3 = 5; }
                else { mark3 = value; }

            }
        }
        public static void SyudentRegister()
        {
            LectorFix[] mass = new LectorFix[5];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new LectorFix();
                Console.Write("Введите Фамилию Имя ученика: ");
                mass[i].name = Console.ReadLine();
                Console.Write("Введите оценку по математике: ");
                mass[i].Mark1 = int.Parse(Console.ReadLine());
                Console.Write("Введите оценку по русскому языку: ");
                mass[i].Mark2 = int.Parse(Console.ReadLine());
                Console.Write("Введите оценку по английскому: ");
                mass[i].Mark3 = int.Parse(Console.ReadLine());
                Console.WriteLine("____________________________________");
                Console.WriteLine($"{mass[i].name.ToUpper()}    {mass[0].Mark1}    {mass[1].Mark2}    {mass[2].Mark3}");
                Console.WriteLine("____________________________________");

            }
        }
    }
}
