using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalCoin.Core.Domain;
using MetalCoin.Core.Enums;

namespace MetalCoin.Infra.Data.Mappings
{
    internal class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
            public void Configure(EntityTypeBuilder<Usuario> builder)
            {
                builder.ToTable("Usuarios");

                builder.HasKey(p => p.Id);

                builder.Property(p => p.Nome)
                    .HasColumnType("varchar(100)")
                    .IsRequired();

                builder.Property(p => p.Email)
                    .HasColumnType("varchar(100)")
                    .IsRequired();

                builder.Property(p => p.Senha)
                    .HasColumnType("varchar(100)")
                    .IsRequired();

                builder.Property(p => p.Perfil)
                    .HasColumnType("int")
                    .IsRequired();

            builder.HasData(
                new Usuario
                {
                    Id = Guid.NewGuid(),
                    Nome = "Administrador",
                    Senha = "abc123",
                    Email = "admin@metalcoin.com.br",
                    Perfil = TipoPerfil.Administrador
                },
                new Usuario
                {
                    Id = Guid.NewGuid(),
                    Nome = "Usuario Comun",
                    Senha = "abc123",
                    Email = "usuario@metalcoin.com.br",
                    Perfil = TipoPerfil.Usuario
                }
                );

            }
    }
}
