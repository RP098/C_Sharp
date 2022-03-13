using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michelin_Garda_2021
{
    class Zawody
    {
       public int id { get; set; }
       public int available_slots { get; set; }
       public string name { get; set; }
       public string content { get; set; } //opis zawodów
       public string schedule { get; set; } //terminarz data zawodów
       public decimal Entry_fee_outside_the_club { get; set; }
       public decimal Entry_fee_club_member { get; set; }
       
       
    }
}
