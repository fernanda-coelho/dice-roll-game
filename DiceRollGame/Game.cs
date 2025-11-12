namespace DiceRollGame
{
    public class Game
    {
        // Atributos
        private int _diceResult;
        private int _userAttempt;

        // Construtor
        public Game(int resultNumber)
        {
            this._diceResult = resultNumber;
            this._userAttempt = 1;
        }

        // Método Execute - Executa o jogo
        public void Execute()
        {            
            bool hasWon = false;

            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

            do
            {
                int userInputNumber = Validator.GetValidInput();
                bool result = IsUserCorrect(userInputNumber, _diceResult);
                PrintResult(result);
                this._userAttempt++;

                if (result)
                {
                    hasWon = true;
                    break;
                }

            }
            while (_userAttempt < 4);

            // Se o usuário passou da terceira tentativa sem acertar o número, o jogo acaba
            if (!hasWon)
            {
                Console.WriteLine($"You lose! The correct number was {_diceResult}:( ");
            }

        }

        //Método IsUserCorrect - verifica se o número do usuário é o mesmo que foi sorteado pelo dado
        private bool IsUserCorrect(int userInputNumber, int _diceResult)
        {
            bool result = false;

            if (userInputNumber == _diceResult)
            {
                result = true;
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        // Método PrintResult - Mostra o resultado após a tentativa
        private void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("You win!!");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }
        }

    }
}
