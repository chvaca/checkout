using System;
using fvaca.Checkout.Contracts;
using fvaca.Checkout.Entities;
using fvaca.Checkout.Entities.Models;

namespace fvaca.Checkout.Repository
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateCard(Card owner)
        {
            throw new NotImplementedException();
        }

        public void DeleteCard(Card owner)
        {
            throw new NotImplementedException();
        }

        public Card GetCardById(Guid ownerId)
        {
            throw new NotImplementedException();
        }
    }
}
