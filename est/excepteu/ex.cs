// Define a method to format and display the date range for a given day
public static void DisplayDateRange(int dayNumber, DateTime start, DateTime end)
{
    // Format the start and end dates as short date strings
    string formattedStart = start.ToShortDateString();
    string formattedEnd = end.ToShortDateString();

    // Construct the message with the formatted dates
    string message = $"START day {dayNumber} - start: {formattedStart} - end: {formattedEnd}";

    // Output the message to the console
    Console.WriteLine(message);
}

// Example usage:
// Assuming 'i', 'startDate', and 'endDate' are defined with appropriate values
DisplayDateRange(i, startDate, endDate);
