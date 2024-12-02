using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShowPlaces__OOP_
{
    internal class Place
    {
        public string PlaceName;
        public string Municipality;
        public string Region;

        public Place(string placeName, string municipality, string region)
        {
            PlaceName = placeName;
            Municipality = municipality;
            Region = region;
        }

        public void ShowPlace()
        {
            int labelWidth = 8;
            ShowSeparatorRow();
            ShowFieldNameAndValue("Navn", labelWidth, PlaceName);
            ShowFieldNameAndValue("Komune", labelWidth, Municipality);
            ShowFieldNameAndValue("Fylke", labelWidth, Region);
            ShowSeparatorRow();
        }

        void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine($"  {label}:{String.Empty.PadLeft(labelWidth, ' ')}{fieldValue}");
        }

        void ShowSeparatorRow()
        {
            Console.WriteLine(String.Empty.PadRight(20, '*'));
        }
    }
}
