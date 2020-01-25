﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentApplication.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}