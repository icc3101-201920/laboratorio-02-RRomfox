﻿using System;
using Laboratorio_1_OOP_201902.Card;

namespace Laboratorio_1_OOP_201902
{
    class Program
    {
        static void Main(string[] args)
        {
            CombatCard A = new CombatCard("Chuen", "Warrior", "Carries", 100, true);

            Console.WriteLine(A.Name);
        }
    }
}
