using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Scrum
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       
         //veri tabanı bağlantısı bu kod ile sağlanacaktır.
        
        SqlConnection conn1 = new SqlConnection("Data Source=GENCAY-PC;Initial Catalog=scrum;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scrumDataSet.Tasks' table. You can move, or remove it, as needed.
            //Datagridview ile veri tabanı eşleştirmesi yapılacak.
            this.tasksTableAdapter.Fill(this.scrumDataSet.Tasks);
           
           
        }

 
        

        private void teknikkart_Click(object sender, EventArgs e)
        {
            // teknik kart için yeni bir form sayfası açılacak
            Form2 frm = new Form2();
            frm.ShowDialog();
            // yeni girilen tasklar için veri tabanı ve datagrid eşleşmesi yenilenecek
            this.tasksTableAdapter.Fill(this.scrumDataSet.Tasks);
        }
        private void Todo_Click(object sender, EventArgs e)
        {
            //datagrid listesinde seçilen bir task var ise buton click ile seçilen task to do lstesine aktarılacak
            if (TaskList.CurrentRow.Cells[0].Value.ToString() != "")
            {
                TodoList.Items.Add(TaskList.CurrentRow.Cells[2].Value.ToString());
                //veri tabanı bağlantısı açılacak
                conn1.Open();
                // to do listesine gönderilen taskın adı veri tabanındaki durumlar tablosuna yazılacak ve durumuna to do yazılacak
                SqlCommand kmt = new SqlCommand("Insert into  Durumlar(TaskName,Durum) VALUES  ('" + TaskList.CurrentRow.Cells[2].Value.ToString() + "',' To Do ')", conn1);               
                kmt.ExecuteNonQuery();
                //bağlantı kapatılacak
                conn1.Close();

            }
        }

        public void InProgress_Click(object sender, EventArgs e)
        {
           // to do için yapılan işlemler gerçekleştirilecek to do listesinde seçilen task var ise buton click ile
           //in progress listesine gönderilecek ve veri tabanı ilemleri gerçekleştirilecek.
           
            if (TodoList.SelectedItem != null)
            {
                InprogressList.Items.Add(TodoList.SelectedItem);


                conn1.Open();
                // to do listesinden in progress listesine geçirilecek task veri tabanında önce silinecek
                
                string silmeSorgusu = "DELETE from Durumlar where TaskName=@TaskName";             
                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn1);
                silKomutu.Parameters.AddWithValue("@TaskName", TodoList.SelectedItem.ToString());
                silKomutu.ExecuteNonQuery();
                //sonra durum bilgisi in progress olarak task name ile yeniden veri tabanına kayıt edilecek
                SqlCommand kmt = new SqlCommand("Insert into  Durumlar(TaskName,Durum) VALUES  ('" + TodoList.SelectedItem.ToString() + "',' In Progress ')", conn1);

                kmt.ExecuteNonQuery();

                conn1.Close();
                // to do list te seçilen task silinecek.
                TodoList.Items.Remove(TodoList.SelectedItem);
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {   // in progress için yapılan işlemlerin hepsi check için gerçekleştirilecek.
            if (InprogressList.SelectedItem != null)
            {
                CheckList.Items.Add(InprogressList.SelectedItem);


                conn1.Open();

                string silmeSorgusu = "DELETE from Durumlar where TaskName=@TaskName";
                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn1);
                silKomutu.Parameters.AddWithValue("@TaskName", InprogressList.SelectedItem.ToString());
                silKomutu.ExecuteNonQuery();

                 SqlCommand kmt = new SqlCommand("Insert into  Durumlar(TaskName,Durum) VALUES  ('" + InprogressList.SelectedItem.ToString() + "',' Check ')", conn1);

                  kmt.ExecuteNonQuery();

                conn1.Close();
                InprogressList.Items.Remove(InprogressList.SelectedItem);
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {       //check ve in progress için gerçekleştirilecek işlemler done için gerçekleştirilecek.
            if (CheckList.SelectedItem != null)
            {
                DoneList.Items.Add(CheckList.SelectedItem);


                conn1.Open();

                string silmeSorgusu = "DELETE from Durumlar where TaskName=@TaskName";               
                SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn1);
                silKomutu.Parameters.AddWithValue("@TaskName", CheckList.SelectedItem.ToString());
                silKomutu.ExecuteNonQuery();

                SqlCommand kmt = new SqlCommand("Insert into  Durumlar(TaskName,Durum) VALUES  ('" + CheckList.SelectedItem.ToString() + "',' Done')", conn1);

                kmt.ExecuteNonQuery();

                conn1.Close();
                CheckList.Items.Remove(CheckList.SelectedItem);
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {   // bu buton ile datagrid listesinde seçilen herhangi bir task veritabanından silinecek.
            conn1.Open();
            string silmeSorgusu = "DELETE from Tasks where TaskName=@TaskName";
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn1);
            silKomutu.Parameters.AddWithValue("@TaskName", TaskList.CurrentRow.Cells[2].Value.ToString());
            silKomutu.ExecuteNonQuery();
            conn1.Close();

            // veri tabanının güncel hali datagrdi de tekrardan listelenecek.
            this.tasksTableAdapter.Fill(this.scrumDataSet.Tasks);
        }

        private void Onay_Click(object sender, EventArgs e)
        {
            //bu buton ile done listesinde onaylanan ve kaldırılmak istenen iş veritabanındaki durumlar
            //tablosunda silinecek
            conn1.Open();
            string silmeSorgusu = "DELETE from Durumlar where TaskName=@TaskName";
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn1);
            silKomutu.Parameters.AddWithValue("@TaskName", DoneList.SelectedItem.ToString());
            silKomutu.ExecuteNonQuery();
            conn1.Close();
            // done listesinden seçilen task kaldırılacak
            DoneList.Items.Remove(DoneList.SelectedItem);
        }

   

        private void Testbutton_Click(object sender, EventArgs e)
        {   
            // Bu buton ile white box testi işlemi gerçekleştirilmiştir.
           // Scrum Task Board a konulan bir test butonu yardımı ile To do listesinde bulunan 
             //       projelerden birisi rastgele seçilecek ve In Progress butonu tıklatması 
             //   yapılarak rastgele seçilen projenin In Progress listesine geçirilmesi test edilmiştir.
            string secim;
            int adet = TodoList.Items.Count;
            Random rnd = new Random();
            int sayi = rnd.Next(0, adet);
            //to do listesinden rastgele bir eleman seçilmiştir.
            TodoList.SelectedIndex = sayi;
            secim = TodoList.SelectedItem.ToString(); 
            // to do listesinden ın progress listesine task ların geçirilmesini sağlayan butona click işlemi yaptırılmıştır.
            InProgress.PerformClick();
            
            //in progress listesinde seçilip taşınan task aranmaktadır.
            for (int i = 0; i < InprogressList.Items.Count; i++)
            {
                if (InprogressList.Items[i].ToString().ToLower().Contains(secim.ToLower()))
                {
                    MessageBox.Show("To do listesinden rastgele bir eleman seçilip in progress listesine taşıma testi başarıyla gerçekleştirildi.");
                }

            }
        }
    }
}
