using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

                    //TODO: Wykonaj program dla pracodawcy, w którym:
					
                    //1. Możesz dodać pracownika.
                    //Dane pracownika:
                    //Każdego: imię, nazwisko, data urodzenia, miasto, ulica, kod pocztowy, stanowisko(dyrektor, manager, pracownik, asystent), dział, data zatrudnienia, pensja roczna.
                    //Asystenta: telefon służbowy
                    //Dyrketora: Numer pokoju
					
                    //2. Możesz dodać dział.
					//3. Możesz zobaczyć pracowników - wszystkich, o danym nazwisku, z konkretnego działu(wyświetl: imię, nazwisko, dział, stanowisko).
					//4. Możesz zobaczyć hierarchię działu.
					//5. Możesz usunąć pracownika.
					//6. Możesz edytować dane pracownika
					//7. Przy otwarciu programu, jeśli ktoś ma dziś urodziny, wyświetli się powiadomienie.
					//8. Dodatkowe funkcje:

                    //A.Bonus - liczy bonus pracowników (5% rocznej pensji + 1% za każdy przepracowany rok - zaokrąglone do setek) i tworzy raport w pliku.


       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
