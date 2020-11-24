namespace Vidly.Dtos
{
    using System.ComponentModel.DataAnnotations;

    public class MembershipTypeDto
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}