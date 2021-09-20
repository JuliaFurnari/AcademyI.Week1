using System.IO;


namespace AcademyI.Week1.Text
{
    static class Read
    {
        public static void ReadFromFile()
        {
            const string path = @"C:\Users\arian\Desktop\AcademyI.Week1\Prova.txt";

            // Metodo 1

            //StreamReader sr = new StreamReader(path);
            //string contenutoFIle = sr.ReadToEnd();
            //sr.Close();
            //sr.Dispose()

            // Lettura dell'intero file
            using(StreamReader sr = new StreamReader(path))
            {
                string contenuto = sr.ReadToEnd();
            }

            // Lettura della singola riga

            string contenutoPrimaRiga = string.Empty;

            using (StreamReader sr1 = new StreamReader(path))
            {
                contenutoPrimaRiga = sr1.ReadLine();
            }

            var parole = contenutoPrimaRiga.Split(" ");

        }
    }
}
