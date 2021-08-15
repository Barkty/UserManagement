using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UserQueue;
using UserModel;

namespace UserFileManager
{

    public class UserFiles 
    {

    	public async static void ReadFileAsync() 		
    	{
    		UserQueue<string> node = new UserQueue<string>();
    		
			string path = @"../UserFile/RegisterFile.txt";
        	if (!File.Exists(path))
        {
        	using StreamWriter sw = File.CreateText(path);
        }
			using (StreamReader streamReader = File.OpenText(path))
        {
        	var read = await streamReader.ReadToEndAsync();
        	read = read.TrimEnd();
			node.Enqueue(read);
    		//return read;
			//var users = read.Split(Environment.NewLine);	
        }
        
    	}

    	public static void WriteFile()
    	{
			User user = new User();
        	string path = @"../UserFile/RegisterFile.txt";
        	if (File.Exists(path))
        	{
        		File.Delete(path);
        	}
			using StreamWriter sw = File.CreateText(path);
			sw.Dispose();

        	using (var stream = File.AppendText(path))
        	stream.WriteLine($"Fullname: {User.Name}\n" + $"Email address: {User.Email}\n" + $"Phone number: {User.PhoneNumber}\n" + $"What I do: {User.Occupation}\n" + $"My favourite food: {User.FavouriteFood}\n");
        }
    }       
}