using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
namespace ProgramDoBadaniaTrasyPakietow
{
    class sledzeniePakietow
    {
        int TTL;
        int czasOczekiwania;
        byte [] wielkoscBuforu ;
        string adress;
        public string blad;
        public string odpowiedz;
        public bool zakonczPing = false;
        public bool czyNastapilBlad=false;
        public string IPhosta;
        sledzeniePakietow()
        {
            this.TTL = 1;
            this.wielkoscBuforu = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            this.czasOczekiwania = 120;
            this.adress = "127.0.0.1";
            IPhosta = "000.000.000.000";
        }
        public void zmienTTL(int ttl)
        {
            this.TTL = ttl;
        }
        public sledzeniePakietow(int TTL,int czasOczekiwania, byte[] wielkoscBuforu,string adress)
        {
            this.TTL = TTL;
            this.wielkoscBuforu = wielkoscBuforu;
            this.czasOczekiwania = czasOczekiwania;
            this.adress = adress;
            IPhosta = "000.000.000.000";
        }

        public sledzeniePakietow wyslijPing(sledzeniePakietow sledzenie)
        {
            Ping ping = new Ping();
            try
            {
                PingOptions pingOptions = new PingOptions( sledzenie.TTL, true);
                
                PingReply odpowiedz = ping.Send(sledzenie.adress,sledzenie.czasOczekiwania,sledzenie.wielkoscBuforu,pingOptions);
                try
                {
                    sledzenie.IPhosta = odpowiedz.Address.ToString();
                }
                catch
                {
                    sledzenie.IPhosta = "000.000.000.000";
                }
                if (odpowiedz.Status==IPStatus.TtlExpired)
                {
                    sledzenie.odpowiedz = " Ip hosta: " + odpowiedz.Address + " ";
                    return sledzenie;
                }
                if (odpowiedz.Status == IPStatus.Success)
                {
                    sledzenie.odpowiedz = " IP hosta: "+odpowiedz.Address+" ";
                    sledzenie.zakonczPing = true;
                   return sledzenie;
                }
                if(odpowiedz.Status == IPStatus.TimedOut)
                {
                    sledzenie.odpowiedz = " Upłynął limit czasu żądania: " + odpowiedz.Address + " ";
                    return sledzenie;
                }
            }
            catch(Exception ex)
            {
                sledzenie.blad = "Błąd : "+ex.Message;
                sledzenie.czyNastapilBlad = true;
                return sledzenie;
            }
            return sledzenie;
        }
    }


    }

