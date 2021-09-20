using System.IO;


namespace AcademyI.Week1.Text
{
    static class Write
    {
        public static void WriteToFile()
        {
            const string path = @"C:\Users\arian\Desktop\AcademyI.Week1\Prova.txt";


            // Metodo 1 con dispose
            //StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("Ciao questa è una prova di scrittura su file");
            //sw.Close();
            //sw.Dispose();


            using (StreamWriter sw1 = new StreamWriter(path))
            {
                sw1.WriteLine("Questa è la mia prima riga");
            }

            using (StreamWriter sw2 = new StreamWriter(path, true))
            {
                sw2.WriteLine("Questa è la mia seconda riga");
            }
        }
    }
}
