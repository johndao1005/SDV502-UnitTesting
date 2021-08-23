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
        [MemberData(nameof(TestData))]
        public void Adult_Before_5(decimal expectd, int ticket_quanity, string customer_type, string date, decimal time)
        {
            //Act
            decimal cost = _app.Adult_Before_5(ticket_quanity, customer_type, date, time);
            //Assert
            Assert.Equal(expectd, cost);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 14.50, 1, "adult", "thursday", 4.00 };
        }

        /*[Theory]
        [InlineData(13, 5, 8)]
        [InlineData(0, -3, 3)]
        [InlineData(0, 0, 0)]
        [MemberData(nameof(TestData))] option 2
         public void Add2NumberAndCompareToResultTheory(decimal expected, params decimal[] valuesToAdd)
        {
            foreach (var value in valuesToAdd)
            {
                _app.Add(value);
            }
            Assert.Equal(expected, _app.Value);
        }*/
    }
}