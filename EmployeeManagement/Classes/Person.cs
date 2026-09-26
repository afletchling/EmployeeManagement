using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Classes
{
	internal interface Person
	{
		string GetName();
		PersonType GetType();
	}
}
