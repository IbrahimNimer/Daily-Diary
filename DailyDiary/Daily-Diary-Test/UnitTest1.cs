using System;
using System.IO;
using Xunit;
using DailyDiary; // Assuming DailyDiary namespace contains relevant classes and methods

namespace Daily_Diary_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_ReadAllTextMethod()
        {
            // Arrange
            string filepath = Path.Combine(Environment.CurrentDirectory, "dailydiary.txt");
            string expectedContent = "2024-06-26: First entry\n";
            File.WriteAllText(filepath, expectedContent);

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                DailyDiary.DailyDiary.ReadAllTextMethod(filepath); // Adjust this based on your actual implementation
                var result = sw.ToString().Trim();

                // Assert
                Assert.Contains(expectedContent.Trim(), result);
            }
        }

        [Fact]
        public void Test_AddEntry_IncreasesEntryCount()
        {
            // Arrange
            string filepath = Path.Combine(Environment.CurrentDirectory, "dailydiary.txt");
            if (File.Exists(filepath))
            {
                File.Delete(filepath); // Ensure the file is fresh for each test
            }
            DateTime date1 = DateTime.Parse("2024-06-26");
            DateTime date2 = DateTime.Parse("2024-06-27");

            // Act
            DailyDiary.DailyDiary.AddEntry(filepath, new DailyDiary.Entry { Date = date1, Content = "First entry" });
            int initialCount = File.ReadAllLines(filepath).Length;

            DailyDiary.DailyDiary.AddEntry(filepath, new DailyDiary.Entry { Date = date2, Content = "Second entry" });
            int finalCount = File.ReadAllLines(filepath).Length;

            // Assert
            Assert.Equal(initialCount + 1, finalCount);
        }
    }
}
