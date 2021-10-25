using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, ILoggerService loggerService)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
            loggerService.Log();
        }
    }
}
