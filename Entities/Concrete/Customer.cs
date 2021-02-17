﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

    }
}