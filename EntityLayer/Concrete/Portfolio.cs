using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }

        public string? PictureLink { get; set; }

        public string? VideoLink { get; set; }      

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Type { get; set; }

        public bool? Status { get; set; }


    }
}
