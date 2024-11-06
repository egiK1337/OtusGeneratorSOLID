using Otus_solid.GameInterfaces;


public abstract class BaseGuessNumberGame : IGuessNumberGame
{
    protected INumberGenerator _numberGenerator;
    protected int _randomNumber;
    protected IUserInput _userInput;
    protected IOutput _output;

    public BaseGuessNumberGame(INumberGenerator numberGenerator, IUserInput userInput, IOutput output)
    {
        _numberGenerator = numberGenerator;
        _userInput = userInput;
        _output = output;

    }

    public virtual void StartGame()
    {
        _randomNumber = _numberGenerator.Generate(100); // Генерируем число до 100
        Play();
    }

    protected abstract void Play(); // Абстрактный метод для реализации в подклассах
}
