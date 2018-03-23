using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            lvTeslim.View = View.Details;
            lvTeslim.GridLines = true;
            lvTeslim.FullRowSelect = true;
            var teslim = new ListViewItem(new[] { "Sherlock Holmes", "Samet Sunman", "18.04.2017" });
            var teslim2 = new ListViewItem(new[] { "Olasılıksız", "Can Demir", "19.04.2017" });
            lvTeslim.Items.Add(teslim);
            lvTeslim.Items.Add(teslim2);


            lvKitap.View = View.Details;
            lvKitap.GridLines = true;
            lvKitap.FullRowSelect = true;
            var kitap = new ListViewItem(new[] { "9786059840736", "Sherlock Holmes", "Sir Arthur Conan Doyle", "1234 No'lu Üyede" });
            var kitap2 = new ListViewItem(new[] { "9786050929997", "Açlık Oyunları", "Suzanne Collins", "Müsait" });
            var kitap3 = new ListViewItem(new[] { "9789756006054", "Olasılıksız", "Adam Fawer", "6109 No'lu Üyede" });
            var kitap4 = new ListViewItem(new[] { "9759099373", "Araba Sevdası", "Recaizade Mahmut Ekrem", "Müsait" });
            var kitap5 = new ListViewItem(new[] { "9789944824354", "Taht Oyunları", "George R. R. Martin", "Müsait" });
            lvKitap.Items.Add(kitap);
            lvKitap.Items.Add(kitap2);
            lvKitap.Items.Add(kitap3);
            lvKitap.Items.Add(kitap4);
            lvKitap.Items.Add(kitap5);



            lvUye.View = View.Details;
            lvUye.GridLines = true;
            lvUye.FullRowSelect = true;
            var uye = new ListViewItem(new[] { "1234", "Samet", "Sunman" });
            var uye2 = new ListViewItem(new[] { "2345", "Ayşe", "Güneş" });
            var uye3 = new ListViewItem(new[] { "2973", "Fatma", "Çiçek" });
            var uye4 = new ListViewItem(new[] { "6109", "Can", "Demir" });
            lvUye.Items.Add(uye);
            lvUye.Items.Add(uye2);
            lvUye.Items.Add(uye3);
            lvUye.Items.Add(uye4);

            

        }

        private void bKitap_Click(object sender, EventArgs e)
        {
            if (tbBarkod.Text != "" && tbKitapAdi.Text != "" && tbYazarAdi.Text != "")
            {
                string[] row = { tbBarkod.Text, tbKitapAdi.Text, tbYazarAdi.Text, "Müsait" };
                var satir = new ListViewItem(row);
                lvKitap.Items.Add(satir);
            }
            else
            { MessageBox.Show("Lütfen, kitap bilgilerini doldurun."); } 
        }

  

        private void bUye_Click(object sender, EventArgs e)
        {
             if (tbUyeNo.Text != "" && tbUyeAdi.Text != "" && tbUyeSoyadi.Text != "")
            {
            string[] row = { tbUyeNo.Text, tbUyeAdi.Text, tbUyeSoyadi.Text };
            var satir = new ListViewItem(row);
            lvUye.Items.Add(satir);
            }
             else
             { MessageBox.Show("Lütfen, üye bilgilerini doldurun."); } 
        }


        private void bEmanet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (lvKitap.SelectedItems[0].SubItems[3].Text.ToString() == "Müsait")
                {
                    string adsoyad = lvUye.SelectedItems[0].SubItems[1].Text.ToString() + " " + lvUye.SelectedItems[0].SubItems[2].Text.ToString();
                    string kitapadi = lvKitap.SelectedItems[0].SubItems[1].Text.ToString();
                    string tarih = DateTime.Now.ToShortDateString();
                    string[] row = { kitapadi, adsoyad,tarih };
                    var listViewItem = new ListViewItem(row);
                    lvTeslim.Items.Add(listViewItem);
                    lvKitap.SelectedItems[0].SubItems[3].Text = lvUye.SelectedItems[0].SubItems[0].Text.ToString() + " No'lu üyede";
                }
                else
                {
                    MessageBox.Show("Şuan bu kitap " + lvKitap.SelectedItems[0].SubItems[3].Text + " bulunuyor.");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen, üye ve kitap seçin.");
            }
        }

        private void bTeslim_Click(object sender, EventArgs e)
        {
            if (lvTeslim.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvKitap.Items.Count; i++)
                {
                    if (lvKitap.Items[i].SubItems[1].Text == lvTeslim.SelectedItems[0].SubItems[0].Text)
                    {

                        lvKitap.Items[i].SubItems[3].Text = "Müsait";
                        goto sil;
                    }
                }
            sil: lvTeslim.SelectedItems[0].Remove();
            }
            else
            { MessageBox.Show("Lütfen, teslim aldığınız kitabı seçin."); }

        }

        private void bKitapSil_Click(object sender, EventArgs e)
        {
            if (lvKitap.SelectedItems.Count > 0 && lvKitap.SelectedItems[0].SubItems[3].Text.ToString() == "Müsait")
            { lvKitap.SelectedItems[0].Remove(); }
            else if (lvKitap.SelectedItems[0].SubItems[3].Text.ToString() != "Müsait")
            {
                MessageBox.Show("Şuan bu kitap " + lvKitap.SelectedItems[0].SubItems[3].Text + " bulunduğundan silemezsiniz.");
            }
            else
            { MessageBox.Show("Lütfen, silmek istediğiniz kitabı seçin."); }
        }

        private void bUyeSil_Click(object sender, EventArgs e)
        {
            if (lvUye.SelectedItems.Count > 0)
            { lvUye.SelectedItems[0].Remove(); }
            else
            { MessageBox.Show("Lütfen, silmek istediğiniz üyeyi seçin."); }
        }

        private void tbBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
              if ((int)e.KeyChar >= 48 && (int)e.KeyChar <=57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbUyeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lvTeslim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbUyeSecimi_Click(object sender, EventArgs e)
        {

        }

        private void lvKitap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bKitapAra_Click(object sender, EventArgs e)
        {
            bool kitapara=tbBarkod.Text == "" && tbYazarAdi.Text== "";
            bool yazarara=tbBarkod.Text == "" && tbKitapAdi.Text== "";
            bool barkodara=tbKitapAdi.Text == "" && tbYazarAdi.Text== "";
            bool bos = tbKitapAdi.Text == "" && tbYazarAdi.Text == "" && tbBarkod.Text == "";
            if (bos)
            { MessageBox.Show("Kitap araması yapmak için 'Kitap Adı', 'Kitap Yazarı' veya 'ISBN' alanlarından birini doldurun."); }
            else if (kitapara)
            {
                    bool durum = false;
                    for (int i = 0; i < lvKitap.Items.Count; i++)
                         {
                                    if (lvKitap.Items[i].SubItems[1].Text == tbKitapAdi.Text)
                                    {
                                        ListViewItem bulunanlar = lvKitap.Items[i];
                                        foreach (ListViewItem item in lvKitap.Items)
                                     {
                                         lvYedekKitap.Items.Add((ListViewItem)item.Clone()); }

                                        lvKitap.Items.Clear();
                                        durum = true;
                                        lvKitap.Items.Add(bulunanlar);
                                        bGeriAl.Visible=true;
                                    }
                    }

                    if (durum == false)
                    {
                        MessageBox.Show("Kayıt Bulunamadı!");
                    }

            }
            else if (yazarara)
            {

                bool durum = false;
                for (int i = 0; i < lvKitap.Items.Count; i++)
                {
                    if (lvKitap.Items[i].SubItems[2].Text == tbYazarAdi.Text)
                    {
                        ListViewItem bulunanlar = lvKitap.Items[i];
                        foreach (ListViewItem item in lvKitap.Items)
                        {
                            lvYedekKitap.Items.Add((ListViewItem)item.Clone());
                        }

                        lvKitap.Items.Clear();
                        durum = true;
                        lvKitap.Items.Add(bulunanlar);
                        bGeriAl.Visible = true;
                    }
                }

                if (durum == false)
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                }

            }
            else if (barkodara)
            {

                bool durum = false;
                for (int i = 0; i < lvKitap.Items.Count; i++)
                {
                    if (lvKitap.Items[i].SubItems[0].Text == tbBarkod.Text)
                    {
                        ListViewItem bulunanlar = lvKitap.Items[i];
                        foreach (ListViewItem item in lvKitap.Items)
                        {
                            lvYedekKitap.Items.Add((ListViewItem)item.Clone());
                        }

                        lvKitap.Items.Clear();
                        durum = true;
                        lvKitap.Items.Add(bulunanlar);
                        bGeriAl.Visible = true;
                    }
                }

                if (durum == false)
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                }

            }
            else
            {MessageBox.Show("Lütfen, 'Kitap Adı', 'Kitap Yazarı' veya 'ISBN' alanlarından yalnızca birini doldurun."); }
        }

        private void bUyeAra_Click(object sender, EventArgs e)
        {
            bool uyeadiara = tbUyeSoyadi.Text == "" && tbUyeNo.Text == "";
            bool soyadara = tbUyeAdi.Text == "" && tbUyeNo.Text == "";
            bool uyenoara = tbUyeAdi.Text == "" && tbUyeSoyadi.Text == "";
            bool bos = tbUyeAdi.Text == "" && tbUyeSoyadi.Text == "" && tbUyeNo.Text == "";
            if (bos)
            { MessageBox.Show("Üye araması yapmak için 'Adı', 'Soyadı' veya 'Üye No' alanlarından birini doldurun."); }
            else if (uyeadiara)
            {

                bool durum = false;
                for (int i = 0; i < lvUye.Items.Count; i++)
                {
                    if (lvUye.Items[i].SubItems[1].Text == tbUyeAdi.Text)
                    {
                        ListViewItem bulunanlar = lvUye.Items[i];
                        foreach (ListViewItem item in lvUye.Items)
                        {
                            lvYedekUye.Items.Add((ListViewItem)item.Clone());
                        }

                        lvUye.Items.Clear();
                        durum = true;
                        lvUye.Items.Add(bulunanlar);
                        bGeriAlUye.Visible = true;
                    }
                }

                if (durum == false)
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                }


            }
            else if (soyadara)
            {

                bool durum = false;
                for (int i = 0; i < lvUye.Items.Count; i++)
                {
                    if (lvUye.Items[i].SubItems[2].Text == tbUyeSoyadi.Text)
                    {
                        ListViewItem bulunanlar = lvUye.Items[i];
                        foreach (ListViewItem item in lvUye.Items)
                        {
                            lvYedekUye.Items.Add((ListViewItem)item.Clone());
                        }

                        lvUye.Items.Clear();
                        durum = true;
                        lvUye.Items.Add(bulunanlar);
                        bGeriAlUye.Visible = true;
                    }
                }

                if (durum == false)
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                }

            }
            else if (uyenoara)
            {

                bool durum = false;
                for (int i = 0; i < lvUye.Items.Count; i++)
                {
                    if (lvUye.Items[i].SubItems[0].Text == tbUyeNo.Text)
                    {
                        ListViewItem bulunanlar = lvUye.Items[i];
                        foreach (ListViewItem item in lvUye.Items)
                        {
                            lvYedekUye.Items.Add((ListViewItem)item.Clone());
                        }

                        lvUye.Items.Clear();
                        durum = true;
                        lvUye.Items.Add(bulunanlar);
                        bGeriAlUye.Visible = true;
                    }
                }

                if (durum == false)
                {
                    MessageBox.Show("Kayıt Bulunamadı!");
                }
            
            }
            else
            { MessageBox.Show("Lütfen, 'Adı', 'Soyadı' veya 'Üye No' alanlarından yalnızca birini doldurun."); }
        }

        private void bGeriAl_Click(object sender, EventArgs e)
        {
            bGeriAl.Visible = false;
            lvKitap.Items.Clear();
            foreach (ListViewItem item in lvYedekKitap.Items)
            {
                lvKitap.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void bGeriAlUye_Click(object sender, EventArgs e)
        {
            bGeriAlUye.Visible = false;
            lvUye.Items.Clear();
            foreach (ListViewItem item in lvYedekUye.Items)
            {
                lvUye.Items.Add((ListViewItem)item.Clone());
            }
        }

    }
}
