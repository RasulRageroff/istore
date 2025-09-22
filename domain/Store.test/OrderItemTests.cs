using istore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.test
{
    public class OrderItemTests
    {
        [Fact]
        public void OrderItem_WithZeroCount_ThrowsArgumentsOutOfRangeException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int count = 0;
                new OrderItem(1, count, 0m);
            });
        }

        [Fact]
         public void OrderItem_WithNegativeCount_ThrowsArgumentsOutOfRangeException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int count = -1;
                new OrderItem(1, count, 0m);
            });
        }

        [Fact]
        public void OrderItem_WithPositiveCount_SetsCount()
        {
            var orderItem = new OrderItem(1, 2, 3m);

            Assert.Equal(1, orderItem.BookId);
            Assert.Equal(2, orderItem.Count);
            Assert.Equal(3m, orderItem.Price);

           
        }
    }
}
