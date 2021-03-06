﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZooMag.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string TitleEn { get; set; }
        public string TitleRu { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
