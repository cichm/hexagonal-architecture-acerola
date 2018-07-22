using Acerola.Domain.ValueObjects;

namespace Acerola.Infrastructure.MongoDataAccess.Entities
{
    using System;

    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string SSN { get; set; }
    }
}
