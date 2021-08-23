using System;
using System.Collections.Generic;
using Xunit;
using CinemaApp;

namespace CinemaApp.Test
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
        [InlineData(29.00, 2, "adult", "friday", 2.00)]
        [InlineData(-1, 1, "adult", "tuesday", 3.00)]
        [InlineData(-1, 1, "student", "monday", 6.00)]
        [InlineData(-1, 0, "adult", "monday", 4.00)]
        public void Adult_Before_5_Check(decimal expectd, int ticket_quanity, string customer_type, string date, decimal time)
        {
            //Act
            decimal cost = _app.Adult_Before_5(ticket_quanity, customer_type, date, time);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(17.50, 1, "adult", "monday", 6.00)]
        [InlineData(35.00, 2, "adult", "friday", 5.30)]
        [InlineData(-1, 1, "adult", "tuesday", 3.00)]
        [InlineData(-1, 1, "student", "monday", 4.00)]
        [InlineData(-1, 0, "adult", "monday", 7.00)]
        public void Adult_After_5_Check(decimal expectd, int ticket_quanity, string customer_type, string date, decimal time)
        {
            //Act
            decimal cost = _app.Adult_After_5(ticket_quanity, customer_type, date, time);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(13.00, 1, "adult", "tuesday")]
        [InlineData(26.00, 2, "adult", "tuesday")]
        [InlineData(-1, 1, "student", "tuesday")]
        [InlineData(-1, 1, "adult", "monday")]
        [InlineData(-1, 0, "adult", "monday")]
        public void Adult_Tuesday_Check(decimal expectd, int ticket_quanity, string customer_type, string date)
        {
            //Act
            decimal cost = _app.Adult_Tuesday(ticket_quanity, customer_type, date);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(12.00, 1, "child")]
        [InlineData(24.00, 2, "child")]
        [InlineData(-1, 2, "student")]
        [InlineData(-1, 2, "adult")]
        [InlineData(-1, 0, "adult")]
        public void Child_Under_16_Check(decimal expectd, int ticket_quanity, string customer_type)
        {
            //Act
            decimal cost = _app.Child_Under_16(ticket_quanity, customer_type);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(12.50, 1, "senior")]
        [InlineData(25.00, 2, "senior")]
        [InlineData(-1, 2, "student")]
        [InlineData(-1, 2, "adult")]
        [InlineData(-1, 0, "senior")]
        public void Senior_Check(decimal expectd, int ticket_quanity, string customer_type)
        {
            //Act
            decimal cost = _app.Senior(ticket_quanity, customer_type);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(14.00, 1, "student")]
        [InlineData(28.00, 2, "student")]
        [InlineData(-1, 2, "senior")]
        [InlineData(-1, 2, "adult")]
        [InlineData(-1, 0, "student")]
        public void Student_Check(decimal expectd, int ticket_quanity, string customer_type)
        {
            //Act
            decimal cost = _app.Student(ticket_quanity, customer_type);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(46.00, 1, 2, 2)]
        [InlineData(92.00, 2, 2, 6)]
        [InlineData(-1, 2, 2, 1)]
        [InlineData(-1, 2, 2, 3)]
        [InlineData(-1, 0, 2, 2)]
        public void Family_Pass_Check(decimal expectd, int ticket_quanity, int number_adult, int number_child)
        {
            //Act
            decimal cost = _app.Family_Pass(ticket_quanity, number_adult, number_child);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(21.50, 1, "adult", "thursday")]
        [InlineData(43.00, 2, "adult", "thursday")]
        [InlineData(-1, 2, "student", "thursday")]
        [InlineData(-1, 2, "adult", "wednesday")]
        [InlineData(-1, 0, "adult", "thursday")]
        public void Chick_Flick_Check(decimal expectd, int ticket_quanity, string customer_type, string date)
        {
            //Act
            decimal cost = _app.Chick_Flick_Thursday(ticket_quanity, customer_type, date);
            //Assert
            Assert.Equal(expectd, cost);
        }

        [Theory]
        [InlineData(-1, 2, "wednesday", true)]
        [InlineData(12.00, 1, "wednesday", false)]
        [InlineData(24.00, 2, "wednesday", false)]
        [InlineData(-1, 1, "wednesday", true)]
        [InlineData(-1, 0, "wednesday", true)]
        public void Kids_Career_Check(decimal expectd, int ticket_quanity, string date, bool isHoliday)
        {
            //Act
            decimal cost = _app.Kids_Careers(ticket_quanity, date, isHoliday);
            //Assert
            Assert.Equal(expectd, cost);
        }
    }
}