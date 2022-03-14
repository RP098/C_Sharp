using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SautinSoft;
namespace Michelin_Garda_2021
{
    public partial class Zarzadzanie : Form
    {

        static bool pom=true;
        public List<users> users1 { get; set; }

        List<Zawody> zawodies { get; set; }
        List<konkurencje> konkurencjes { get; set; }
        public List<users> kopiaUsers;
        List<Sedziowie> sedziowies { get; set; }
        List<KonkurencjeWZawodach> konkurencjeWZawodaches { get; set; }
        List<Wyniki> wynikis { get; set; }
        private  List<users> Anuluj()
        {
          
            if (pom)
            {
                pom = false;
                readUser read1 = new readUser();
                kopiaUsers = read1.pokazUzytkownikow();
                return kopiaUsers;
                
            }
            else
            {
               
                return kopiaUsers;
            }
        }

        public Zarzadzanie()
        {
            InitializeComponent();
           
            tabControl1.SelectTab(crudUser);
            readUser read = new readUser();
            users1 = read.pokazUzytkownikow();
            readZawody readZawody = new readZawody();
            zawodies = readZawody.pokazZawody();
            readKonkurencja read1 = new readKonkurencja();
            konkurencjes = read1.pokaz();

            readJudges read2 = new readJudges();
            sedziowies = read2.pokaz();

            readKonkurencjaWZawodach readKonkurencjaWZawodach = new readKonkurencjaWZawodach();
            konkurencjeWZawodaches = readKonkurencjaWZawodach.pokaz();

            dataGridView1.DataSource = users1;
            dataGridView1.Font = new System.Drawing.Font("Arial", 20);
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.RowHeadersWidth = 100;


            dataGridView2.DataSource = zawodies;
            dataGridView2.Font = new System.Drawing.Font("Arial", 20);
            dataGridView2.RowHeadersWidth = 100;
            dataGridView5.DataSource = konkurencjes;
            dataGridView5.Columns[2].Visible = false;
            dataGridView5.Columns[4].Visible = false;
            dataGridView5.Columns[5].Visible = false;
            dataGridView6.DataSource = zawodies;
            dataGridView6.Columns[1].Visible = false;
            dataGridView6.Columns[4].Visible = false;
            dataGridView6.Columns[5].Visible = false;
            dataGridView6.Columns[6].Visible = false;
            dataGridView3.DataSource = konkurencjes;
            dataGridView3.Font = new System.Drawing.Font("Arial", 20);
            dataGridView3.RowHeadersWidth = 100;

            dataGridView4.DataSource = sedziowies;
            dataGridView4.Font = new System.Drawing.Font("Arial", 20);
            dataGridView4.RowHeadersWidth = 100;

            dataGridView7.DataSource = konkurencjeWZawodaches;
           
            dataGridView7.RowHeadersWidth = 100;
            readZawody read3 = new readZawody();
            var pom = read3.pokazZawody();
            foreach (var d in pom )
                wybraneZawody.Items.Add(d.name);


            readWyniki read4 = new readWyniki();

            wynikis = read4.pokaz();
            dataGridView8.DataSource = wynikis;
            dataGridView8.Font = new System.Drawing.Font("Arial", 20);
            dataGridView8.RowHeadersWidth = 100;
            dataGridView8.Columns[0].Visible = false;
            dataGridView8.Columns[1].Visible = false;
            dataGridView8.Columns[2].Visible = false;
            dataGridView8.Columns[3].Visible = false;
            dataGridView8.Columns[4].Visible = false;
            dataGridView8.Columns[6].Visible = false;
            dataGridView8.Columns[12].Visible = false;

        }
       

        private void zarzadzanieZawodami_Click(object sender, EventArgs e)
        {
            
        }

        private void zarzadzanieUzytkownikami_Click(object sender, EventArgs e)
        {
         
        
        }

        private void eksportImport_Click(object sender, EventArgs e)
        {
           
        }

        private void Zarzadzanie_Load(object sender, EventArgs e)
        {
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            



        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz anulować zmiany???");

            potwierdzenie.ShowDialog();
            users users = new users();
            if (potwierdzenie.tak_zmien)
            {

                try
                {
                    for (int i = 0; i < kopiaUsers.Count; i++)
                    {

                        users.id = kopiaUsers[i].id;
                        users.name = kopiaUsers[i].name;
                        users.email = kopiaUsers[i].email;
                        users.password = kopiaUsers[i].password;
                        updateUserInBaza userInBaza = new updateUserInBaza();
                        if (!userInBaza.ZmienDane(users.id, users.name, users.email, users.password))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }
                    }
                  
                    MessageBox.Show("Anulowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }
             


                dataGridView1.DataSource = kopiaUsers;
            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz usunąć wyświetlone dane???");

            potwierdzenie.ShowDialog();

            if (potwierdzenie.tak_zmien)
            {
                potwierdzenie.Close();
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {



                        DeleteUserInBaza userInBaza = new DeleteUserInBaza();
                        if (!userInBaza.UsunUsera(Convert.ToInt32(row.Cells[0].Value)))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }


                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }

            }
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz zmienić wyświetlone dane???");

            potwierdzenie.ShowDialog();
            users users = new users();
            if (potwierdzenie.tak_zmien)
            {
                
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {



                        users.id = Convert.ToInt32(row.Cells[0].Value);
                        users.name = row.Cells[1].Value.ToString();
                        users.email = row.Cells[2].Value.ToString();
                        users.password = row.Cells[3].Value.ToString();
                        updateUserInBaza userInBaza = new updateUserInBaza();
                        if (!userInBaza.ZmienDane(users.id, users.name, users.email, users.password))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }

                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }

            }
           
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            DodajUzytkownika dodaj = new DodajUzytkownika();

            dodaj.Show();

        }
        int coZaznaczone()
        {
            if (Id.Checked)
                return 0;

            if (nazwa.Checked)
                return 1;
            if (email.Checked)
                return 2;

            return 1;
        }

        private void szukaj_Click(object sender, EventArgs e)
        {
            try
            {
                readUser read = new readUser();
                users1 = read.pokazUzytkownikow();
                List<users> useryNowe = new List<users>();
                switch (coZaznaczone())
                {
                    case 0:
                        foreach (var d in users1)
                        {
                            if (d.id == Convert.ToInt32(textBox1.Text.Trim()))
                                useryNowe.Add(d);

                        }

                        ;
                        break;
                    case 1:
                        foreach (var d in users1)
                        {
                            if (d.name.Contains(textBox1.Text.Trim()))
                                useryNowe.Add(d);

                        };
                        break;
                    case 2:
                        foreach (var d in users1)
                        {
                            if (d.email.Contains(textBox1.Text.Trim()))
                                useryNowe.Add(d);

                        };
                        break;


                }
                users1 = useryNowe;
                dataGridView1.DataSource = users1;
            }
            catch
            {

                MessageBox.Show("Wystąpił Błąd");
            }
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                readUser read = new readUser();
                users1 = read.pokazUzytkownikow();


                dataGridView1.DataSource = users1;
            }
        }

        private void odswierz_Click(object sender, EventArgs e)
        {
            readUser read = new readUser();
            users1 = read.pokazUzytkownikow();


            dataGridView1.DataSource = users1;
        }

        private void Wybierz_Zawody_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void wyniki_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodajZawody dodaj = new DodajZawody();
            dodaj.Show();

        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        int coZaznaczoneZawody()
        {
            if (radioButton3.Checked)
                return 0;
             
            return 1;


        }
        private void button5_Click(object sender, EventArgs e)// szukaj button zawody
        {
            readZawody read = new readZawody();
            zawodies = read.pokazZawody();
            List<Zawody> Nowe = new List<Zawody>();
            try
            {
                switch (coZaznaczoneZawody())
                {
                    case 0:
                        foreach (var d in zawodies)
                        {
                            if (d.id == Convert.ToInt32(textBox2.Text.Trim()))
                                Nowe.Add(d);

                        }

                    ;
                        break;
                    case 1:
                        foreach (var d in zawodies)
                        {
                            if (d.name.Contains(textBox2.Text.Trim()))
                                Nowe.Add(d);

                        };
                        break;

                }
                zawodies = Nowe;

                dataGridView2.DataSource = zawodies;
            }
            catch
            {
                MessageBox.Show("Wystąpił Błąd");

            }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1)
            {
                readZawody read = new readZawody();
                zawodies = read.pokazZawody();


                dataGridView2.DataSource = zawodies;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //odświerz Zawody
        {
            readZawody read = new readZawody();
            zawodies = read.pokazZawody();


            dataGridView2.DataSource = zawodies;
        }

        private void button4_Click(object sender, EventArgs e)//update zawody
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz zmienić wyświetlone dane???");

            potwierdzenie.ShowDialog();
            Zawody zawody = new Zawody();

            if (potwierdzenie.tak_zmien)
            {

               try
             {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {



                        zawody.id = Convert.ToInt32(row.Cells[0].Value);
                        zawody.available_slots = Convert.ToInt32(row.Cells[1].Value.ToString());
                        zawody.name = row.Cells[2].Value.ToString();
                        zawody.content = row.Cells[3].Value.ToString();
                        zawody.schedule = row.Cells[4].Value.ToString();
                        zawody.Entry_fee_outside_the_club = Convert.ToDecimal(row.Cells[5].Value);
                        zawody.Entry_fee_club_member= Convert.ToDecimal(row.Cells[6].Value);
                        updateZawodyInBaza updateZawodyIn = new updateZawodyInBaza();
                        if (!updateZawodyIn.ZmienDane(zawody.id, zawody.name, zawody.content, zawody.schedule, zawody.Entry_fee_outside_the_club, zawody.Entry_fee_club_member, zawody.available_slots))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }

                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
               {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
               }



            }
        }

        private void button3_Click(object sender, EventArgs e)//delete zawody
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz usunąć wyświetlone dane???");

            potwierdzenie.ShowDialog();

            if (potwierdzenie.tak_zmien)
            {
                potwierdzenie.Close();
                try
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {



                        DeleteZawodyInBaza deleteZawody = new DeleteZawodyInBaza();
                        if (!deleteZawody.UsunZawody(Convert.ToInt32(row.Cells[0].Value)))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }


                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }

            }
        }

        private void Zawody_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)//odświerz konkurencje
        {
            readKonkurencja read = new readKonkurencja();
            konkurencjes= read.pokaz();
            dataGridView3.DataSource = konkurencjes;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//dodaj konkurencje
        {
            DodajKonkurencje dodaj = new DodajKonkurencje();
            dodaj.Show();
        }

        private void button10_Click(object sender, EventArgs e)//zapisz konkurencje
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz zmienić wyświetlone dane???");

            potwierdzenie.ShowDialog();
            konkurencje konkurencje = new konkurencje();

            if (potwierdzenie.tak_zmien)
            {

               try
            {
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {

                        konkurencje.used_weapon used_weapon;

                        konkurencje.id = Convert.ToInt32(row.Cells[0].Value);
                        konkurencje.name = row.Cells[1].Value.ToString();
                        konkurencje.competition_code = row.Cells[2].Value.ToString();
                        konkurencje.content = row.Cells[3].Value.ToString();
                        konkurencje.own_weapon_tariff_a = Convert.ToDecimal(row.Cells[5].Value);
                        konkurencje.own_weapon_tariff_b = Convert.ToDecimal(row.Cells[6].Value);
                        konkurencje.club_weapon_tariff_a = Convert.ToDecimal(row.Cells[7].Value);
                        konkurencje.club_weapon_tariff_b = Convert.ToDecimal(row.Cells[8].Value);

                        if (row.Cells[4].Value.ToString().Contains("własna"))
                            used_weapon = konkurencje.used_weapon.własna;
                        else if(row.Cells[4].Value.ToString().Contains("klubowa"))
                            used_weapon = konkurencje.used_weapon.klubowa;
                        else
                            used_weapon = konkurencje.used_weapon.dowolna;
                        konkurencje.available_slots = Convert.ToInt32(row.Cells[5].Value.ToString());
                        updateKonkurencjaInBaza updateZawodyIn = new updateKonkurencjaInBaza();
                        if (!updateZawodyIn.ZmienDane(konkurencje.id, konkurencje.name, konkurencje.competition_code, konkurencje.content, used_weapon,  konkurencje.available_slots,konkurencje.own_weapon_tariff_a,konkurencje.own_weapon_tariff_b,konkurencje.club_weapon_tariff_a,konkurencje.club_weapon_tariff_b
                            ))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }

                    }
                    MessageBox.Show("Zmodyfikowano");
                }
            catch
              {
              MessageBox.Show("Nastąpił nieoczekiwany błąd");
               }



            }
        }

        private void button9_Click(object sender, EventArgs e)//usun konkurencje
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz usunąć wyświetlone dane???");

            potwierdzenie.ShowDialog();

            if (potwierdzenie.tak_zmien)
            {
                potwierdzenie.Close();
                try
                {
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {



                        DeleteKonkurencjaInBaza delete = new DeleteKonkurencjaInBaza();
                        if (!delete.Usunkonkurencje(Convert.ToInt32(row.Cells[0].Value)))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }


                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)//szukaj konkurencje
        {
            readKonkurencja read = new readKonkurencja();
            konkurencjes = read.pokaz();
            List<konkurencje> Nowe = new List<konkurencje>();
            try
            {
                switch (coZaznaczoneKonkurencje())
                {
                    case 0:
                        foreach (var d in konkurencjes)
                        {
                            if (d.id == Convert.ToInt32(textBox3.Text.Trim()))
                                Nowe.Add(d);

                        }

                        ;
                        break;
                    case 1:
                        foreach (var d in konkurencjes)
                        {
                            if (d.name.Contains(textBox3.Text.Trim()))
                                Nowe.Add(d);

                        };
                        break;
                    case 2:
                        foreach (var d in konkurencjes)
                        {
                            if (d.competition_code.Contains(textBox3.Text.Trim()))
                                Nowe.Add(d);

                        };
                        break;

                }
                konkurencjes = Nowe;

                dataGridView3.DataSource = konkurencjes;
            }
            catch
            {
                MessageBox.Show("Wystąpił Błąd");

            }
        }

        private int coZaznaczoneKonkurencje()
        {
            if (radioButton5.Checked)
                return 2;
            else if (radioButton1.Checked)
                return 1;

            return 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 1)
            {
                readKonkurencja read = new readKonkurencja();
                konkurencjes = read.pokaz();


                dataGridView3.DataSource = konkurencjes;
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)// odświerz sedziowie
        {
            readJudges read = new readJudges();
            sedziowies = read.pokaz();
            dataGridView4.DataSource = sedziowies;


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)//usun sedziowie
        {

            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz usunąć wyświetlone dane???");

            potwierdzenie.ShowDialog();

            if (potwierdzenie.tak_zmien)
            {
                potwierdzenie.Close();
                try
                {
                    foreach (DataGridViewRow row in dataGridView4.Rows)
                    {



                        DeleteJudgeInBaza deleteJudgeIn = new DeleteJudgeInBaza();

                        if (!deleteJudgeIn.Usunkonkurencje(Convert.ToInt32(row.Cells[0].Value)))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }


                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }

            }
        }


        private void button11_Click(object sender, EventArgs e)//szukaj sędziowie
        {
            readJudges read = new readJudges();
            sedziowies = read.pokaz();
            List<Sedziowie> Nowe = new List<Sedziowie>();
            try
            {
                switch (coZaznaczoneSedziowies())
                {
                    case 0:
                        foreach (var d in sedziowies)
                        {
                            if (d.id == Convert.ToInt32(textBox4.Text.Trim()))
                                Nowe.Add(d);

                        }

                        ;
                        break;
                    case 1:
                        foreach (var d in sedziowies)
                        {
                            if (d.judge_name.Contains(textBox4.Text.Trim()))
                                Nowe.Add(d);

                        };
                        break;
                    case 2:
                        foreach (var d in sedziowies)
                        {
                            if (d.contest_name.Contains(textBox4.Text.Trim()))
                                Nowe.Add(d);

                        };
                        break;


                }
                sedziowies = Nowe;

                dataGridView4.DataSource = sedziowies;
            }
            catch
            {
                MessageBox.Show("Wystąpił Błąd");

            }
        }

        private int coZaznaczoneSedziowies()
        {
            if (radioButton7.Checked)
                return 0;
            else if (radioButton6.Checked)
                return 1;
            else
                return 2;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)//szukaj zawody dodawanie konkurencji do zawodów
        {
            readZawody read = new readZawody();
            zawodies = read.pokazZawody();
            List<Zawody> Nowe = new List<Zawody>();
          
            foreach (var d in zawodies)
            {
            if (d.name.Contains(textBox6.Text.Trim()))
                Nowe.Add(d);
            }

              
            zawodies = Nowe;

            dataGridView6.DataSource = zawodies;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)//
        {
            if (textBox6.Text.Length < 1)
            {
                readZawody read = new readZawody();
                zawodies = read.pokazZawody();


                dataGridView6.DataSource = zawodies;
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)//szukaj konkurencje dodawanie konkurencji do zawodów
        {
            readKonkurencja read = new readKonkurencja();
            konkurencjes = read.pokaz();
            List<konkurencje> Nowe = new List<konkurencje>();


            foreach (var d in konkurencjes)
            {
                if (d.name.Contains(textBox5.Text.Trim()))
                    Nowe.Add(d);
            }
                    

          
            konkurencjes = Nowe;

            dataGridView5.DataSource = konkurencjes;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text.Length < 1)
            {
                readKonkurencja read = new readKonkurencja();
                konkurencjes = read.pokaz();


                dataGridView5.DataSource = konkurencjes;
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length < 1)
            {
                readKonkurencjaWZawodach readKonkurencjaWZawodach = new readKonkurencjaWZawodach();
                konkurencjeWZawodaches = readKonkurencjaWZawodach.pokaz();
                dataGridView7.DataSource = konkurencjeWZawodaches;

            }
        }

        private void button17_Click(object sender, EventArgs e) // odświerz konkurencje w zawodach
        {
            readKonkurencjaWZawodach readKonkurencjaWZawodach = new readKonkurencjaWZawodach();
            konkurencjeWZawodaches = readKonkurencjaWZawodach.pokaz();
            dataGridView7.DataSource = konkurencjeWZawodaches;
        }

        private void button18_Click(object sender, EventArgs e)// dodaj konkurencje w zawodach
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz dodać Konkurencje do Zawodów???");

            potwierdzenie.ShowDialog();

            if (potwierdzenie.tak_zmien)
            {
                potwierdzenie.Close();
                try
                {




                    addKonkurencjeWZawodach addKonkurencjeW = new addKonkurencjeWZawodach();
                    if (!addKonkurencjeW.dodaj(Convert.ToInt32(textBox9.Text.Trim()), Convert.ToInt32(textBox8.Text.Trim())))
                    {
                        Exception exception = new Exception();
                        throw exception;
                    }



                    MessageBox.Show("Zmodyfikowano");
               }
               catch
               {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
               }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)// usun konkurencje w zawodach
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz usunąć konkurencje w zawodach ???");

            potwierdzenie.ShowDialog();

            if (potwierdzenie.tak_zmien)
            {
                potwierdzenie.Close();
                try
                {




                    DeleteInBazaKonkurencjaWZawodach deleteInBazaKonkurencjaW = new DeleteInBazaKonkurencjaWZawodach();
                        if (!deleteInBazaKonkurencjaW.Usunkonkurencje(Convert.ToInt32(textBox10.Text.Trim())))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }


                  
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)//szukaj konkuerencje w zawodach
        {
            readKonkurencjaWZawodach readKonkurencjaWZawodach = new readKonkurencjaWZawodach();
            konkurencjeWZawodaches = readKonkurencjaWZawodach.pokaz();
            
            List<KonkurencjeWZawodach> Nowe = new List<KonkurencjeWZawodach>();

            try
            {
                foreach (var d in konkurencjeWZawodaches)
                {
                    if (d.contest_name.Contains(textBox7.Text.Trim()))
                        Nowe.Add(d);
                }



                konkurencjeWZawodaches = Nowe;

                dataGridView7.DataSource = konkurencjeWZawodaches;
            }
            catch
            {
                MessageBox.Show("Wystąpił Błąd");

            }
        }

        private void wybraneZawody_SelectedIndexChanged(object sender, EventArgs e)
        {
            konkurencjeZawodow.Items.Clear();
            readDanaKonkurencjaWZawodach readDana = new readDanaKonkurencjaWZawodach();
            var pom1 = readDana.pokaz(wybraneZawody.GetItemText(wybraneZawody.SelectedItem));
            try
            {
                foreach (var d in pom1)
                {
                    konkurencjeZawodow.Items.Add(d.competition_name);
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił Błąd");

            }
        }

        private void filtruj_Click(object sender, EventArgs e)
        {
            readWyniki read4 = new readWyniki();
            wynikis = read4.pokaz();
            List<Wyniki> Nowe = new List<Wyniki>();
            try
            {
                foreach (var d in wynikis)
                {
                    if (d.competition_name.Contains(konkurencjeZawodow.GetItemText(konkurencjeZawodow.SelectedItem)) && d.contests_name.Contains(wybraneZawody.GetItemText(wybraneZawody.SelectedItem)))
                        Nowe.Add(d);
                }


                wynikis = Nowe;

                dataGridView8.DataSource = wynikis;
            }
            catch
            {
                MessageBox.Show("Wystąpił Błąd");

            }
        }

        private void button20_Click(object sender, EventArgs e)//zapisz Wyniki
        {
            PotwierdzenieKlikniecia potwierdzenie = new PotwierdzenieKlikniecia("Czy chcesz zmienić wyświetlone dane???");

            potwierdzenie.ShowDialog();
            Wyniki wyniki = new Wyniki();

            if (potwierdzenie.tak_zmien)
            {

                try
                {
                    foreach (DataGridViewRow row in dataGridView8.Rows)
                    {


                       // wyniki.competition__id = Convert.ToInt64(row.Cells[1].Value);
                       // wyniki.contests_id = Convert.ToInt64(row.Cells[2].Value);
                        wyniki.result = Convert.ToString(row.Cells[8].Value);
                        wyniki.place = Convert.ToString(row.Cells[9].Value);
                        wyniki.comments = Convert.ToString(row.Cells[10].Value);
                        wyniki.inside = Convert.ToInt32(row.Cells[11].Value);
                        wyniki.result_id= Convert.ToInt32(row.Cells[12].Value);


                        updateWynikiInbaza update = new updateWynikiInbaza();
                        if (!update.ZmienDane(wyniki.result_id,Convert.ToInt32(wyniki.result), Convert.ToInt32(wyniki.place), Convert.ToInt32(wyniki.inside),wyniki.comments))
                        {
                            Exception exception = new Exception();
                            throw exception;
                        }

                    }
                    MessageBox.Show("Zmodyfikowano");
                }
                catch
                {
                    MessageBox.Show("Nastąpił nieoczekiwany błąd");
                }



            }
        }

      

       private void button21_Click(object sender, EventArgs e) // eksport
        {
          
          
            
           
          
          

    
         
           
            Thread thread = new Thread(((ThreadStart)(() =>
            {
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";


                save.FileName = "zawody" + ".pdf";

                if (save.ShowDialog() == DialogResult.OK)

                {
                  

                    PdfPTable pTable = new PdfPTable(dataGridView8.Columns.Count-7);

                    pTable.DefaultCell.Padding = 2;

                    pTable.WidthPercentage = 100;

                    pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    int i = 0;
                    foreach (DataGridViewColumn col in dataGridView8.Columns)
                        
                    {
                        if (i > 4 && i != 6 && i != 12)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                            pTable.AddCell(pCell);
                        }i++;
                    }

                    foreach (DataGridViewRow viewRow in  dataGridView8.Rows)

                    {
                        i = 0;
                        foreach (DataGridViewCell dcell in viewRow.Cells)

                        {
                            if (i > 4 && i != 6 && i != 12)
                            {
                                pTable.AddCell(dcell.Value.ToString());
                            }
                            i++;
                        }

                    }
                    try
                    {
                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                        
                            PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
                            document.Open();
                            document.Add(pTable);
                            document.Close();
                            fileStream.Close();
                      
                        }
                    }
                    catch
                    {

                        MessageBox.Show("Podana Nazwa Już Istnieje!!");
                    }
                }

              
            })));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            thread.Abort();

         
        }
    
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

   
    }
}
