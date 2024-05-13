using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string DescriptionTitle { get; set; }

        public string ImageUrl { get; set; }

        public string? ImageTitle { get; set; }

        public string ImageDescription { get; set; }

        public string MetaDescription { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaTitle { get; set; }

        public string MetaViewport { get; set; }

        public string MetaCharset { get; set; }

        public string MetaRobots { get; set; }

        public string MetaLinkCanonical { get; set; }

        public bool Status { get; set; }


    }
}
