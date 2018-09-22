using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;


namespace Projekti_KNK
{
    public partial class frm_SHA : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objident = new Identifikohu();
        string _Gjinia = "";

        public frm_SHA()
        {
            InitializeComponent();
        }

        public void Pastro()
        {
            txtEmri.Clear();
            txtMbiemri.Clear();
            txtPassword.Clear();
            dtpDitlindja.Value = DateTime.Now;
            txtVendlindja.Clear();
            txtTel.Clear();
            _Gjinia = "";
            txtEmail.Clear();
        }

        private void btnRuajeA_Click_1(object sender, EventArgs e)
        {
            //string salt = txtPassword.Text;
            //string SAltHashPAssword = "";
            //salt = new Random(DateTime.Now.Millisecond).Next(100000, 1000000).ToString();
            //SAltHashPAssword = GjeneroSalt.GjeneroSAltPAsswod(salt, txtPassword.Text);


            _Gjinia = (string)(rbt_MA.Checked ? "Mashkull" : "Femer");

            string _Query = "insert into tbl_Admini (Emri,Mbiemri,Password,Ditlindja,Vendlindja,Gjinia,Tel,Email) Values" +
              "('" + txtEmri.Text + "','" + txtMbiemri.Text + "','" + txtPassword.Text + "','" + dtpDitlindja.Text + "','" + txtVendlindja.Text + "','"
              + _Gjinia + "','" + txtTel.Text + "','" + txtEmail.Text + "');";

            string _Mesazhi = objDB.InsUpdDel(_Query);
            if (_Mesazhi == "")
            {
                lbl_infoA.Text = "Administratori u ruajt me sukse";
            }
            else
            {
                lbl_infoA.Text = "Administratori nuk u ruajt !!";
            }
            Pastro();
        }

        private void btnAnuloA_Click(object sender, EventArgs e)
        {
            Pastro();
            lbl_infoA.Text = "";
        }

        private void validotext(object aa, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122))
            {
                e.Handled = true;
            }

        }

        private void validonumr(object aa, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void validemail(object aa, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void txtEmri_KeyPress(object sender, KeyPressEventArgs e)
        {
            validotext(sender, e);
        }

        private void txtMbiemri_KeyPress(object sender, KeyPressEventArgs e)
        {
            validotext(sender, e);
        }

        private void txtVendlindja_KeyPress(object sender, KeyPressEventArgs e)
        {
            validotext(sender, e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validonumr(sender, e);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            validemail(sender, e);
        }

        private void frm_SHA_Load(object sender, EventArgs e)
        {
            if (objident.Gjuha == 1)
            {
               
                Anglisht();
            }
            else
            {
                Shqip();
            }

        }
        public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            btnAnuloA.Text = rm.GetString("btnAnuloA");
            btnRuajeA.Text = rm.GetString("btnRuajeA");
            lbl_DA.Text = rm.GetString("lbl_DA");
            lbl_EA.Text = rm.GetString("lbl_EA");
            lbl_EmailA.Text = rm.GetString("lbl_EmailA");
            lbl_infoA.Text = rm.GetString("lbl_infoA");
            lbl_MA.Text = rm.GetString("lbl_MA");
            lbl_PA.Text = rm.GetString("lbl_PA");
            lbl_TA.Text = rm.GetString("lbl_TA");
            lbl_VA.Text = rm.GetString("lbl_VA");
            

        }




        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            btnAnuloA.Text = rm.GetString("btnAnuloA");
            btnRuajeA.Text = rm.GetString("btnRuajeA");
            lbl_DA.Text = rm.GetString("lbl_DA");
            lbl_EA.Text = rm.GetString("lbl_EA");
            lbl_EmailA.Text = rm.GetString("lbl_EmailA");
            lbl_infoA.Text = rm.GetString("lbl_infoA");
            lbl_MA.Text = rm.GetString("lbl_MA");
            lbl_PA.Text = rm.GetString("lbl_PA");
            lbl_TA.Text = rm.GetString("lbl_TA");
            lbl_VA.Text = rm.GetString("lbl_VA");
        }

    }
}
