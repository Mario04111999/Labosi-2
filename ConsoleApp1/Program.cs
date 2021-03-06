﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak 1
            /*DiceRoller diceRoller = new DiceRoller();
            int numberOfDices = 20;
            int numberOfSides = 6;
            for (int i = 0; i < numberOfDices; i++)
            {
                Die die = new Die(numberOfSides);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> results = diceRoller.GetRollingResults();
            diceRoller.PrintResult(results);*/


            //Zadatak 2
            /*DiceRoller diceRoller = new DiceRoller();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6, random);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> results = diceRoller.GetRollingResults();
            diceRoller.PrintResult(results);
            */

            //Zadatak 3
            DiceRoller diceRoller = new DiceRoller();
            RandomGenerator randomGenerator = RandomGenerator.GetInstance();
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6, randomGenerator);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> results = diceRoller.GetRollingResults();
            diceRoller.PrintResult(results);








        }
    }
}
