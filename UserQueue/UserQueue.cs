using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace UserQueue
{

    public class UserQueue<T> 
    {
        public UserNode<T> Head {get; set;}
        
        public UserNode<T> Tail {get; set;}
        
        public int Count {get; set;}
        
        public UserNode<T> Enqueue(T value)
        {
			UserNode<T> node = new UserNode<T>(value);
        	
        	if(this.Head == null)
        	{
        		Head = Tail = node;
        		this.Count += 1;
        		return node;
        	}
        	
        	this.Tail.Next = node;
        	this.Tail = node;
        	this.Count += 1;
        	return node;
        }
        
		public bool Dequeue(T value)
        {
        	UserNode<T> temp = Head;
        	if(this.Head == null)
        	{
        		throw new InvalidOperationException("Queue is empty");
        	}
        	this.Head = temp.Next;
        	temp.Next = null;
        	this.Count -= 1;
        	return true;
        }
        
		public void Print()
        {
        	var temp = Head;
        	while (temp != null)
        	{
        		Console.WriteLine(temp.Value);
        		temp = temp.Next;
            }
        }
    }
}