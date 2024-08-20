﻿using AgendamentoDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoDeTarefas.Context;

public class OrganizadorContext : DbContext
{
    public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
    {
    }

    public DbSet<Tarefa> Tarefas { get; set; }
}