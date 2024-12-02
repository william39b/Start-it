using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowPlaces__Static_
{
    internal class Place
    {
        public static void ShowPlace(string place, string municipality, string region)
        {
            int labelWidth = 8;
            ShowSeparatorRow();
            ShowFieldNameAndValue("Navn", labelWidth, place);
            ShowFieldNameAndValue("Komune", labelWidth, municipality);
            ShowFieldNameAndValue("Fylke", labelWidth, region);
            ShowSeparatorRow();
        }

        static void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine($"  {label}:{String.Empty.PadLeft(labelWidth, ' ')}{fieldValue}");
        }

        static void ShowSeparatorRow()
        {
            Console.WriteLine(String.Empty.PadRight(20, '*'));
        }
    }
}
