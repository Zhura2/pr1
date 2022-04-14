using System;
using System.Collections.Generic;
using System.Text;

namespace pr1
{
    class Kvitancia
    {
        public int Nomer { get; set; }
        public string Data { get; set; }
        public float Summa { get; set; }
        public Kvitancia()
        {
            Nomer = 0;
            Data = "";
            Summa = 0;
        }
    public Kvitancia(int nomer, string data, float summa)
    {
        this.Nomer = nomer;
        this.Data = data;
        this.Summa = summa;
    }

}
}

