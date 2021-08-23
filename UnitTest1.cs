using System;
using System.Collections.Generic;
using Xunit;

namespace CinemaApp
{
    public class PriceTicketTest
    {
        //Creating an instance of TicketPriceController from CinemaApp.cs called _app
        private readonly TicketPriceController _app;

        public PriceTicketTest()
        {   //Arrange
            _app = new TicketPriceController();
        }

        [Theory]
        [InlineData(14.50, 1, "adult", "thursday", 4.00)]
        [InlineData(14.50, 1, "adult", "thursday", 4.00)]
        [InlineData(14.50, 1, "adult", "thursday", 4.00)]
        [InlineData(14.50, 1, "adult", "thursday", 4.00)]
        [InlineData(14.50, 1, "adult", "thursday", 4.00)]
        public void Adult_Before_5_Price(decimal expectd, int ticket_quanity, string customer_type, string date, decimal time)
        {
            //Act
            decimal cost = _app.Adult_Before_5(ticket_quanity, customer_type, date, time);
            //Assert
            Assert.Equal(expectd, cost);
        }
    }
}