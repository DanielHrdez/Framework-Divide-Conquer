/// Universidad de La Laguna
/// Grado en Ingeniería Informática
/// Diseño y Análisis de Algoritmos
/// <author name="Daniel Hernandez de Leon"></author>
/// <class name="Printer"> Programa para los prints de Divide y Vencerás </class>

using MainProgram;

namespace IO {
  class Printer {
    /// <summary>
    ///   Print the results of the benchmark.
    /// </summary>
    /// <param name="timeResults">The results of the benchmark.</param>
    void PrintResults(object[][] timeResults) {
      Console.WriteLine("{0}", timeResults[0][0]);
      for (int i = 0; i < timeResults.Length; i++) {
        Console.Write("  Time: {0}", timeResults[i][1]);
        Console.WriteLine("  Size: {0}", timeResults[i][2]);
      }
      Console.WriteLine();
      Console.WriteLine("Time Complexity:");
      Console.WriteLine("  " + timeResults[0][3]);
      Console.WriteLine();
    }

    /// <summary>
    ///   Print the title.
    /// </summary>
    /// <param name="title">The title to print.</param>
    public void PrintTitle(string title) {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("{0}", title);
      Console.ResetColor();
    }

    /// <summary>
    ///   Print debugmode
    /// </summary>
    public void DebugMode() {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Debug Mode");
      Console.WriteLine();
      Console.ResetColor();
    }

    /// <summary>
    ///   Print the menu
    /// </summary>
    /// <returns>The algorithm chosen by the user</returns>
    public Constants.Algorithm PrintMenu() {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine("Choose Algorithm:");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("  Merge Sort ➗");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("  Quick Sort 💨");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("  Binary Search 🔍");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("  Hanoi Towers 🗼");
      Console.ResetColor();
      Console.SetCursorPosition(0, Console.CursorTop - 4);
      Console.Write(">");
      Console.SetCursorPosition(0, Console.CursorTop);
      const int MAX = 4;
      int current = 0;
      while(true) {
        switch (Console.ReadKey(true).Key) {
          case ConsoleKey.UpArrow:
            if (current - 1 >= 0) {
              Console.SetCursorPosition(0, Console.CursorTop);
              Console.Write(" ");
              Console.SetCursorPosition(0, Console.CursorTop - 1);
              Console.Write(">");
              Console.SetCursorPosition(0, Console.CursorTop);
              current--;
            }
            break;
          case ConsoleKey.DownArrow:
            if (current + 1 < MAX) {
              Console.SetCursorPosition(0, Console.CursorTop);
              Console.Write(" ");
              Console.SetCursorPosition(0, Console.CursorTop + 1);
              Console.Write(">");
              Console.SetCursorPosition(0, Console.CursorTop);
              current++;
            }
            break;
          case ConsoleKey.Enter:
            Console.SetCursorPosition(0, Console.CursorTop + 5 - current);
            return (Constants.Algorithm) current;
        }
      }
    }
  }
}
