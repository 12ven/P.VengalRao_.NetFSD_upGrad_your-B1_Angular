using System;

namespace TicketBookingApp
{
    // Custom Exception
    public class TicketNotAvailableException : Exception
    {
        public TicketNotAvailableException(string message) : base(message) { }
    }

    public class TicketBooking
    {
        private static int availableTickets = 15;

        public void BookTickets(int numberOfTickets)
        {
            if (numberOfTickets > availableTickets)
            {
                throw new TicketNotAvailableException("Not enough tickets available! Only " + availableTickets + " left.");
            }
            else
            {
                availableTickets -= numberOfTickets;
                Console.WriteLine($"{numberOfTickets} tickets booked successfully.");
                Console.WriteLine($"Remaining tickets: {availableTickets}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TicketBooking booking = new TicketBooking();

            Console.WriteLine("Do you want to book tickets? (yes/no)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                Console.WriteLine("Enter number of tickets to book:");
                int tickets = int.Parse(Console.ReadLine());

                try
                {
                    booking.BookTickets(tickets);
                }
                catch (TicketNotAvailableException ex)
                {
                    Console.WriteLine("Booking Failed: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Thank you! Visit again.");
            }
        }
    }
}