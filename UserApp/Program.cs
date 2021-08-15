using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UserModel;
using UserFileManager;

namespace UserManagementApp
{

    public class Program 
    {
        public static void Main()
        {
        	UserFiles.ReadFileAsync();
			Console.WriteLine("Welcome to Barkty User Management Console App");
			Console.WriteLine("Press 1 to Register");
			Console.WriteLine("Press 2 to Close the app");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch (choice)
			{
				case 1: {
					Console.Clear();
					UserUI.DisplayUser();
					UserFiles.WriteFile();
					Console.WriteLine("Press # to go back to Register page");
					Console.ReadLine();
					Console.Clear();
					UserUI.DisplayUser();
					UserFiles.WriteFile();
					break;
				}
				case 2: {
					Console.Clear();
					UserFiles.WriteFile();
					break;
				}
				default: 
                UserFiles.WriteFile();
                break;
			}	
        }
    }
}