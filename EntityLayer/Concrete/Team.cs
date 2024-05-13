using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        public string PictureUrl { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Title { get; set; }       

        public string? TwitterLink { get; set; }

        public string? FacebookLink { get; set; }

        public string? InstagramLink { get; set; }

        public string? LinkedInLink { get; set; }

        public bool? Status { get; set; }

        public string Delay { get; set; }

    }
}
