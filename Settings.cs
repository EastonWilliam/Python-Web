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
#Command: Save the above code in a file named "Settings.cs" in your project directory.