using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtitacKrediManager();//referans verildi
            IKrediManager tasitKrediManager = new TasitKrediManager();//referans verildi
            IKrediManager konutKrediManager = new KonutKrediManager();//referans verildi

            ILoggerService databaeLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();//buraya database logger ide referans olarak verebilirdik

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, databaeLoggerService); 
            //basvuruManager.BasvuruYap(konutKrediManager,new DataBaseLoggerService());       //referansı bu şekilde de verebilirsin 

            List<IKrediManager> krediler =  new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
           
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
