﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class ORM : DbContext
    {
         public DbSet<Person> People { get; set; }

    }
}
