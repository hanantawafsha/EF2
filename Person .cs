﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // abstract method
        public abstract void DisplayInfo();
    }
}
