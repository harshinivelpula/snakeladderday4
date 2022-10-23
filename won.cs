using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladderd4
{
    internal class won
    {
        public int PlayGame(int playerPosition, int turn)
        {
            int checkwin;  
            int position; 
            while (playerPosition != WIN_POSITION) 
            {
                checkwin = CheckWin(playerPosition);
                if (checkwin == 1 && turn == 1) 
                {
                    Console.WriteLine("player One wins");
                    break; 
                }
                if (checkwin == 1 && turn == 0) 
                {
                    Console.WriteLine("player Two wins");
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
                    playerPosition += position; 
                }

                
                if (playerPosition == 0 && position < 0)  
                {
                    Console.WriteLine("its a snake bite @ 0");
                    playerPosition = 0; 
                }
                if (playerPosition > 0 && position < 0)
                {
                    Console.WriteLine("its a snake bite");
                    playerPosition += position; 
                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }
                }

                if (position > 0)
                {
                    Console.WriteLine("its a ladder"); 
                    playerPosition += position;
                }
                if (playerPosition > WIN_POSITION)
                {
                    playerPosition -= position; 
                }
                if (turn == 1) 
                {
                    Console.WriteLine("Player One rolls die and gets position {playerPosition}");
                    break;
                }
                if (turn == 0) 
                {
                    Console.WriteLine("Player Two rolls die and get position {playerPosition}");
                    break;
                }
            }
            return playerPosition; 
        }

        
        const int WIN_POSITION = 100; 
        const int START_POSITION = 0; 

        public void Start()
        {
            
            int player; 
            int playerOne = START_POSITION, playerTwo = START_POSITION;    
            Console.WriteLine("player One position is {playerOne}"); 
            Console.WriteLine("player Two position is {playerTwo}"); 
            int turn = 1; 
            while (true) 
            {
                if (turn == 1) 
                {
                    Console.WriteLine(" PLAYER ONE TURN");
                    player = PlayGame(playerOne, turn);  
                    turn = 0; 
                    if (player > playerOne) 
                    {
                        turn = 1;
                    }
                    playerOne = player; 
                }
                if (playerOne == WIN_POSITION) 
                {
                    Console.WriteLine("PLAYER ONE WINS");
                    break; 
                }
                if (turn == 0)
                {
                    
                    Console.WriteLine(" PLAYER TWO TURN");
                    player = PlayGame(playerTwo, turn);
                    turn = 1; 
                    if (player > playerTwo) 
                    {
                        turn = 0;
                    }
                    playerTwo = player; 
                }
                if (playerTwo == WIN_POSITION) 
                {
                    Console.WriteLine("PLAYER TWO WINS");
                    break; 
                }
            }
        }

        public int CheckWin(int playerOne)
        {
            if (playerOne == WIN_POSITION) 
                return 1;
            if (playerOne > WIN_POSITION) 
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
