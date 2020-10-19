using bug_free_octo_waddle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bug_free_octo_waddle.Data
{
	public interface ICommandRepo
	{
		IEnumerable<Command> GetAppCommands();
		Command GetCommandById(int id);
	}
}
