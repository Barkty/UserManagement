using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace UserQueue
{

    public class UserNode<T>
    {
    	public UserNode(T value)
    	{
    		this.Value = value;
    	}
    	
        public T Value {get; set;}
        
		public UserNode<T> Next {get; set;}
        
    }
}