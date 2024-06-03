using System.ComponentModel.DataAnnotations;

namespace FCode_CRUD.AppModels
{
    public class DemoUsers
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public long Phone { get; set; }
    }
    public class DemoUsers1
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public long Phone { get; set; }
    }
}
