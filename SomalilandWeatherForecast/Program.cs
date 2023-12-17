

using System.Buffers;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace SomalilandWeatherForecast
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // see https://aka.ms/applicationconfiguration.
            if (Environment.Is64BitOperatingSystem || Environment.Is64BitProcess)
            {
                
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}