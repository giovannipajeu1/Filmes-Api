namespace FilmesApi.Data;
using System.Collections.Generic;
using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts)
            : base(opts)
        {

        }


        public ISet <Filme> Filmes { get; set; }
    }
