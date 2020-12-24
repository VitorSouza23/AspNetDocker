using System;

namespace AspNetDocker.Model
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime CreationDate { get; set; }
    }
}