using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istore
{
    public class OrderItem
    {

        public int BookId { get; }

        public int count;

        public int Count
        {
            get { return count; }
            set
            {
                ThrowifValidateCount(value);

                count = value; 

            }
        }
        
        public decimal Price { get; }

        public OrderItem(int bookId, int count, decimal price)
        {
            ThrowifValidateCount(count);

            BookId = bookId;
            Count = count;
            Price = price;

        }

        private static void ThrowifValidateCount(int count)
        {
            if (count <= 0)
                throw new ArgumentException("Count must be greater than zero.");
        }
    }
}
