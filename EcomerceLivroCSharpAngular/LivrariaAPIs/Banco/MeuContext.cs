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
                new Produto { Id = 1, Nome = "Livro 1", Preco = 10.0, Quantidade = 10, Imagem = "imagem1.jpg", Categoria = "Ação" },
                new Produto { Id = 2, Nome = "Livro 2", Preco = 15.0, Quantidade = 8, Imagem = "imagem2.jpg", Categoria = "Ficção" },
                new Produto { Id = 3, Nome = "Livro 3", Preco = 20.0, Quantidade = 5, Imagem = "imagem3.jpg", Categoria = "Romance" },
                new Produto { Id = 4, Nome = "Livro 4", Preco = 25.0, Quantidade = 3, Imagem = "imagem4.jpg", Categoria = "Terror" },
                new Produto { Id = 5, Nome = "Livro 5", Preco = 30.0, Quantidade = 4, Imagem = "imagem5.jpg", Categoria = "Suspense" },
                new Produto { Id = 6, Nome = "Livro 6", Preco = 35.0, Quantidade = 2, Imagem = "imagem6.jpg", Categoria = "Aventura" }
            );
            context.SaveChanges();
        }
    }
}
