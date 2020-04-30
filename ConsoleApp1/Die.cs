using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //1.
    class Die
    {     //Zadatak 1
        /* private int numberOfSides;
         private Random randomGenerator;
         private int rolledNumber;
         public Die(int numberOfSides)
         {
             this.numberOfSides = numberOfSides;
             this.randomGenerator = new Random();
         }
         public int Roll()
         {
             rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
             return rolledNumber;
         }*/

        //Zadatak 2
        /*private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }*/


        //Zadatak 3
       private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides, RandomGenerator randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }





    }


}

