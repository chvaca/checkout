using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fvaca.Checkout.Entities.Models
{
    [Table("Card")]
    public class Card : IEntity
    {

        [CreditCard]
        [Required(ErrorMessage = "Card number is required")]
        public string Number { get; set; }

        [Range(100, 999)]
        [Required(ErrorMessage = "CVV is required")]
        public int CVV { get; set; }

        [Range(1, 12)]
        [Required(ErrorMessage = "Month is required")]
        public int ExpiryMonth { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int ExpiryYear { get; set; }

        [Key]
        [Column("CardId")]
        public Guid Id { get; set; }
    }
}
