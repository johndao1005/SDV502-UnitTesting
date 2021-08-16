using System;
using System.Collections.Generic;
using Xunit;

namespace CinemaApp
{
    public class PriceTicketTest
    {
        private readonly TicketPriceController _app;

        public PriceTicketTest()
        {
            _app = new TicketPriceController();
        }

        [Fact]
        public void AdultBefore_5()
        {
            decimal cost = _app.Adult_Before_5(1, "adult", "monday", 4);
            Assert.Equal(14.50M, cost);
        }
    }
}