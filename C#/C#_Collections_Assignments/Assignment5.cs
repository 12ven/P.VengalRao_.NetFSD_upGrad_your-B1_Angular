namespace C__Collections_Assignments
{
    internal class Assignment5
    {

        class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Disease { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Disease: {Disease}";
            }
        }

        class Program
        {
            static void Main()
            {
                Queue<Patient> patientQueue = new Queue<Patient>();

                // Add 5 patients
                patientQueue.Enqueue(new Patient { Id = 1, Name = "Alice", Disease = "Fever" });
                patientQueue.Enqueue(new Patient { Id = 2, Name = "Bob", Disease = "Cold" });
                patientQueue.Enqueue(new Patient { Id = 3, Name = "Charlie", Disease = "Headache" });
                patientQueue.Enqueue(new Patient { Id = 4, Name = "David", Disease = "Cough" });
                patientQueue.Enqueue(new Patient { Id = 5, Name = "Eva", Disease = "Allergy" });

                Console.WriteLine("--- All Patients in Queue ---");
                foreach (var p in patientQueue)
                    Console.WriteLine(p);

                // Serve (Dequeue) 2 patients
                Console.WriteLine("\n--- Serving 2 Patients ---");
                for (int i = 0; i < 2; i++)
                {
                    if (patientQueue.Count > 0)
                        Console.WriteLine("Served: " + patientQueue.Dequeue());
                }

                // Display next patient
                Console.WriteLine("\n--- Next Patient ---");
                if (patientQueue.Count > 0)
                    Console.WriteLine("Next: " + patientQueue.Peek());

                // Show all remaining patients
                Console.WriteLine("\n--- Remaining Patients ---");
                foreach (var p in patientQueue)
                    Console.WriteLine(p);

                // Bonus: VIP patient handling
                Console.WriteLine("\n--- Adding VIP Patient ---");
                Patient vip = new Patient { Id = 99, Name = "VIP John", Disease = "Critical" };

                // VIP patients should be treated first → use LinkedList for priority
                LinkedList<Patient> priorityQueue = new LinkedList<Patient>(patientQueue);
                priorityQueue.AddFirst(vip);

                Console.WriteLine("\n--- Queue with VIP Priority ---");
                foreach (var p in priorityQueue)
                    Console.WriteLine(p);
            }
        }
    }
}
