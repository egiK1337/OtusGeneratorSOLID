using Otus_solid.GameInterfaces;

namespace Otus_solid.GameСlasses
{
    internal class ConsoleOutput : IOutput
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
