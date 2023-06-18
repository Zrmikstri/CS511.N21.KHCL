namespace MoMo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            ApplicationConfiguration.Initialize();
            Main main = new Main();
            StackNavigation.Push(main);
            Application.Run(main);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}