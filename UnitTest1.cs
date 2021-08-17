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
        public void Adult_Before_5()
        {
            decimal cost = _app.Adult_Before_5(1, "adult", "monday", 4);
            Assert.Equal(14.50M, cost);
        }

        /* [Theory]
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
         }
        public static IEnumerable<object[]> TestData()//option 2
        {
            yield return new object[] { 15, new decimal[] { 10, 5 } };
            yield return new object[] { 15, new decimal[] { 5, 5, 5 } };
            yield return new object[] { -15, new decimal[] { -10, -30, 20, 5 } };
        }*/
    }
}