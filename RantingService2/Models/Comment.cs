using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RantingService2.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [DisplayName("User Name")]
        public string Commenter { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime Commentdate { get; set; } = DateTime.Now;
        [Range(1, 5)]
        [DisplayName("Rate Product")]
        public int Rating { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Provide feedbag")]
        public string feedbag { get; set; }
    }
}