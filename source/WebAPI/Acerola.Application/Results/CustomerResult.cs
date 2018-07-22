namespace Acerola.Application.Results
{
    using System;
    using System.Collections.Generic;

    public sealed class CustomerResult
    {
        public Guid CustomerId { get; }
        public string Personnummer { get; }
        public string Name { get; }
        public string Gender { get; }
        public IReadOnlyList<AccountResult> Accounts { get; }

        public CustomerResult(
            Guid customerId,
            string personnummer,
            string name,
            string gender,
            List<AccountResult> accounts)
        {
            CustomerId = customerId;
            Personnummer = personnummer;
            Name = name;
            Gender = gender;
            Accounts = accounts;
        }
    }
}
