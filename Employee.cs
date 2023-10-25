using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme1111
{
    internal class Employee
    {
        string _name;
        string _surName;
        int _age;
        string _userName;
        
        public string Name 
        {   get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? char.ToUpper(value[0]) + value.Substring(1) : string.Empty;

        }
        public string SurName 
        {
            get => _surName;
            set => _surName = !string.IsNullOrWhiteSpace(value) ? char.ToUpper(value[0]) + value.Substring(1) : string.Empty;
        }

        public string UserName { 
           get 
            {
                return _userName;
            } 
            
            private set
            {
                _userName = Name + "_" + SurName;
            }
            
        }

        public int Age { get => _age; set => _age = value > 0 ? value : -1; }

        public Employee(string name,string surname, byte age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }


        public override string ToString()
        {
            return $"{Name} {SurName} {UserName} {Age}";
        }
    }
}
