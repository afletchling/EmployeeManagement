using EmployeeManagement.Classes;
using EmployeeManagement.Options;

namespace EmployeeManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the employee manager!");
			OptionManager.instance.RegisterOption(new AddEmployee());
			OptionManager.instance.RegisterOption(new RemoveEmployee());
			OptionManager.instance.RegisterOption(new ListEmployees());
			OptionManager.instance.RegisterOption(new ExitProgram());

			while (true)
			{
				OptionManager.instance.DisplayOptions();
				OptionManager.instance.ExecuteAction(Console.ReadLine());
			}
		}
	}
}