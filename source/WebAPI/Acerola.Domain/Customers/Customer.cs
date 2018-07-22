namespace Acerola.Domain.Customers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Acerola.Domain.ValueObjects;

    public sealed class Customer : IEntity, IAggregateRoot
    {
        public Guid Id { get; }
        public Name Name { get; }
        public Gender Gender { get; }
        public SSN SSN { get; }
        public ReadOnlyCollection<Guid> Accounts
        {
            get
            {
                ReadOnlyCollection<Guid> readOnly = new ReadOnlyCollection<Guid>(_accounts);
                return readOnly;
            }
        }

        private AccountCollection _accounts;

        public Customer(Guid id, Name name, Gender gender, SSN ssn, AccountCollection accounts)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SSN = ssn;
            _accounts = accounts;
        }

        public Customer(SSN ssn, Name name, Gender gender)
        {
            Id = Guid.NewGuid();
            SSN = ssn;
            Name = name;
            Gender = gender;
            _accounts = new AccountCollection();
        }

        public void Register(Guid accountId)
        {
            _accounts.Add(accountId);
        }
    }
}
