using EmployeeManagement.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Classes
{
	internal class OptionManager
	{
		public static OptionManager instance = new OptionManager();
		private List<Option> options = new List<Option>();

		public void DisplayOptions()
		{
			for (int index = 0; index < options.Count; index++)
			{
				Option option = options[index];
				Console.WriteLine($"{index + 1}. {option.Name}");
			}
		}

		public void ExecuteAction(string? input)
		{
			if (input != null && int.TryParse(input, out int result) && result <= options.Count && result > 0)
			{
				Console.Clear();
				options[result - 1].Function();
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Invalid action! Please try again.");
			}
		}

		public void RegisterOption(Option option)
		{
			options.Add(option);
		}
	}
}
