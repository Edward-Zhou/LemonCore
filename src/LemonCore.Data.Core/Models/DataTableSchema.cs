﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LemonCore.Core.Models
{
    public class DataTableSchema
    {
        public string Name { get; set; }
        public string[] PrimaryKeys { get; set; }
        public DataColumn[] Columns { get; set; }
    }
}
