using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class VisitDetail
    {
        [Key]
        public int QueueId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string QueueNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string QueueDate { get; set; }
        [Required]
        [Column(TypeName = "smallint")]
        public int QueueStatus { get; set; }
    }
}
