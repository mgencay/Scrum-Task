using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Scrum
{
    public partial class Form2 : Form

    {
        //veri tabanı bağlantısı bu kod ile sağlanacaktır.
        SqlConnection conn = new SqlConnection("Data Source=GENCAY-PC;Initial Catalog=scrum;Integrated Security=True");

        
      
        public Form2()
        {
            InitializeComponent();
          


        }



        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void Tahmin() {
            //Proje Büyüklüğünü Tahminlemesi işlemi için Basit COCOMO modeli kullanılmıştır.
            // burada kod satırı yerine istenilen projedeki açıklama ve not bilgilerinin uzunluğu dikkate
            //alınmıştır. Teknik Kart içerinde verilen açıklama ve not bilgileri kullanılarak aşağıdaki 
            //işlemler uygulanarak tahmini süre hesaplanmış ve Teknik Kart ta yer alan 
            //Tahmini süre kısmına bu bilgi girilmiştir. Verilen formüllere göre öncelikle 
            //harcanacak emek verilen formülle hesaplanmış ve daha sonra bulun değer ile süre için 
            //verilen formülle gerekli tahmini süre hesaplaması yapılmıştır.
            double uzunluk =  (Aciklama.Text.Length+Notlar.Text.Length);
            double usluSayi = Math.Pow(uzunluk, 1.05);
            double sonuc = 2.4 * usluSayi;
          
            TahminiSure.Text = (Math.Round(sonuc, 0).ToString() + " saat");

        }


        private void TaskEkle_Click(object sender, EventArgs e)
        {   //bu buton ile form2 ekranında girilen tas bilgileri veri tabanına kaydedilmiştir.
            if (ProjeAdi.Text != "")
            {
                //süre tahminini hesaplayan metod çağırılmıştır.
                Tahmin();
                //veri tabanı bağlantısı açılır
                conn.Open();               
                //veri tabanının tasks tablosuna form2 ye girilen bilgiler kaydedilir.
                SqlCommand kmt = new SqlCommand("Insert into  Tasks (KartNo,TaskName,PersonelName,Descr,Note,TaskDate,PreDate,RealDate) VALUES  ('" + KartNo.Text + "','" + ProjeAdi.Text + "','" + TeknikUzman.Text + "','" + Aciklama.Text + "','" + Notlar.Text + "','" + Tarih.Text + "','" + TahminiSure.Text + "','" + GerceklesenSure.Text + "')", conn);             
                kmt.ExecuteNonQuery();
                //veri tabanı bağlantısı kapanır.
                conn.Close();
                MessageBox.Show("Kayit Eklendi");

            }
            //tekrar giriş yapabilmek için form2 deki alanlar temizlenir.
            KartNo.Clear();
            Tarih.Clear();
            ProjeAdi.Clear();
            TeknikUzman.Clear();
            TahminiSure.Clear();
            GerceklesenSure.Clear();
            Aciklama.Clear();
            Notlar.Clear();
            
        }
    }
}
