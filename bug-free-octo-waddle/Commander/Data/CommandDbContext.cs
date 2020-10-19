using Commander.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
	public class CommandDbContext : DbContext
	{
		public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
		{
		}

		public DbSet<Command> Commands { get; set; }
	}
}
