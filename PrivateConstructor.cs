using System;


     class User
     {
        // Static Constructor
        static User()
        {
           Console.WriteLine("I am Static Constructor");
        }
        // Default Constructor
        public User()
        {
           Console.WriteLine("I am Default Constructor");
        }
     
   
         static void Main(string[] args)
         {
             // Both Static and Default constructors will invoke for the first instance
             User user = new User();
           
         }
     }
