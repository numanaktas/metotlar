﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("sepete eklendi: " + urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("sepete eklendi: " + urunAdi);
        }
    }
}
