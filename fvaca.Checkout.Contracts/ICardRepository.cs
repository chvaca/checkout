using System;
using fvaca.Checkout.Entities.Models;

namespace fvaca.Checkout.Contracts
{
    public interface ICardRepository: IRepositoryBase<Card>
    {
        Card GetCardById(Guid ownerId);
        void CreateCard(Card owner);
        void DeleteCard(Card owner);
    }
}
