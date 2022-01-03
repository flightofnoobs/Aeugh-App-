using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeugh_App
{
    class Program
    {
        private static int m_player1Score = 0;
        private static int m_player2Score = 0;
        private const int MAX_SCORE = 5;
        static void Main()
        {
            m_player1Score = 0;

            m_player2Score = 0;

            Console.Clear();

            Console.WriteLine("Rock Paper Scissors Game");

            Console.WriteLine();

            Console.WriteLine("a) Play");

            Console.WriteLine("b) Instructions");

            Console.WriteLine("c) Exit");

            char selection;

            selection = Console.ReadKey(true).KeyChar;

            if (selection == 'a')
            {
                Game();
            }
            else if (selection == 'b')
            {
                Instructions();
            }
            else if (selection == 'c')
            {

            }
            else
            {
                Main();
            }
        }
        static void Instructions()
        {
            Console.Clear();

            Console.WriteLine("Choose Between Rock, Paper Or Scissors");

            Console.WriteLine("The Controls For Player 1 Are");

            Console.WriteLine();

            Console.WriteLine("A = Rock S = Paper D = Scissors");

            Console.WriteLine("And The Controls For Player 2 Are ");

            Console.WriteLine();

            Console.WriteLine("J = Rock K = Paper L = Scissors");

            Console.WriteLine();

            Console.WriteLine("The Score Is up to 5, The Player who gets 5 Score WINS!");

            Console.WriteLine();

            Console.WriteLine("Pro Tip:");

            Console.WriteLine("Try not to Show the Other Players What did You Selected");

            Console.WriteLine("To Avoid Cheating :D");

            Console.WriteLine();

            Console.WriteLine("Press Any Key To Continue :D...");

            Console.ReadKey();

            Main();

        }
        static void Game()
        {
            

            while (true)
            {
                if (m_player1Score == MAX_SCORE || m_player2Score == MAX_SCORE)
                    break;

                Console.Clear();

                Console.WriteLine("Player1 Your Turn");

                char player1Attack = Console.ReadKey(true).KeyChar;

                Console.Clear();

                Console.WriteLine("Player2 Its Your Turn Now");

                char player2Attack = Console.ReadKey(true).KeyChar;

                if (player1Attack == 'a' && player2Attack == 'j')
                {
                    Console.Clear();

                    Console.WriteLine("Its A Tie :V");

                    Console.WriteLine("Press Any Key To Continue");

                    Console.ReadKey();

                    
                }
                else if (player1Attack == 's' && player2Attack == 'k')
                {
                    Console.Clear();

                    Console.WriteLine("Its A Tie :V");

                    Console.WriteLine("Press Any Key To Continue");

                    Console.ReadKey();

                    
                }
                else if (player1Attack == 'd' && player2Attack == 'l')
                {
                    Console.Clear();

                    Console.WriteLine("Its A Tie :V");

                    Console.WriteLine("Press Any Key To Continue");

                    Console.ReadKey();

                    
                }
                else if (player1Attack == 'a' && player2Attack == 'k') //Player 1 = Rock Player 2 = Paper
                {
                    Console.Clear();

                    Console.WriteLine("Player 2 Scored!!!");

                    m_player2Score++;

                    Console.WriteLine("Press Any Key to Continue");

                    Console.ReadKey();

                    
                }
                else if (player1Attack == 'a' && player2Attack == 'l') //Player 1 does Rock And Player 2 does Scissors
                {
                    Console.Clear();

                    Console.WriteLine("Player 1 Scored!!!");

                    m_player1Score++;

                    Console.WriteLine("Press Any Key to Continue");

                    Console.ReadKey();

                    
                }
                else if (player2Attack == 'j' && player1Attack == 's') //Player 2 does Rock and Player 1 Does Paper
                {
                    Console.Clear();

                    Console.WriteLine("Player 1 Scored!!!");

                    m_player1Score++;

                    Console.WriteLine("Press Any Key to Continue");

                    Console.ReadKey();

                    
                }
                else if (player2Attack == 'j' && player1Attack == 'd') //Player 2 does Rock and Player 1 does Scissor
                {
                    Console.Clear();

                    Console.WriteLine("Player 2 Scored!!!");

                    m_player2Score++;

                    Console.WriteLine("Press Any Key to Continue");

                    Console.ReadKey();

                    
                }
                else if (player1Attack == 's' && player2Attack == 'l') //Player 1 does Paper And Player 2 does Scissors
                {
                    Console.Clear();

                    Console.WriteLine("Player 1 Scored!!!");

                    m_player1Score++;

                    Console.WriteLine("Press Any Key to Continue");

                    Console.ReadKey();
                }
                else if (player1Attack == 'd' && player2Attack == 'k') //Player 1 does Scissor Player 2 does Paper
                {
                    Console.Clear();

                    Console.WriteLine("Player 1 Scored!!!");

                    m_player1Score++;

                    Console.WriteLine("Press Any Key to Continue");

                    Console.ReadKey();
                }
                else //If 1 Of The Players Made wrong selection
                {
                    Console.Clear();

                    Console.WriteLine("Invalid Selection");

                    Console.WriteLine();

                    Console.WriteLine("Try Checking If you are In Caps lock or so");

                    Console.WriteLine("Press Any Key to Continue...");

                    Console.ReadKey();

                    
                }
                 
            }
            
            if (m_player1Score == MAX_SCORE)
            {
                Player1Wins();
            }
            else if (m_player2Score == MAX_SCORE)
            {
                Player2Wins();
            }
        }
        static void Player1Wins()
        {
            Console.Clear();

            Console.WriteLine("Congratualations Player 1 You Won!!!");

            Console.WriteLine();

            Console.WriteLine("Go Celebrate :D");

            Console.WriteLine();

            Console.WriteLine("Press Any Key to Go Back to Main Screen");

            Console.ReadKey();

            Main();
       
        }
        static void Player2Wins()
        {
            Console.Clear();

            Console.WriteLine("Congratualations Player 2 You Won!!!");

            Console.WriteLine();

            Console.WriteLine("Go Celebrate :D");

            Console.WriteLine();

            Console.WriteLine("Press Any Key to Go Back to Main Screen");

            Console.ReadKey();

            Main();
        }
    }
}

