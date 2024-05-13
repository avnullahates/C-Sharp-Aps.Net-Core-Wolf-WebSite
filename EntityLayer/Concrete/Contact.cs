﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string Adress { get; set; }

        public string Email1 { get; set; }

        public string Email2 { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }       

        public bool? Status { get; set; }
    }
}
