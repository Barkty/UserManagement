using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UserQueue;

namespace UserModel
{

    public class UserUI 
    {
        public static void DisplayUser()
        {
        	User user = new User();
        	Console.WriteLine("Fill in your details as follows:");
			Console.WriteLine("Full name:");
			User.Name = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Email address:");
			User.Email = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Phone Number:");
			User.PhoneNumber = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Occupation:");
			User.Occupation = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Your Favourite Food:");
			User.FavouriteFood = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("These are your information:");
  			Console.WriteLine($"Fullname: {User.Name}\n" + $"Email address: {User.Email}\n" + $"Phone number: {User.PhoneNumber}\n" + $"What I do: {User.Occupation}\n" + $"My favourite food: {User.FavouriteFood}\n");
		
			var newUser = $"{User.Name}, {User.Email}, {User.PhoneNumber}, {User.Occupation}, {User.FavouriteFood}";
		
			UserQueue<string> userQueue = new UserQueue<string>();
			userQueue.Enqueue(newUser);
			//userQueue.Print();
        }
    }
}