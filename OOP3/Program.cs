using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler kendini implement eden sınıfların adresini tutabilir
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
           // ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
           // tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            ILoggerService database = new DatabaseLoggerService();
            ILoggerService file = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerService> logger = new List<ILoggerService> { database, file };
           // basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> {database,file});
            basvuruManager.BasvuruYap(ihtiyacKrediManager, logger);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
