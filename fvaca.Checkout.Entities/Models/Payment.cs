using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fvaca.Checkout.Entities.Models
{
    [Table("Payment")]
    public class Payment : IEntity
    {
        [Required(ErrorMessage = "Card is required")]
        public Guid CardId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public double Amount { get; set; }

        public bool IsSuccessful { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Key]
        [Column("PaymentId")]
        public Guid Id { get; set; }
    }
}
