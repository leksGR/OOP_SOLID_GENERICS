using SOLID_4;

class Program
{
    static void Main(string[] args)
    {
        IPrinter printer = new Printer();
        IPrinterScaner printerScaner = new PrinterScaner();
        printer.Print("Документ для печати на простом принтере");
        printerScaner.Print("Документ для печати на многофункциональном принтере");
        printerScaner.Scan("Документ для сканирования на многофункциональном принтере");
    }
}

