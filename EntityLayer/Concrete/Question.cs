﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Questionq { get; set; }

        public bool? Status { get; set; }
    }
}
