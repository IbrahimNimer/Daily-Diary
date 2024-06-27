# DailyDiary

This is a console application designed to manage daily diary entries. It provides functionalities to add, delete, read, count, and reset diary entries through a simple interface.

## Purpose of the Program

The purpose of this program is to provide a straightforward way to manage diary entries. Users can add new entries, delete specific entries, read all entries, count the total number of entries, and reset the diary to its original content. This project ensures robust and reliable functionality.

## Instructions on How to Run the Program

1. **Clone or download the repository**: Ensure you have the source code on your local machine.

2. **Open the project**:
   - Use an IDE like Visual Studio or any C# compatible editor to open the project.

3. **Build the project**:
   - Ensure all dependencies are resolved and build the project.

4. **Run the program**:
   - Execute the program by running the `DailyDiary` executable.
   - Alternatively, you can run the program directly from the IDE by pressing `F5` or selecting the "Run" option.

5. **Manage Diary Entries**:
   - You can interact with the program to add, delete, read, count, or reset diary entries.
   - Follow the prompts to perform the desired action.

## Additional Information or Notes

- **Initializing the Diary**:
  - Use the `Initialize` method to load the original content of the diary file.
  - This step is essential for resetting the diary to its original content.

- **Adding Entries**:
  - Use the `AddEntry` method to add a new entry to the diary.
  - Each entry should include a date and content.

- **Deleting Entries**:
  - Use the `DeleteEntries` method to remove specific entries from the diary.
  - Specify the exact content of the entry to be deleted.

- **Reading Entries**:
  - Use the `ReadAllTextMethod` method to read the entire content of the diary.
  - Use the `ReadEntriesByDate` method to read entries for a specific date.

- **Counting Entries**:
  - Use the `CountEntries` method to count the total number of entries in the diary.

- **Resetting the Diary**:
  - Use the `ResetDiary` method to reset the diary file to its original content.
  - This method relies on the initial backup created during the `Initialize` step.

- **Error Handling**:
  - The program is designed to handle invalid inputs gracefully and provide appropriate feedback to the user.

Enjoy managing your daily diary with the DailyDiary application!
