using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoreIstanbul3.Models
{
    public class Facility
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [DisplayName("Instrument List")]
        public List<Instrument>? InstrumentList { get; set; }
    }
}
