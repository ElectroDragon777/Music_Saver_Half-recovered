﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class User : IdentityUser
    {
        public List<Video> VideosSaved { get; } = new List<Video>();
    }
}
