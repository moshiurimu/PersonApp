using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        public string FirstName { private get; set; }
        public string MiddleName { private get; set; }
        public string LastName { private get; set; }

        public Person(string firstName, string middleName, string lastName): this (firstName,lastName)
        {
            MiddleName = middleName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

                  

        public string GetFullReversName()
        {
            string fullName = GetFullName();
            string reverseName = "";
            for (int index = fullName.Length - 1; index >= 0; index--)
               {
                  reverseName += fullName[index];
               }
            
                return reverseName;
            }

        }

    }



