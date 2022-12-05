using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        static public int Penjumlahan(int angka1, int angka2)
        {
            return angka1 + angka2;
        }
        static public int Pengurangan(int angka1, int angka2)
        {
            return angka1 - angka2;
        }
        static public int Perkalian(int angka1, int angka2)
        {
            return angka1 * angka2;
        }
        static public float Pembagian(int angka1, int angka2)
        {
            return (float)angka1 / (float)angka2;
        }
    }
}
