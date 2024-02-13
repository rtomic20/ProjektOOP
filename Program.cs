namespace ProjektOOP
{
    public static class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormaPrijava formaZaUnosNaloga = new FormaPrijava();
            Application.Run(formaZaUnosNaloga);
        }
    }
}
