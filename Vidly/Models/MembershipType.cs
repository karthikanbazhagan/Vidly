namespace Vidly.Models
{
    using System.ComponentModel.DataAnnotations;

    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public short SignupFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }
    }
}