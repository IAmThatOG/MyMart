﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyMart.Domain.Models.Request
{
    public class RackRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
