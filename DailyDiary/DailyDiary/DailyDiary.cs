using System;
using System.IO;

namespace DailyDiary
{
    public class DailyDiary
    {
        private static string originalContentBackup;

        public static void Initialize(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    originalContentBackup = File.ReadAllText(filepath);
                }
                else
                {
                    originalContentBackup = string.Empty;
                    Console.WriteLine("File does not exist: " + filepath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while initializing: " + ex.Message);
            }
        }

        public static void ResetDiary(string filepath)
        {
            try
            {
                if (!string.IsNullOrEmpty(originalContentBackup))
                {
                    File.WriteAllText(filepath, originalContentBackup);
                    Console.WriteLine("Diary file has been reset to original content.");
                }
                else
                {
                    Console.WriteLine("Original content backup is empty or null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while resetting the diary file: " + ex.Message);
            }
        }

        public static void ReadAllTextMethod(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string txtContent = File.ReadAllText(filepath);
                    Console.WriteLine("File content:");
                    Console.WriteLine(txtContent);
                }
                else
                {
                    Console.WriteLine("File does not exist: " + filepath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }

        public static void AddEntry(string filepath, Entry entry)
        {
            try
            {
                string entryText = $"{entry.Date:yyyy-MM-dd}: {entry.Content}\n";

                if (!entryText.EndsWith("\n"))
                {
                    entryText += "\n";
                }

                File.AppendAllText(filepath, entryText);
                Console.WriteLine("Entry added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding the entry: " + ex.Message);
            }
        }

        public static void DeleteEntries(string filepath, string entryContent)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string text = File.ReadAllText(filepath);
                    text = text.Replace(entryContent, "");
                    File.WriteAllText(filepath, text);
                    Console.WriteLine("Entry deleted.");
                }
                else
                {
                    Console.WriteLine("File does not exist: " + filepath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the entry: " + ex.Message);
            }
        }

        public static void CountEntries(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    int count = lines.Length;
                    Console.WriteLine($"Total number of entries: {count}");
                }
                else
                {
                    Console.WriteLine("File does not exist: " + filepath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while counting the entries: " + ex.Message);
            }
        }

        public static void ReadEntriesByDate(string filepath, DateTime date)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    bool entriesFound = false;

                    Console.WriteLine($"Entries for {date:yyyy-MM-dd}:");

                    foreach (var line in lines)
                    {
                        if (line.StartsWith($"{date:yyyy-MM-dd}"))
                        {
                            Console.WriteLine(line);
                            entriesFound = true;
                        }
                    }

                    if (!entriesFound)
                    {
                        Console.WriteLine("No entries found for this date.");
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist: " + filepath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the entries by date: " + ex.Message);
            }
        }
    }
}
