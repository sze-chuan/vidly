﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTO
{
    public class MembershipTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}