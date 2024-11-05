using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace furdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<adatsor> adatok= new List<adatsor>();
            string[] f = File.ReadAllLines("furdoadat.txt");
            for (int i = 0; i < f.Length; i++)
            {
                adatok.Add(new adatsor(f[i]));

            }

            Console.WriteLine($"2.feladat\nAz első vendég {adatok[0].ora}:{adatok[0].perc}.{adatok[0].masodperc}-kor lépett ki az öltözőből.");
            Console.WriteLine($"Az utolsó vendég ");

            Console.WriteLine($"3. feladat");
            int db =0;
            var azonositokk = adatok.GroupBy(x => x.vendegazonosito).ToList();
            foreach (var a in azonositokk)
            {
                db = 0;
                foreach (var i in adatok)
                {
                    if(a.Key == i.vendegazonosito)
                    {
                        db++;
                    }
                }
            }
            
            Console.WriteLine($"A fűrdőben {azonositokk} vendég járt csak egy részlegen");

            Console.WriteLine("4.feladat");
            int ora = 0;
            int perc = 0;
            int masodperc = 0;
            Console.WriteLine("A legtöbbet eltöltött vendég:");
            for (int i = 0; i < adatok.Count(); i++)
            {
                
            }


            Console.WriteLine("5. feladat");
            Dictionary<string,int>statisztika = new Dictionary<string,int>();
            statisztika.Add("6-9", 0);
            statisztika.Add("9-16", 0);
            statisztika.Add("16-20", 0);
            foreach (var i in adatok)
            {
                if(i.ora>=6 && i.ora < 9)
                {
                    
                }
                else if(i.ora>9 && i.ora < 16)
                {
                    
                }
                else if(i.ora>16 && i.ora < 20)
                {
                    
                }
            }





            List<string> Szauna = new List<string>();
            StreamWriter kiirat = new StreamWriter("szauna.txt");
            foreach (var i in adatok)
            {
                
            }



            Console.WriteLine("7.feladat");
            List<adatsor> hetes= new List<adatsor>();
            Dictionary<string,int>utolsostat= new Dictionary<string,int>();
            utolsostat.Add("Uszoda", 0);
            utolsostat.Add("Szaunák", 0);
            utolsostat.Add("Gyógyvizes medencék", 0);
            utolsostat.Add("Strand", 0);


            















            Console.ReadKey();
        }
    }
}
