﻿namespace Acerola.WebApi.UseCases.Register
{
    using Acerola.WebApi.Model;
    using System;
    using System.Collections.Generic;

    internal sealed class Model
    {
        public Guid CustomerId { get; }
        public string Personnummer { get; }
        public string Name { get; }
        public string Gender { get; }
        public List<AccountDetailsModel> Accounts { get; set; }

        public Model(Guid customerId, string perssonnummer, string name, string gender, List<AccountDetailsModel> accounts)
        {
            CustomerId = customerId;
            Personnummer = perssonnummer;
            Name = name;
            Gender = Gender;
            Accounts = accounts;
        }
    }
}
