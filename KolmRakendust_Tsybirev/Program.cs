namespace KolmRakendust_Tsybirev
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}