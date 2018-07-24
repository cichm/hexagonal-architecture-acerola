using Acerola.Domain.ValueObjects;

namespace Acerola.Application.Commands.Register
{
    public sealed class RegisterCommand
    {
        public string Personnummer { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public double InitialAmount { get; private set; }

        public RegisterCommand(string personnummer, string name, string gender, double initialAmount)
        {
            Personnummer = personnummer;
            Name = name;
            Gender = gender;
            InitialAmount = initialAmount;
        }
    }
}
