using System.ComponentModel.DataAnnotations;

namespace azure.Models
{
    public class azure
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
