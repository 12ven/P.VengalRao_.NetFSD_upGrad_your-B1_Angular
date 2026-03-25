namespace C__Collections_Assignments
{
    internal class Assignment3
    {

        class Program
        {
            static void Main()
            {
                HashSet<string> eventRegistrations = new HashSet<string>();

                // Add 10 emails (with duplicates)
                string[] emails = {
            "alice@example.com", "bob@example.com", "charlie@example.com",
            "david@example.com", "eva@example.com", "frank@example.com",
            "alice@example.com", "bob@example.com", "george@example.com",
            "helen@example.com"
        };

                foreach (var email in emails)
                    eventRegistrations.Add(email);

                Console.WriteLine("--- Unique Registered Emails ---");
                foreach (var email in eventRegistrations)
                    Console.WriteLine(email);

                Console.WriteLine("\n--- Check if a specific email is registered ---");
                string checkEmail = "charlie@example.com";
                Console.WriteLine(eventRegistrations.Contains(checkEmail)
                    ? $"{checkEmail} is registered."
                    : $"{checkEmail} is not registered.");

                Console.WriteLine("\n--- Remove an email (bob@example.com) ---");
                eventRegistrations.Remove("bob@example.com");
                foreach (var email in eventRegistrations)
                    Console.WriteLine(email);

                Console.WriteLine("\n--- Bonus: Compare two event lists ---");
                HashSet<string> anotherEvent = new HashSet<string>
        {
            "charlie@example.com", "eva@example.com", "mike@example.com", "helen@example.com"
        };

                var commonParticipants = eventRegistrations.Intersect(anotherEvent);

                Console.WriteLine("Common Participants:");
                foreach (var email in commonParticipants)
                    Console.WriteLine(email);
            }
        }

    }
}
