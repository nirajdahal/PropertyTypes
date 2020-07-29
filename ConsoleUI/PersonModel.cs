using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class PersonModel
    {
        public string FirstName { get;  set; }

        public string LastName { get; private set; }

        public string Password { private get; set; }

        

        public string FullName
        {
            get 
            { return $"{FirstName} {LastName}"; 
            }
            
        }




        //The underscore _age represents private value that implies it shouldnot be modified directly.
        //The onmly place we should manipulate is inside of age property in this case
        private int _age;

        public int Age
        {
            get
            { 
                return _age; 
            }

            set 
            {
                if(value > 1)
                {
                    _age = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age is not valid");
                }
               
            }

          
    }

        private string _ssn;

        public string SSN
        {
            get
            {
                //123-45-6789
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output; 
            }
            set { _ssn = value; }
        }


        //Constructor is used so that at least it allows whatvalue should be provided while instatntiating class
        //Reduce code while instializing object
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

        //Overloading. If we dont want to provide data while initializing object then creating a method 
        //allows us both option to provide or not provide data during intialization
        //Console.WriteLine() is example of overloading method because it allows any type of data.
        public PersonModel()
        {

        }

    }
}
