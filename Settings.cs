Namespace MyApp
{
    public class Settings
    {
        public string DatabaseConnectionString { get; set; }
        public int MaxItemsToDisplay { get; set; }
        public bool EnableLogging { get; set; }
        public Settings()
        {
            // Default values
            DatabaseConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;";
            MaxItemsToDisplay = 100;
            EnableLogging = true;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Settings appSettings = new Settings();
        Console.WriteLine("Database Connection String: " + appSettings.DatabaseConnectionString);
        Console.WriteLine("Max Items to Display: " + appSettings.MaxItemsToDisplay);
        Console.WriteLine("Enable Logging: " + appSettings.EnableLogging);
    }
}

public class Settings
{
    public string DatabaseConnectionString { get; set; }
    public int MaxItemsToDisplay { get; set; }
    public bool EnableLogging { get; set; }
    public Settings()
    {
        // Default values
        DatabaseConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;";
        MaxItemsToDisplay = 100;
        EnableLogging = true;
    }
}