namespace DiceRollGame
{
    public class Validator
    {
        // Método GetValidInput - faz o usuário digitar um input válido para o jogo
        public static int GetValidInput()
        {
            while(true)
            {
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();

                if (!(Int32.TryParse(userInput, out int userInputNumber)))
                {
                    Console.WriteLine("Incorrect Input");
                    continue;
                }

                return userInputNumber;
            }
        }
    }
}
