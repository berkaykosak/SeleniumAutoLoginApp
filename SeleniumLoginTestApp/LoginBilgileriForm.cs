using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace SeleniumLoginTestApp
{
    public partial class LoginTestApp : Form
    {
        public LoginTestApp()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        FirefoxDriver driver;
        Thread thread;

        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (kullaniciAdi_txtBox.Text != "" && sifre_TxtBox.Text != "") 
            {
                Login_btn.ForeColor = Color.Green;
                Login_btn.Cursor = Cursors.Hand;
            }
            else
            {
                Login_btn.ForeColor = Color.Red;
                Login_btn.Cursor = Cursors.No; 
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (Login_btn.Cursor == Cursors.Hand)
            {
                thread = new Thread(Sonuc);
                thread.Start();
            }
        }

        private void Sonuc()
        {
            Login_btn.ForeColor = Color.Gold;
            Login_btn.UseWaitCursor = true;
            Login_btn.Text = "Giriş yapılıyor...";
            SeleniumBaslat(siteURL_txtBox.Text);
            Thread.Sleep(3000);
            GirisYap(kullaniciAdi_txtBox.Text, sifre_TxtBox.Text);

            if (GirisYapildiMiKontrol(loginSonrasiURL_txtBox.Text))
            {
                MessageBox.Show("GİRİŞ BAŞARILI","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Login_btn.ForeColor = Color.Green;
                Login_btn.UseWaitCursor = false;
                Login_btn.Text = "GİRİŞ BAŞARILI !";
          
            }
            else
            {
                MessageBox.Show("Giriş Yapılamadı!", "DİKKAT !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SeleniumKapat();
                Login_btn.ForeColor = Color.Lime;
                Login_btn.UseWaitCursor = false;
                Login_btn.Text = "Tekrar Giriş Yap";
            }
        }

        private void GirisYap(string kullaniciAdi, string sifre)
        {
            try
            {
                driver.FindElement(By.Name("username")).SendKeys(kullaniciAdi);
                Thread.Sleep(3000);
                driver.FindElement(By.Id("ileriButton")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Name("password")).SendKeys(sifre);
                driver.FindElement(By.Id("oturumAcButton")).Click();
                Thread.Sleep(5000);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private bool GirisYapildiMiKontrol(string girisSonrasiURL)
        {
            if (driver.Url == girisSonrasiURL)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SeleniumBaslat(string siteLinki)
        {
            FirefoxDriverService servis = FirefoxDriverService.CreateDefaultService();
            servis.HideCommandPromptWindow = true; // konsolu gizleriz.
            driver = new FirefoxDriver(servis);
            driver.Navigate().GoToUrl(siteLinki);
        }

        private void SeleniumKapat()
        {
            if (driver == null)
            {
                return;
            }
            driver.Quit();
        }

        private void FormKapat(object sender, FormClosedEventArgs e)
        {
            SeleniumKapat();
        }

    }
}
