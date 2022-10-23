using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladderd4
{
    internal class repeat
    {
        public void Start()
        {
            int position;
            int playerOne = 3;    
            Console.WriteLine("player One position is {playerOne}");
            while (playerOne <= 100) 
            {
                position = RollDie();
                if (position == 0)
                {
                    Console.WriteLine("its a no play");
                    playerOne += position;
                }

                if (playerOne == 0 && position < 0)   
                {
                    Console.WriteLine("its a snake bite @ 0");
                    playerOne = 0; 
                }
                if (playerOne > 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite");
                    playerOne += position; 
                    if (playerOne < 0)
                    {
                        playerOne = 0;
                    }
                }

                if (position > 0)
                {
                    Console.WriteLine("its a ladder");
                    playerOne += position;
                }
                Console.WriteLine("player One rolls die and get position {playerOne}");
            }
        }
        readonly Random random = new Random();
        public int RollDie()
        {
            int dice, check;
            dice = random.Next(1, 7);
            Console.WriteLine("Dice = {dice}");
            check = CheckPlay();
            if (check == 1)
                return -dice; 
            if (check == 2)
                return dice; 
            else
                return 0; 
        }
        public int CheckPlay()
        {
            int check = random.Next(1, 4);
            return check;
        }
        public void Board()
        {
            Start();
        }

    }
}
