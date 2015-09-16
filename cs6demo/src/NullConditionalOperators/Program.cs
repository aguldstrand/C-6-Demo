using System;

namespace NullConditionalOperators
{
    public class Program
    {
        public void Main(string[] args)
        {
            StartPage startPage = null;

            Console.WriteLine(startPage.Settings.Categories[10].Name);

            // Console.WriteLine(startPage?.Settings?.Categories?[10]?.Name);
        }
    }

    class StartPage
    {
        public SettingsPage Settings { get; }
    }

    class SettingsPage
    {
        public Category[] Categories { get; }
    }

    class Category
    {
        public string Name { get; }
    }

}
