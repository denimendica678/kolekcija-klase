﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktičnaUpotrebaKolekcije
{
    class Brkovi
    {
        string pod1, pod2, dodatak;
        int pod3;
        char pod4;

        public string Pod1 { get => pod1; set => pod1 = value; }
        public string Pod2 { get => pod2; set => pod2 = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }
        public int Pod3 { get => pod3; set => pod3 = value; }
        public char Pod4 { get => pod4; set => pod4 = value; }

        public Brkovi()
        {
        }

        public Brkovi(string pod1, string pod2, int pod3, char pod4)
        {
            this.pod1 = pod1;
            this.pod2 = pod2;
            this.pod3 = pod3;
            this.pod4 = pod4;
        }

        override public string ToString()
        {
            string ispis = pod1 + "\t\t" + Pod2 + "\t\t" 
                             + Convert.ToString(pod3) + "\t\t" + pod4 
                             + "\t\t" + Dodatak + "\r\n";

            return ispis;
        }

        


    }
}
