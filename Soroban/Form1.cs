using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soroban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int[]> Dizi = new List<int[]>();
        List<string[]> Aciklamalar = new List<string[]>();
        String TxtIslem;
        int index;
        int SayfaNo = 0;
        void TabloyuCiz()
        {
            dataGridView1.Columns.Clear();
            for (int i = 0; i < 13; i++)//13 tane sutun eklenir
            {
                dataGridView1.Columns.Add("","");
                dataGridView1.Columns[i].Width = 40;
            }
            //7 tane satır eklenir 5 tanesi aşadağıdakileri için 2 tanesi yukardakiler için 1 er adet haraket için en yukardaki değerleri en aşağıdaki açıklama
            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Rows.Add();
            }
        } 
        void Gir(int sayi)
        {
            int i = 12;
            while (sayi > 0)
            {

                Dizi[Dizi.Count - 1][i] = sayi % 10;
                i--;
                sayi = sayi / 10;
            }
        }
       void IslemAlgilama()
        {
            try
            {

                int sirano = 0;
                ArrayList liste = new ArrayList();
                liste.AddRange(TxtIslem.Split('+', '-', '*'));
                char[] a = TxtIslem.ToCharArray();
                sirano = -1;
                if (TxtIslem.Contains("*"))//Eğer çarpma işlemi varsa
                {
                    for (int i = 0; i < liste.Count; i++)
                    {
                        if (i != liste.Count - 1)
                        {
                            sirano += liste[i].ToString().Length + 1;

                            if (a[sirano] == '*')
                            {
                                Carpma(Convert.ToInt32(liste[i]), Convert.ToInt32(liste[i + 1]));
                                if (TxtIslem.Length == (liste[i] + "*" + liste[i + 1]).Length)
                                    return;
                                else
                                {
                                    TxtIslem = TxtIslem.Replace((liste[i] + "*" + liste[i + 1]), AbaküstekiDegeriAl(Dizi.Count - 1));
                                    Dizi.Add(new int[13]);
                                    Aciklamalar.Add(new string[13]);
                                    for (int j = 0; j < 13; j++)
                                        Aciklamalar[Aciklamalar.Count - 1][j] = "";
                                    break;
                                }

                            }
                        }


                    }
                    IslemAlgilama();
                }
                else//Çarpma işlemi yoksa
                {

                    for (int i = 0; i < liste.Count; i++)
                    {
                        if (i == 0)
                            topla(Convert.ToInt32(liste[i]), 0);
                        else
                        {
                            if (a[sirano] == '+')
                                topla(Convert.ToInt32(liste[i]), 0);
                            else
                                Cikar(Convert.ToInt32(liste[i]), 0);

                        }
                        sirano += liste[i].ToString().Length + 1;



                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Girişinizi Kontrol Ediniz.");

            }
          
        }
        string AbaküstekiDegeriAl(int c)
        {
            string a="";
            bool b = false;
            for (int i = 0; i < 13; i++)
            {
                if (Dizi[c][i] != 0)
                    b = true;
                if (b)
                    a += Dizi[c][i].ToString();
             

            }


           
            return a;
        }
      void topla(int sayi,int bosluk)
        {
            try
            {
                List<int> sayilar = new List<int>();
                sayi = sayi * Convert.ToInt32(Math.Pow(10, bosluk));
                while (sayi > 0)
                {
                    sayilar.Add(sayi % 10);
                    sayi = sayi / 10;
                }

                for (int i = 0; i < sayilar.Count; i++)
                {

                    if (sayilar[i] == 0)
                    {
                        i++;
                        if (i == sayilar.Count)
                            break;
                    }

                    if (4 - (Dizi[Dizi.Count - 1][12 - i] % 5) >= sayilar[i] && sayilar[i] < 5)
                    {
                        Dizi[Dizi.Count - 1][12 - i] += sayilar[i];
                    }
                    else
                    {

                        if (9 - Dizi[Dizi.Count - 1][12 - i] >= sayilar[i])//5li
                        {

                            Dizi[Dizi.Count - 1][12 - i] += 5;


                            Dizi[Dizi.Count - 1][12 - i] -= 5 - sayilar[i];
                        }
                        else//10lu
                        {
                            Cikar(10 - sayilar[i], i);
                            topla(1, i + 1);



                        }

                    }
                    if (AbaküstekiDegeriAl(Dizi.Count - 1) != AbaküstekiDegeriAl(Dizi.Count - 2))
                        YeniAdim();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Girişinizi Kontrol Ediniz.");
            }
           
        }
        void Cikar(int sayi, int bosluk)
        {
            try
            {
                List<int> sayilar = new List<int>();
                sayi = sayi * Convert.ToInt32(Math.Pow(10, bosluk));
                while (sayi > 0)
                {
                    sayilar.Add(sayi % 10);
                    sayi = sayi / 10;
                }
                for (int i = 0; i < sayilar.Count; i++)
                {
                    if (sayilar[i] == 0)
                    {
                        i++;
                        if (i == sayilar.Count)
                            break;
                    }
                    if ((Dizi[Dizi.Count - 1][12 - i] % 5) >= sayilar[i])
                    {
                        Dizi[Dizi.Count - 1][12 - i] -= sayilar[i];
                    }
                    else
                    {
                        if (Dizi[Dizi.Count - 1][12 - i] >= sayilar[i])//5li
                        {


                            Dizi[Dizi.Count - 1][12 - i] -= 5;

                            Dizi[Dizi.Count - 1][12 - i] += 5 - sayilar[i];
                        }
                        else//10lu
                        {
                            Cikar(1, i + 1);
                            topla(10 - sayilar[i], i);


                        }

                    }
                    if (AbaküstekiDegeriAl(Dizi.Count - 1) != AbaküstekiDegeriAl(Dizi.Count - 2))
                        YeniAdim();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Girişinizi Kontrol Ediniz.");
            }
           
        }
        void Carpma(int sayi,int sayi2)
        {

            List<int> sayilar = new List<int>();
            List<int> sayilar2 = new List<int>();

            int t = sayi;
            while (t > 0)
            {


                sayilar.Add(t % 10);
                t = t / 10;

            }

            t = sayi2;
            while (t > 0)
            {


                sayilar2.Add(t % 10);
                t = t / 10;

            }

            for (int i = 0; i < GetBasamakSayisi(sayi2); i++)
            {
                for (int j =0; j < GetBasamakSayisi(sayi); j++ )
                {
                    topla(sayilar[j] * sayilar2[i],i+j);

                }
               
               
            }

        }
        int GetBasamakSayisi(int i)
        {
            int a = 0;
            while (i > 0)
            {



                i = i / 10;
                a++;

            }
            return a;

        }
        void AbakusuCiz(int dizino)
        {

            TabloyuCiz();
            for (int i = 0; i < 13; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = Dizi[dizino][i].ToString();
                dataGridView1.Rows[8].Cells[i].Value = Aciklamalar[dizino][i].ToString();


            }

            for (int i = 0; i < 13; i++)
            {
           
                if (Dizi[dizino][i]>=5)
                {
                    dataGridView1.Rows[2].Cells[i].Style.BackColor = Color.Black;
                }
                else
                {
                    dataGridView1.Rows[1].Cells[i].Style.BackColor = Color.Black;

                }
                for (int a = 0; a < Dizi[dizino][i]%5; a++)
                {

                    dataGridView1.Rows[a + 3].Cells[i].Style.BackColor = Color.Brown;

                }
                for (int a = 0; a < 4-(Dizi[dizino][i] % 5); a++)
                {
                    dataGridView1.Rows[7 - a].Cells[i].Style.BackColor = Color.Brown;

                }
              
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
           

         
            TabloyuCiz();
        }
        void YeniAdim()
        {
            Dizi.Add(new int[13]);
            Aciklamalar.Add(new string[13]);
            for (int i = 0; i < 13 ; i++)
                Aciklamalar[Aciklamalar.Count - 1][i] = "";
                for (int i = 0; i < 13&&Dizi.Count>1; i++)
                Dizi[Dizi.Count - 1][i] = Dizi[Dizi.Count - 2][i];
            
        }
        private void btn_Coz_Click(object sender, EventArgs e)
        {
           
            Dizi.Clear();
            Aciklamalar.Clear();
            SayfaNo = 0;
            YeniAdim();
            YeniAdim();

            TxtIslem = tb_Islem.Text;
         
            IslemAlgilama();
            AbakusuCiz(0);


        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            if (SayfaNo < Dizi.Count-1)
            {
                SayfaNo++;

                AbakusuCiz(SayfaNo);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            if (SayfaNo >= 1)
            {
                SayfaNo--;

                AbakusuCiz(SayfaNo);
            }
        }

     

        private void btn_son_Click(object sender, EventArgs e)
        {
            SayfaNo = Dizi.Count - 1;
            AbakusuCiz(SayfaNo);

        }

        private void btn_ilk_Click(object sender, EventArgs e)
        {

            SayfaNo = 0;
            AbakusuCiz(SayfaNo);
        }
    }
}
