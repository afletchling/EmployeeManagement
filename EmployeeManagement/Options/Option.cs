using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Options
{
	internal abstract class Option
	{
		public string Name { get; set; }
		public abstract void Function();

		public Option(string name)
		{
			Name = name;
		}
	}
}
