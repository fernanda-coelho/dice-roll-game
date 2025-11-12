namespace DiceRollGame
{
    public class Dice
    {
        // Atributos
        public int diceNumber {  get; private set; }
        private readonly Random _random;

        // Construtor (exige o random criado fora, pois se criado e chamado duas vezes poderia ter problema na aleatoriedade)
        public Dice(Random random)
        {
            _random = random;
        }

        // Método Roll - rola o dado
        public int Roll()
        {
            int result = _random.Next(1, 7);
            this.diceNumber = result;
            return result;
        }
    }
}
