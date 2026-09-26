using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Classes
{
	class Employee : Person
	{
		private string _name = "";
		private PersonType _type = PersonType.Employee;

		public Employee(string name, PersonType type)
		{
			_name = name;
			_type = type;
		}

		public string GetName()
		{
			return _name;
		}

		public PersonType GetType()
		{
			return _type;
		}
	}
}
