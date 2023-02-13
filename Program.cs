namespace SnakeAndLadder
{
    public class Game
    {
        public static void Main(string[] args)
        {
            
            int playerPosition = 0;
            int previousPosition =0;
            Random random = new Random();

            while (playerPosition < 100)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("You rolled a " + diceRoll);

                int option = random.Next(1, 4);
                

                switch (option)
                {
                    case 1: // No Play
                        Console.WriteLine("No Play. You stay in the same position.");
                        break;
                    case 2: // Ladder
                        previousPosition= playerPosition;
                        playerPosition += diceRoll;
                        Console.WriteLine("You climbed a ladder! You moved ahead by " + diceRoll + " positions.");
                        break;
                    case 3: // Snake
                        playerPosition -= diceRoll;
                        Console.WriteLine("You encountered a snake! You moved back by " + diceRoll + " positions.");
                        break;
                }

                if (playerPosition < 0)
                {
                    Console.WriteLine("Oops, you went below 0. Starting over at position 0.");
                    playerPosition = 0;
                }
                else if (playerPosition > 100)
                {
                    Console.WriteLine("You went above 100. You stay at previous position.");
                    playerPosition = previousPosition;
                }
                else if (playerPosition == 100)
                {
                    Console.WriteLine("Congratulations! You won the game!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your current position is " + playerPosition);
                }

                
                if (playerPosition + diceRoll > 100)
                {
                    Console.WriteLine("You cannot move forward as it would lead to a position greater than 100.");
                }
            }
        }
    }
}