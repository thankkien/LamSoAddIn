namespace LamSoAddIn.Model
{
    class PrinterProperty
    {
        public static int limitNumberRow = 10;
        public static int FromPage { get; set; }
        public static int ToPage { get; set; }
        public static int Copies { get; set; }
        public static bool Preview { get; set; }
        public static string ActivePrinter { get; set; }
        public static int Collate { get; set; }
    }
}
