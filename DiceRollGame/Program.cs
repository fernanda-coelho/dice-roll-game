using DiceRollGame;

// Criar o gerador de números
Random randomGenerator = new Random();
// Criar o dado
Dice dice = new Dice(randomGenerator);
// Chamar o método Roll
int resultNumber = dice.Roll();
Console.WriteLine($"Número sorteado: {resultNumber}");

// Criar o Game e executar
Game game1 = new Game(resultNumber);
game1.Execute();
