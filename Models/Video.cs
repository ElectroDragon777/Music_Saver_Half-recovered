using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Video
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public long Length { get; set; }

        public List<User> Users { get; set; }
    }
}