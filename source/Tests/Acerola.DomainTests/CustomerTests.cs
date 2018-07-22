namespace Acerola.DomainTests
{
    using Xunit;
    using Acerola.Domain.Customers;
    using Acerola.Domain.Accounts;
    using System;

    public class CustomerTests
    {
        [Fact]
        public void Customer_Should_Be_Registered_With_1_Account()
        {
            //
            // Arrange
            Customer sut = new Customer(
                "741214-3054",
                "Sammy Fredriksson",
                "Male");

            Account account = new Account(sut.Id);

            //
            // Act
            sut.Register(account.Id);

            //
            // Assert
            Assert.Single(sut.Accounts);
        }

        [Fact]
        public void Customer_Should_Be_Loaded()
        {
            //
            // Arrange
            AccountCollection accounts = new AccountCollection();
            accounts.Add(Guid.NewGuid());

            Guid customerId = Guid.NewGuid();

            Customer customer = new Customer(
                customerId,
                "Sammy Fredriksson",
                "Male",
                "741214-3054",
                accounts);

            Assert.Equal(customerId, customer.Id);
            Assert.Equal("Sammy Fredriksson", customer.Name);
            Assert.Equal("Male", customer.Gender);
            Assert.Equal("741214-3054", customer.SSN);
            Assert.Equal(accounts, customer.Accounts);
        }
    }
}
