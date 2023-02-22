using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoAplication.Models
{
    public partial class Video
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VideoId { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public short? Year { get; set; }
        public byte? Rate { get; set; }
        public int? ApiId { get; set; }
    }
}
