using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michelin_Garda_2021
{
    class konkurencje
    {
        public int id { get; set; }
        public string name { get; set; }
        public string competition_code { get; set; }
        public string  content { get; set; } //opis
        public enum used_weapon {własna,klubowa, dowolna }
        public string weapon { get; set; }
        public int available_slots { get; set; }
        public decimal own_weapon_tariff_a  {get; set; }
        public decimal own_weapon_tariff_b  {get; set; }
        public decimal club_weapon_tariff_a { get; set; }
        public decimal club_weapon_tariff_b { get; set; }





    }
}
