
using Otus_solid.GameInterfaces;
using Otus_solid.GameСlasses;


namespace Otus_solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INumberGenerator randomGenerator = new RandomNumberGenerator();

            IUserInput input = new ConsoleUserInput();

            IOutput output = new ConsoleOutput();

            IGuessNumberGame game = new LimitedGuessNumberGame(randomGenerator, input, output);

            game.StartGame();
        }
    }
}
