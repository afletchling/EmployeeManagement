using EmployeeManagement.Classes;
using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;

namespace EmployeeManagement.Options
{
	internal class ListEmployees : Option
	{
		public ListEmployees() : base("List Employees") { }

		public override void Function()
		{
			EmployeeManager.instance.ListEmployed();
		}
	}
}
