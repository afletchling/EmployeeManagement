using EmployeeManagement.Classes;
using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagement.Options
{
	internal class AddEmployee : Option
	{
		public AddEmployee() : base("Add Employee") { }

		public override void Function()
		{
			Console.Write("What is the name of the employee? ");
			string? name = Console.ReadLine();
			while (true)
			{
				Console.Write("What is the type of the employee? ");

				string? type = Console.ReadLine();
				if (Enum.TryParse(type, true, out PersonType result))
				{
					EmployeeManager.instance.AddEmployee(new Employee(name, result));
					Console.Clear();
					break;
				}
				else
				{
					Console.WriteLine("Invalid type! Try again. ");
				}
			}
		}
	}
}
