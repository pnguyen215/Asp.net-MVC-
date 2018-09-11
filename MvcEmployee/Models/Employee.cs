﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEmployee.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }
    public class EmpDBContext : DbContext
    {
        public EmpDBContext(){

    }
        public DbSet<Employee> Employees { get; set; }
    }
    

}