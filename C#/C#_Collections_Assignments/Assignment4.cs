namespace C__Collections_Assignments
{
    internal class Assignment4
    {

        class Program
        {
            static void Main()
            {
                Stack<string> undoStack = new Stack<string>();
                Stack<string> redoStack = new Stack<string>();

                // Push actions
                undoStack.Push("Type A");
                undoStack.Push("Type B");
                undoStack.Push("Delete C");
                undoStack.Push("Type D");
                undoStack.Push("Delete B");

                Console.WriteLine("--- Current Actions in Undo Stack ---");
                foreach (var action in undoStack)
                    Console.WriteLine(action);

                // Undo last 3 actions
                Console.WriteLine("\n--- Undo Last 3 Actions ---");
                for (int i = 0; i < 3 && undoStack.Count > 0; i++)
                {
                    string undone = undoStack.Pop();
                    redoStack.Push(undone); // store undone actions for redo
                    Console.WriteLine($"Undone: {undone}");
                }

                // Peek current top action
                if (undoStack.Count > 0)
                    Console.WriteLine($"\nCurrent Top Action: {undoStack.Peek()}");
                else
                    Console.WriteLine("\nNo actions left in undo stack.");

                // Bonus: Redo last 2 actions
                Console.WriteLine("\n--- Redo Last 2 Actions ---");
                for (int i = 0; i < 2 && redoStack.Count > 0; i++)
                {
                    string redone = redoStack.Pop();
                    undoStack.Push(redone); // reapply action
                    Console.WriteLine($"Redone: {redone}");
                }

                Console.WriteLine("\n--- Final Undo Stack ---");
                foreach (var action in undoStack)
                    Console.WriteLine(action);
            }
        }
    }
}
