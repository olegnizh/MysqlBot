using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mysql.Models
{
    public class Qa
    {
        //[MaxLength(50)]
        [Column(TypeName = "int(11)", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QaId { get; set; }
        [Column(TypeName = "nvarchar(1000)", Order = 2)]
        public string Quest { get; set; }
        [Column(TypeName = "nvarchar(1000)", Order = 3)]
        public string? Answ { get; set; }
        [Column(TypeName = "nvarchar(1000)", Order = 4)]
        public string? Hyper { get; set; }
        [Column(Order = 5)]
        public int? Number { get; set; }
        [Column(TypeName = "text", Order = 6)]
        public string? UserMessage { get; set; }
        [Column(Order = 7)]
        public int? Status { get; set; }
        [Column(TypeName = "text", Order = 8)]
        public string? StatusMessage { get; set; }
        [Column(Order = 9)]
        public int Active { get; set; }
        [Column(TypeName = "nvarchar(300)", Order = 10)]
        public string? Org { get; set; }
        [Column(TypeName = "nvarchar(100)", Order = 11)]
        public string? Tel { get; set; } 

    }
}
