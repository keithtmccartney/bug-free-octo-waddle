﻿using bug_free_octo_waddle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bug_free_octo_waddle.Data
{
	public class MockCommandRepo : ICommandRepo
	{
		public IEnumerable<Command> GetAppCommands()
		{
			var commands = new List<Command>
			{
				new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
				new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "knife & chopping board" },
				new Command { Id = 0, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & cup" }
			};

			return commands;
		}

		public Command GetCommandById(int id)
		{
			return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
		}
	}
}
