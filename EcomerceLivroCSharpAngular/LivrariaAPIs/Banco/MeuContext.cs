using LivrariaAPIs.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LivrariaAPIs.Banco;

public class MeuContext : DbContext
{
    public MeuContext(DbContextOptions<MeuContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }


    /// <summary>
    /// Iniciar dados
    /// Remover após integrar com banco de dados
    /// </summary>
    /// <param name="context"></param>
    public void SeedData(MeuContext context)
    {
        if (!context.Produtos.Any())
        {
            context.Produtos.AddRange(
                new Produto { Id = 1, Name = "Livro 1", Price = 10.0, Quantity = 10, Image = "imagem1.jpg", Category = "Ação" },
                new Produto { Id = 2, Name = "Livro 2", Price = 15.0, Quantity = 8, Image = "imagem2.jpg", Category = "Ficção" },
                new Produto { Id = 3, Name = "Livro 3", Price = 20.0, Quantity = 5, Image = "imagem3.jpg", Category = "Romance" },
                new Produto { Id = 4, Name = "Livro 4", Price = 25.0, Quantity = 3, Image = "imagem4.jpg", Category = "Terror" },
                new Produto { Id = 5, Name = "Livro 5", Price = 30.0, Quantity = 4, Image = "imagem5.jpg", Category = "Suspense" },
                new Produto { Id = 6, Name = "Livro 6", Price = 35.0, Quantity = 2, Image = "imagem6.jpg", Category = "Aventura" }
            );
            context.SaveChanges();
        }
    }
}
