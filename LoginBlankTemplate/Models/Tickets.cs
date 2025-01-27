using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginBlankTemplate.Models
{
    public class Tickets
    {
        private static int _idCounter = 0;

        [Key]
        public string Id { get; private set; }

        [Required(ErrorMessage = "Ticket type is required.")]
        [Display(Name = "Ticket Type")]
        public string TicketType { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; private set; }

        // Dictionary to hold ticket types and their corresponding prices
        private static readonly Dictionary<string, decimal> TicketPrices = new Dictionary<string, decimal>
        {
            { "Adult", 12.50m }, // Use decimal literals
            { "Child", 8.50m },
            { "Senior", 10.00m },
        };

        public Tickets()
        {
            Id = GenerateId();
        }

        public Tickets(string ticketType, int quantity) : this()
        {
            TicketType = ticketType;
            Quantity = quantity;
            CalculatePrice(); // Call CalculatePrice to set the price
        }

        private string GenerateId()
        {
            _idCounter++;
            return _idCounter.ToString();
        }

        private decimal SetPrice(string ticketType)
        {
            // Check if the ticket type exists in the dictionary and return the corresponding price
            if (TicketPrices.TryGetValue(ticketType, out decimal price))
            {
                return price;
            }
            else
            {
                throw new KeyNotFoundException($"Ticket type '{ticketType}' not found.");
            }
        }

        public void CalculatePrice()
        {
            Price = SetPrice(TicketType) * Quantity;
        }
    }
}