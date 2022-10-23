using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladderd4
{
    internal class report
    {
        public void Start()
        {
            int position;
            int playerOne = 3;   
            int checkwin;
            Console.WriteLine("player One position is {playerOne}");
            while (playerOne <= 100) 
            {
                checkwin = CheckWin(playerOne);
                if (checkwin == 1) 
                {
                    Console.WriteLine("playerOne wins!!");
                    break; 
                }
                if (checkwin == 2) 
                {
                    position = 0;
                }
                else 
                {
                    position = RollDie();
                }
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
                if (playerOne > 100)
                {
                    playerOne -= position; 
                }
                Console.WriteLine("player One rolls die and get position {playerOne}");
            }
        }

        public int CheckWin(int playerOne)
        {
            if (playerOne == 100) 
                return 1;
            if (playerOne > 100) 
                return 2;
            else 
                return 0;
        }
        readonly Random random = new Random();
        int diceThrown = 0;
        public int RollDie()
        {
            int dice, check;
            dice = random.Next(1, 7);
            diceThrown++; 
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
            
            Console.WriteLine("Number of Times Dice Thrown: {diceThrown}");
        }

    }
}
