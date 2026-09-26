using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Classes
{
	internal class EmployeeManager
	{
		public static EmployeeManager instance = new();
		private List<Person> employees = new List<Person>();

		public void AddEmployee(Employee employee)
		{
			employees.Add(employee);
			employees.Sort((comp, comp2) => ((int)comp2.GetType()).CompareTo((int)comp.GetType()));
		}

		public bool RemoveEmployeeByName(string name)
		{
			Person? found = employees.Find((Person employee) => employee.GetName() == name);
			if (found != null)
			{
				employees.Remove(found);
				return true;
			}

			return false;
		}

		public void ListEmployed()
		{
			Console.Clear();
			employees.ForEach((Person employee) =>
			{
				Console.WriteLine($"{employee.GetName()}: {employee.GetType()}");
			});
			Console.WriteLine("");
		}

		public bool IsEmpty()
		{
			return employees.Count <= 0;
		}
	}
}
