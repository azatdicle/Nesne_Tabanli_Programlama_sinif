using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    public class Ucgen //Heryerden erişilebilir sınıf
    {
        int a;
        int b;
        int c;
        


        public int kenar1 { get; set; } //Hızlı bir şekilde oluşturma


        public int A { //A sınıfı oluşturuldu 
            // Get ve set veri gönderip almak için kullanılır.
            get
            {
                return A; //Veri göndermek
            } 
             set
            {
                a= value; //Veri almak
            }
        }
        public int B
        { //A sınıfı oluşturuldu 
            // Get ve set veri gönderip almak için kullanılır.
            get
            {
                return B; //Veri göndermek
            }
            set
            {
                b = value; //Veri almak
            }
        }
        public int C
        { //A sınıfı oluşturuldu 
            // Get ve set veri gönderip almak için kullanılır.
            get
            {
                return C; //Veri göndermek
            }
            set
            {
                c = value; //Veri almak
            }
        }
    }
}
