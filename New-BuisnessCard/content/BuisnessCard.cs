using System.Collections.Generic;

namespace content
{
    public class BuisnessCardItem 
    {
        public string Label { get; set;  }
        public string Text { get; set; }
        // I could do some fancy regex replace with tokens in the text or I can just have seperate colored properties.
        // Less fancy but 80/20 :shrug:
        public string ColoredLabel { get; set; }
        public string ColoredText { get; set;  }
        public string When { get; set; }
        public string ToColoredString() 
        {
            return $"{Label}: {Text}";
        }
        public override string ToString()
        {
            return $"{Label}: {Text}";
        }
    }
    public static class BuisnessCard
    {
        public static List<BuisnessCardItem> Data = new List<BuisnessCardItem>() 
        {  
            new BuisnessCardItem 
            { 
                Label = "Name", Text = "YourName", When = "YourName"
            },
            new BuisnessCardItem
            {
                Label = "Work", Text = "YourWork", When = "YourWork"
            },
            new BuisnessCardItem
            {
                Label = "Twitter", Text = "https://twitter.com/YourTwitter", When = "YourTwitter"
            },
            new BuisnessCardItem
            {
                Label = "NuGet", Text = "https://www.nuget.org/profiles/YourNuget", When = "YourNuget"
            },
            new BuisnessCardItem
            {
                Label = "GitHub", Text = "https://github.com/YourGithub", When = "YourGithub"
            },
            new BuisnessCardItem
            {
                Label = "LinkedIn", Text = "https://www.linkedin.com/in/YourLinkedin", When = "YourLinkedin"
            },
            new BuisnessCardItem
            {
                Label = "Web", Text = "YourWeb", When = "YourWeb"
            },
            new BuisnessCardItem
            {
                Label = "Card", Text = "dx YourCard", When = "YourCard"
            },

        };
    }
}