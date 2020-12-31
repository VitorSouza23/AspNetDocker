using System;
using AspNetDocker.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetDocker.InfraData
{
    internal class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(255).IsRequired();
            builder.Property(c => c.CPF).HasMaxLength(11).IsRequired();
            builder.Property(c => c.CreationDate).IsRequired();

            builder.HasData(new Customer
            {
                Id = new Guid("d06c4f86-bd87-4c37-a2cd-454f8115df62"),
                Name = "Teste",
                CPF = "38986605082", //CPF gerado a partir do site https://www.4devs.com.br/gerador_de_cpf
                CreationDate = new DateTime(2000, 1, 1)
            });
        }
    }
}