﻿using System;

namespace degiskenn
{
    class Program
    {
        static void Main(string[] args)
        {
        //     int deger=2;
        //   string degisken= null; 
        //   string Degisken= null;
        //   string degisken= null;
        //     Console.WriteLine(deger);
        
        
        // byte b=5;// 1 byte
        // sbyte c=5; //1 byte
        
        // short s=5; // 2 byte
        // ushort us=5; //2 byte
        
        // Int16 i16=2;  // 2 byte
        // int i=2;       //4 byte
        // int32 i32=2;   // 4 byte
        // int64 i64=2;   //8 byte
         
         uint ui=2;  //4 byte
         long l=4; //8 byte
         ulong ul=4; //8 byte

        float f= 5; //4 byte
        double d=5; //8 byte
        decimal de=5; //16 byte

        char c='2'; //2 byte
        string str="Zikriye"; //sınırsız

        bool b1= true;
        bool b2= false;

        DateTime dt=DateTime.Now;
        Console.WriteLine(dt);
        
        object o1="x";
        object o2="y";
        object o3=4;
        object o4=4.3;

        //string ifadeler

        string str1=string.Empty;
        str1="Kadir Biçer";
        string ad="Kadir";
        string soyad="Bicer";
        string adsoyad=ad + " " + soyad;
        Console.WriteLine(adsoyad);
        
        //integer tanımlama şekilleri
        int integer1=5;
        int integer2=3;
        int integer3= integer1+integer2;

        // boolean
        bool bool1=10>2;

        //Değişken Dönüşümleri;

        string str20="20";
        int int20=20;

        string yeniDeger= str20+int20.ToString();
        Console.WriteLine(yeniDeger); // Çıktısı 2020

        int int21= int20+ Convert.ToInt32(str20);
        Console.WriteLine(int21); // Çıktısı 40
    
        
        string datetime=DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);
        
         }
    }
}
