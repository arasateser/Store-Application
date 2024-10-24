﻿using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories.Config;
using System.Reflection;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {

    }

    public RepositoryContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfiguration(new ProductConfig());
        //modelBuilder.ApplyConfiguration(new CategoryConfig());

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //tek tek configure etmek yerine bulup isleyecek

    }
}