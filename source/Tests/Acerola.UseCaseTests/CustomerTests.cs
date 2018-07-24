namespace Acerola.UseCaseTests
{
    using Xunit;
    using NSubstitute;
    using System;
    using Acerola.Application.Commands.Register;
    using Acerola.Application.Repositories;

    public class CustomerTests
    {
        public IAccountReadOnlyRepository accountReadOnlyRepository;
        public IAccountWriteOnlyRepository accountWriteOnlyRepository;
        public ICustomerReadOnlyRepository customerReadOnlyRepository;
        public ICustomerWriteOnlyRepository customerWriteOnlyRepository;

        public CustomerTests()
        {
            accountReadOnlyRepository = Substitute.For<IAccountReadOnlyRepository>();
            accountWriteOnlyRepository = Substitute.For<IAccountWriteOnlyRepository>();
            customerReadOnlyRepository = Substitute.For<ICustomerReadOnlyRepository>();
            customerWriteOnlyRepository = Substitute.For<ICustomerWriteOnlyRepository>();
        }

        [Theory]
        [InlineData("08724050601", "Ivan Paulovich", "male", 300)]
        [InlineData("08724050601", "Ivan Paulovich Pinheiro Gomes", "male", 100)]
        [InlineData("08724050601", "Ivan Paulovich", "male", 500)]
        [InlineData("08724050601", "Ivan Paulovich", "male", 10000)]
        public async void Register_Valid_User_Account(string personnummer, string name, string gender, double amount)
        {
            var registerUseCase = new RegisterService(
                customerWriteOnlyRepository,
                accountWriteOnlyRepository
            );

            var request = new RegisterCommand(
                personnummer,
                name,
                gender,
                amount
            );

            RegisterResult result = await registerUseCase.Process(request);

            Assert.Equal(request.Personnummer, result.Customer.Personnummer);
            Assert.Equal(request.Name, result.Customer.Name);
            Assert.True(result.Customer.CustomerId != Guid.Empty);
            Assert.True(result.Account.AccountId != Guid.Empty);
        }
    }
}
