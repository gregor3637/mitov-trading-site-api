using System.ComponentModel.DataAnnotations;

namespace Investments.DB
{
    public class Investment
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
