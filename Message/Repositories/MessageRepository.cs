using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Message.Repositories
{
    public interface MessageRepository : IMessageRepository
    {
        private readonly List<Message> messages = new List<Message>();
        public MessageRepository()
        {
            messages.Add(new message
            {
                UserID
            });

            messages.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0002",
                Name = "DELL Laptop",
                Quantity_In_Stock = 25,
                Unit_Price = 135000
            });

            messages.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0003",
                Name = "HP Laptop",
                Quantity_In_Stock = 20,
                Unit_Price = 115000
            });
        }
        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(messages);
        }
    
    }
}
