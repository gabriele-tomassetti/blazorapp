using Microsoft.JSInterop;

namespace BlazorApp
{    
    public class Simple 
    {            
        public string Text { get; set; }
        public Simple(string text)
        {
            Text = text;
        }
        [JSInvokable]
        public string ToUpper()
        {
            return Text.ToUpper();
        }
    }
    
    public class Util
    {
        [JSInvokable]
        public static string RememberTheTruth(string text)
        {
            int start = 0;
        
            while(text.IndexOf("JavaScript", start) != -1)
            {                
                start = text.IndexOf("JavaScript", start) + 10;
                if((text.Length > start + 4 && text.Substring(start+2, 2) != "C#") ||
                   text.Length < start + 4)
                    text = text.Insert(start, " (C# is better)");
            }

            return text;
        }        
    }
}