using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cevre
{
    public class sayibulucu
    {
                                //Varsayılan olmayan parametreler  en önde olamlı
        public int BuyukOlaniBul(int c ,int sayi1 = 0,int sayi2=0)
        {
            int sonuc;
            if (sayi1 > sayi2)
            {
                sonuc = 1;
            }
            else if (sayi1 == sayi2)
            {
                sonuc = 0;
            }
            else 
            {
                sonuc = sayi2;
            }
            return sonuc;
        }
    }
}
