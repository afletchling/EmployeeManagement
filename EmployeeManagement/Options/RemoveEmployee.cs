using EmployeeManagement.Classes;
using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;

namespace EmployeeManagement.Options
{
	internal class RemoveEmployee : Option
	{
		public RemoveEmployee() : base("Remove Employee") { }

		public override void Function()
		{
			if (!EmployeeManager.instance.IsEmpty())
			{
				Console.Write("What is the name of the employee? ");

				string? name = Console.ReadLine();
				if (EmployeeManager.instance.RemoveEmployeeByName(name))
				{
					Console.Clear();
				}
				else
				{
					Console.Clear();
					Console.WriteLine("No employee found.");
				}
			} 
			else
			{
				Console.Clear();
				Console.WriteLine("Employee list is empty.");
			}
		}
	}
}
