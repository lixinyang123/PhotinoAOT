using PhotinoNET;
using System.Drawing;
using System.Text;

namespace HelloPhotinoApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] _)
        {
            string windowTitle = "Photino for .NET Demo App";

            var window = new PhotinoWindow()
                .SetTitle(windowTitle)
                .SetUseOsDefaultSize(false)
                .SetSize(new Size(1000, 800))
                .Center()
                .SetResizable(false)
                .RegisterCustomSchemeHandler("app", (object sender, string scheme, string url, out string contentType) =>
                {
                    contentType = "text/javascript";
                    return new MemoryStream(Encoding.UTF8.GetBytes(@"
                        (() =>{
                            window.setTimeout(() => {
                                alert(`🎉 Dynamically inserted JavaScript.`);
                            }, 1000);
                        })();
                    "));
                })
                .RegisterWebMessageReceivedHandler((object? sender, string message) =>
                {
                    PhotinoWindow? window = sender as PhotinoWindow;
                    string response = $"Received message: \"{message}\"";
                    window?.SendWebMessage(response);
                })
                .Load("wwwroot/index.html");

            window.WaitForClose();
        }
    }
}