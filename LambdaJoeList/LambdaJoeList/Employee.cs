﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaJoeList
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public static Boolean operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator !=(Employee employee1, Employee employee2)
        {
            if (employee1 == employee2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}