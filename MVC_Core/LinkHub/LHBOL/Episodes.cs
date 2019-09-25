using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LHBOL
{
    [Table("Episodes")]
    public partial class Episodes
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int IdGamebook { get; set; }
        public byte Publish { get; set; }
        public string Name { get; set; }
        public string InternalName { get; set; }
        public string Image { get; set; }
        public string Illustrator { get; set; }
        public int? Ord { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("user")]
        public string UserId { get; set; }
        public Gamebooks Gamebooks { get; set; }
        public User Useer { get; set; }

    }
}
