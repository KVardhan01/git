using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCode_CRUD.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName ="NVARCHAR(30)")]
        public string UserName { get; set; }
        [Column(TypeName = "NVARCHAR(30)")]

        public string UserEmail { get; set; }
        [Column(TypeName = "NVARCHAR(30)")]

        public string Password { get; set; }
        [Column(TypeName = "BIGINT")]

        public long PhoneNumber { get; set; }
        [Column(TypeName="VARBINARY(MAX)")]   
        public byte[] PDFfile { get; set; }

    }
}
