using System;
using System.IO;

namespace DailyDiary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, "dailydiary.txt");
            DailyDiary.Initialize(filepath);

            while (true)
            {  

                Console.WriteLine("\nDaily Diary Menu:");
                Console.WriteLine("1. Read all entries");
                Console.WriteLine("2. Add a new entry");
                Console.WriteLine("3. Delete an entry");
                Console.WriteLine("4. Count total entries");
                Console.WriteLine("5. Reset diary to original content backup");
                Console.WriteLine("6. Read entries by date"); 
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DailyDiary.ReadAllTextMethod(filepath);
                        break;
                    case "2":
                        AddNewEntry(filepath);
                        break;
                    case "3":
                        DeleteEntry(filepath);
                        break;
                    case "4":
                        DailyDiary.CountEntries(filepath);
                        break;
                    case "5":
                        ResetDiaryToBackup(filepath);
                        break;
                    case "6":
                        ReadEntriesByDate(filepath);
                        break;
                    case "7":
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private static void AddNewEntry(string filepath)
        {
            Console.Write("Enter the date (YYYY-MM-DD): ");
            string dateInput = Console.ReadLine();
            if (DateTime.TryParse(dateInput, out DateTime date))
            {
                Console.Write("Enter the content: ");
                string content = Console.ReadLine();
                DailyDiary.AddEntry(filepath, new Entry { Date = date, Content = content });
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }

        private static void DeleteEntry(string filepath)
        {
            Console.Write("Enter the content of the entry to delete: ");
            string content = Console.ReadLine();
            DailyDiary.DeleteEntries(filepath, content);
        }

        private static void ResetDiaryToBackup(string filepath)
        {
            Console.WriteLine("Are you sure you want to reset the diary to original backup content?");
            Console.Write("Enter 'yes' to confirm: ");
            string confirm = Console.ReadLine();

            if (confirm.ToLower() == "yes")
            {
                DailyDiary.ResetDiary(filepath);
            }
            else
            {
                Console.WriteLine("Reset operation cancelled.");
            }
        }

        private static void ReadEntriesByDate(string filepath)
        {
            Console.Write("Enter the date (YYYY-MM-DD): ");
            string dateInput = Console.ReadLine();
            if (DateTime.TryParse(dateInput, out DateTime date))
            {
                DailyDiary.ReadEntriesByDate(filepath, date);
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }
    }
}
