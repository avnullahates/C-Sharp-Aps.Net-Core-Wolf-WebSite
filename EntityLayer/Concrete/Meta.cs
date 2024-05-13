using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Meta
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Keyword { get; set; }

        public string Title { get; set; }

        public string Viewport { get; set; }

        public string Charset { get; set; }

        public string Robots { get; set; }

        public string LinkCanonical { get; set; }

    }
}
