using Otus_solid.GameInterfaces;

namespace Otus_solid.GameСlasses
{
    public class LimitedGuessNumberGame : BaseGuessNumberGame
    {
        private int _maxAttempts;

        public LimitedGuessNumberGame(INumberGenerator numberGenerator, IUserInput input, IOutput output, int maxAttempts = 10) : base(numberGenerator, input, output)
        {
            _maxAttempts = maxAttempts;
        }

        protected override void Play()
        {
            int attempts = 0;

            while (attempts < _maxAttempts)
            {
                int guess = _userInput.GetInput();
                attempts++;

                if (guess < _randomNumber)
                {
                    _output.Message("Больше!");
                }
                else if (guess > _randomNumber)
                {
                    _output.Message("Меньше!");
                }
                else
                {
                    _output.Message($"Поздравляем! Вы угадали число {_randomNumber} за {attempts} попыток.");
                    return;
                }
            }
            _output.Message($"Вы исчерпали все попытки. Загаданное число было {_randomNumber}.");
        }
    }
}
