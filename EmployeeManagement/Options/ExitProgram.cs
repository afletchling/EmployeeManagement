using EmployeeManagement.Classes;
using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;

namespace EmployeeManagement.Options
{
	internal class ExitProgram : Option
	{
		public ExitProgram() : base("Exit Program") { }

		public override void Function()
		{
			Environment.Exit(0);
		}
	}
}
