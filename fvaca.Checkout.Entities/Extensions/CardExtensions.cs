using System;
using fvaca.Checkout.Entities.Models;

namespace fvaca.Checkout.Entities.Extensions
{
    public static class CardExtensions
    {
        public static void Map(this Card dbcard, Card card)
        {
            dbcard.CVV = card.CVV;
            dbcard.ExpiryMonth = card.ExpiryMonth;
            dbcard.ExpiryYear = card.ExpiryYear;
            card.Number = card.Number;
        }
    }
}
