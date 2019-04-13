using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Threading;

namespace Struk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Comboitem();
            PrinterList();
            WebRequest request = WebRequest.Create("http://192.168.15.205:8080/safana");
            try
            {
                request.GetResponse();
                Text = ("Cetak Struk -- Connected --                                                   " + DateTime.Now.ToString("                                  dddd, d MMMM yyyy"));
            }
            catch
            {
                Text = ("Cetak Struk -- Disconnected --");
            }
            Directory.CreateDirectory("Grup Kolektif");
            ///////read txt file to list///////
            string pat = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Grup Kolektif");
            listBox1.Items.Clear();           
            DirectoryInfo dinfo = new DirectoryInfo(pat);
            FileInfo[] smFiles = dinfo.GetFiles("*.txt");
            foreach (FileInfo fi in smFiles)
            {
                //listBox1.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                string dt = Path.GetFileNameWithoutExtension(fi.Name);
                listBox1.Items.Add(dt);
                              
            }
          
            
        }
        private void Comboitem()
        {
            ComboboxItem postp = new ComboboxItem();
            postp.Text = "PLN TAGIHAN - POSTPAID";
            postp.Value = 1;
            ComboboxItem pre = new ComboboxItem();
            pre.Text = "PLN TOKEN - PREPAID";
            pre.Value = 2;
            ComboboxItem non = new ComboboxItem();
            non.Text = "PLN NON TAGIHAN";
            non.Value = 3;
            ComboboxItem tel = new ComboboxItem();
            tel.Text = "TELKOM GROUP";
            tel.Value = 4;
            ComboboxItem mul = new ComboboxItem();
            mul.Text = "MULTIFINANCE";
            mul.Value = 5;
            ComboboxItem pdam = new ComboboxItem();
            pdam.Text = "PDAM";
            pdam.Value = 6;
            ComboboxItem tv = new ComboboxItem();
            tv.Text = "TV TAGIHAN";
            tv.Value = 7;
            ComboboxItem hp = new ComboboxItem();
            hp.Text = "TAGIHAN SELULER";
            hp.Value = 8;
            ComboboxItem bpjs = new ComboboxItem();
            bpjs.Text = "BPJS KESEHATAN";
            bpjs.Value = 9;
            ComboboxItem pdamk = new ComboboxItem();
            pdamk.Text = "PDAM KUDUS";
            pdamk.Value = 10;

            cbitemK.Items.Add(postp); cbitemK.Items.Add(pre); cbitemK.Items.Add(non); cbitemK.Items.Add(tel); cbitemK.Items.Add(mul);
            cbitemK.Items.Add(pdam); cbitemK.Items.Add(tv); cbitemK.Items.Add(hp); cbitemK.Items.Add(bpjs); cbitemK.Items.Add(pdamk);
            cbitemK.SelectedIndex = 0;

            cbtipeM.Items.Add(postp); cbtipeM.Items.Add(pre); cbtipeM.Items.Add(non); cbtipeM.Items.Add(tel); cbtipeM.Items.Add(mul);
            cbtipeM.Items.Add(pdam); cbtipeM.Items.Add(tv); cbtipeM.Items.Add(hp); cbtipeM.Items.Add(bpjs);
            cbtipeM.SelectedIndex = 0;

        }
        private void bprosesK_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string tgl = dtpK.Value.Date.ToString("yyyy-MM-dd");
            string idpel = tbidpelK.Text;
            string tipe = ((cbitemK.SelectedItem as ComboboxItem).Value.ToString());
            string uri = @"http://192.168.15.205:8080/safana/struk/struklebar?idpel=" + idpel + "&tgl_bayar=" + tgl + "&tipe=" + tipe + "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
                req.AutomaticDecompression = DecompressionMethods.GZip;
                req.ContentType = "text/plain";
                using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                using (Stream stream = resp.GetResponseStream())
                using (StreamReader read = new StreamReader(stream, Encoding.UTF8))
                {
                    result = read.ReadToEnd();
                    webviewK.DocumentText = result;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("DATA TIDAK DITEMUKAN\nMencoba alihkan ke server 2");
                string urix = @"http://192.168.15.205:8080/safana/struk/strukkolektiflebar?idpel=" + idpel + "&tgl_bayar=" + tgl + "&tipe=" + tipe + "";
                try
                {
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urix);
                    req.AutomaticDecompression = DecompressionMethods.GZip;
                    req.ContentType = "text/plain";
                    using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                    using (Stream stream = resp.GetResponseStream())
                    using (StreamReader read = new StreamReader(stream, Encoding.UTF8))
                    {
                        result = read.ReadToEnd();
                        webviewK.DocumentText = result;
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("DATA TIDAK DITEMUKAN");
                }
            }
        }
        ///////////// mobile /////////////
        private void bprosesM_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string tgl = dtpM.Value.Date.ToString("yyyy-MM-dd");
            string idpel = tbidpelM.Text;
            string tipe = ((cbtipeM.SelectedItem as ComboboxItem).Value.ToString());
            string uri = @"http://192.168.15.205:8080/safana/struk/strukidpel?idpel=" + idpel + "&tgl_bayar=" + tgl + "&tipe=" + tipe + "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
                req.AutomaticDecompression = DecompressionMethods.GZip;
                req.ContentType = "text/plain";
                using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                using (Stream stream = resp.GetResponseStream())
                using (StreamReader read = new StreamReader(stream, Encoding.UTF8))
                {
                    result = read.ReadToEnd();
                    webviewM.DocumentText = result;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("DATA TIDAK DITEMUKAN\nMencoba alihkan ke server 2");
                string urix = @"http://192.168.15.205:8080/safana/struk/strukkolektif?idpel=" + idpel + "&tgl_bayar=" + tgl + "&tipe=" + tipe + "";
                try
                {
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urix);
                    req.AutomaticDecompression = DecompressionMethods.GZip;
                    req.ContentType = "text/plain";
                    using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
                    using (Stream stream = resp.GetResponseStream())
                    using (StreamReader read = new StreamReader(stream, Encoding.UTF8))
                    {
                        result = read.ReadToEnd();
                        webviewM.DocumentText = result;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("DATA TIDAK DITEMUKAN");
                }
            }
        }
        private void cbPrinterlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pname = cbPrinterlist.SelectedItem.ToString();
            printer.SetDefaultPrinter(pname);
        }
        private void bresetM_Click(object sender, EventArgs e)
        {
            webviewM.Stop();
            webviewM.Navigate("about:blank");
        }
        private void bresetK_Click(object sender, EventArgs e)
        {
            webviewM.Stop();
            webviewK.Navigate("about:blank");
        }
        private void bprintM_Click(object sender, EventArgs e)
        {
            //webviewM.ShowPrintDialog();
            webviewM.ShowPrintPreviewDialog();
        }
        private void bprintK_Click(object sender, EventArgs e)
        {
            //webviewK.ShowPrintDialog();
            webviewK.ShowPrintPreviewDialog();
        }
        private void PrinterList()
        {
            foreach (string sPrinters in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbPrinterlist.Items.Add(sPrinters);
            }
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public static class printer
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string printer);
        }
        private void bloadK_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Grup Kolektif");
            //string path = Path.GetDirectoryName(Application.ExecutablePath);
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            //string path = Application.StartupPath;
            if (Directory.Exists(path))
            {
                openFileDialog1.InitialDirectory = path;
            }
            else
            {
                openFileDialog1.InitialDirectory = @"C:\";
            }
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //tbidpelK.Text = File.ReadAllText(openFileDialog1.FileName);
                string load = File.ReadAllText(openFileDialog1.FileName);
                string replacement = Regex.Replace(load, @"\t|\n|\r", ".");
                tbidpelK.Text = replacement.ToString();
            }
        }
        private void bloadM_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Grup Kolektif");
            if (Directory.Exists(path))
            {
                openFileDialog1.InitialDirectory = path;
            }
            else
            {
                openFileDialog1.InitialDirectory = @"C:\";
            }
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {             
                //tbidpelM.Text = File.ReadAllText(openFileDialog1.FileName);
                string load = File.ReadAllText(openFileDialog1.FileName);
                string replacement = Regex.Replace(load, @"\t|\n|\r", ".");
                tbidpelM.Text = replacement.ToString();             
            }

        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            string pat = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Grup Kolektif");
            if (Directory.Exists(pat))
            {                
                File.WriteAllText(Path.Combine(pat, tbnama.Text + ".txt"), rtbgrup.Text);
                listBox1.Items.Add(tbnama.Text);
            }
            rtbgrup.Clear();tbnama.Clear();
            MessageBox.Show("DATA BERHASIL DISIMPAN");           
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string pat = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"Grup Kolektif\");
                if (Directory.Exists(pat))
                {
                    rtbgrup.Text = File.ReadAllText(Path.Combine(pat, listBox1.Text + ".txt"));
                }
            }
            catch (Exception r)
            {
                MessageBox.Show("DATA TIDAK DITEMUKAN / TELAH DIHAPUS");
            }

        }        
    }
}