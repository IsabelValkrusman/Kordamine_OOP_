﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_OOP_1
{
    class Opilane : Isik
    {
        public string? koolinimi;
        public int klass;
        public string? spetsialiseerumine;
        public double taskuraha;
        public List<string> haridus;
        public Dictionary<string, List<int>> hinded;
       

        public Opilane()
        {
            this.haridus = new List<string>();
            hinded = new Dictionary<string, List<int>>();
        }

        public Opilane(string koolinimi, int klass, string spetsialiseerumine, double taskuraha, List<string> haridus)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
            this.taskuraha = taskuraha;
            this.haridus = haridus;
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            return taskuraha;
        }

       

        public void eriala(string koolieriala)
        {
            haridus.Add(koolieriala);
        }
        

        public void lisaAine(string aine)
        {   
            // vaatame, kas Dictionary hinded ei sisalda ainet
            // kui samanimelist ainet pole, siis lisame selle, vastasel juhul ei tee midagi
            if (!hinded.ContainsKey(aine)) {
                hinded.Add(aine, new List<int>());
            }
        }

        public void eemaldaAine(string aine)
        {   // vaatame, kas Dictionarys on olemas antud nimega aine, kui on, siis eemaldame selle, vastasel juhul ei tee midagi
            if(hinded.ContainsKey(aine))
            {
                hinded.Remove(aine);
            }
        }

        public void lisaHinne(string aine, int hinne)
        {
            // vaatame, kas dictionaris on olemas antud aine
            if (hinded.ContainsKey(aine)) {
                // kui aine on olemas, siis saame väärtuse ning lisame hinde
                List<int> aineHinded = hinded[aine];
                aineHinded.Add(hinne);
            }
            // vastasel juhule ei tee midagi
        }


        public void vaataHinded()
        {
            foreach (var item in hinded)
            {
                Console.WriteLine("---");
                Console.WriteLine(item.Key);
                Console.WriteLine(string.Join(",",item.Value));
                Console.WriteLine("---");
            }
        }
        public void vaataHindedAineKohta(string aine)
        {
            if(hinded.ContainsKey(aine))
            {
                Console.WriteLine("---");
                Console.WriteLine(aine);
                Console.WriteLine(string.Join(",", hinded[aine]));
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("ainet ei leitud");
            }
            
        }
        

    }
}
