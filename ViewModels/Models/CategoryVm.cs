﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Models
{
    public class CategoryVm
    {
        public string name { get; set; }
        public string imagesrc { get; set; }
        public IFormFile image { get; set; }
    }
}
