using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Home
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Button { get; set; }

        public string ButtonUrl { get; set; }

        public string ImageUrl { get; set; }

        public string BackgroundUrl { get; set; }

        public bool Status { get; set; }


    }
}
