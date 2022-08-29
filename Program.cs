// See https://aka.ms/new-console-template for more information
using System ;

namespace Rolldice
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerRandom ;          
            int enemyRandom;
            Random random = new Random();
            // Counting the numbers on win for each participant 
            int PlayerWinCounter = 0;
            int enemyWinCounter = 0;
            int countDiceROll=0;

            Console.WriteLine(" ");
            Console.WriteLine("*** Welcome to the Dice Game. You will have 10 rounds to play ***");
            Console.WriteLine("***         Today 'EnemyAI' is playing against you              ***");
                        

            for (int i =0; i <10; i++){
                Console.WriteLine("***           Press Enter to roll the dice                    ***  ");
                Console.ReadKey();
                countDiceROll++;
        
                PlayerRandom= random.Next(1,7);
                Console.WriteLine("You have rolled a " + PlayerRandom);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);                

                enemyRandom = random.Next(1,7); 
                Console.WriteLine("EnemyAI have rolled a " + enemyRandom);
                
                if (PlayerRandom > enemyRandom){
                Console.WriteLine("Yey!You have won this round!");
                PlayerWinCounter++;
                }
                else if (enemyRandom > PlayerRandom){
                Console.WriteLine("Ops! EnemyAI has won this round!");
                enemyWinCounter++;
                }                    
                else {
                Console.WriteLine("Its a Draw!");
                }   
                Console.WriteLine("The total Score -> Player:"+ PlayerWinCounter+":EnemyAI:"+ enemyWinCounter);         
                Console.WriteLine("");
            }
           
            if (PlayerWinCounter > enemyWinCounter) {   
                Console.WriteLine ("Congratulations! You are the winner with " + PlayerWinCounter +
                "rounds of win");
            }
            else if (enemyWinCounter > PlayerWinCounter){
                int lostDifference = enemyWinCounter- PlayerWinCounter;
                Console.WriteLine("You have lost this game with "+ lostDifference+
                ". Better luck next time");
            }
            else{
                Console.WriteLine("Its a Draw");
            }
        }

    }
}
