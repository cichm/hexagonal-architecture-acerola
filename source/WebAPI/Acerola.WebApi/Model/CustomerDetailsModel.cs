using Acerola.Domain.ValueObjects;

namespace Acerola.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public sealed class CustomerDetailsModel
    {
        public Guid CustomerId { get; }
        public string Personnummer { get; }
        public string Name { get; }
        public string Gender { get; }
        public List<AccountDetailsModel> Accounts { get; }

        public CustomerDetailsModel(Guid customerId, string personnummer, string name, string gender, List<AccountDetailsModel> accounts)
        {
            CustomerId = customerId;
            Personnummer = personnummer;
            Name = name;
            Gender = gender;
            Accounts = accounts;
        }
    }
}
