using CoreIstanbul3.Models;

namespace CoreIstanbul3.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public string? Description { get; set; }
        public Facility? Facility { get; set; }
        public int FacilityId { get; set; }
    }
}
