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
    public partial class Sh_Profesor : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objiden = new Identifikohu();
        string _Gjinia = "";

        public Sh_Profesor()
        {
            InitializeComponent();
        }


        public void Pastro()
        {
            txtEmriMbiemri.Clear();
            txtPassword.Clear();
            dtpDitlindja.Value = DateTime.Now;
            txtVendlindja.Clear();
            _Gjinia = "";
            txtTel.Clear();
            txtEmail.Clear();
            txtGradaAkademike.Clear();
        }

        private void btnRuajeP_Click(object sender, EventArgs e)
        {
            // string salt = txtPassword.Text;
            //string SAltHashPAssword = "";

            // salt = new Random(DateTime.Now.Millisecond).Next(100000, 1000000).ToString();
            //SAltHashPAssword =GjeneroSalt.GjeneroSAltPAsswod(salt, txtPassword.Text);

            _Gjinia = (string)(rbt_MP.Checked ? "Mashkull" : "Femer");

            string _Query = "insert into tbl_Profesorit (EmriMbiemri,Password,Ditlindja,Vendlindja,Gjinia,Tel,Email,Grada_Akademike) Values" +
              "('" + txtEmriMbiemri.Text + "','" + txtPassword.Text + "','" + dtpDitlindja.Text + "','" + txtVendlindja.Text + "','"
              + _Gjinia + "','" + txtTel.Text + "','" + txtEmail.Text + "','" + txtGradaAkademike.Text + "');";

            string _Mesazhi = objDB.InsUpdDel(_Query);
            if (_Mesazhi == "")
            {
                lbl_infoP.Text = "Profesori u regjistrua me sukses .";
            }
            else
            {
                lbl_infoP.Text = "Profesori nuk u regjistrua me sukses !!";
            }

            Pastro();
        }

        private void btnAnuloP_Click(object sender, EventArgs e)
        {
            Pastro();
            lbl_infoP.Text = "";
        }

        private void Sh_Profesor_Load(object sender, EventArgs e)
        {
            if(objiden.Gjuha==1)
            {
                Anglisht();
            }
            else
            {
                
                Shqip();
            }
        }
        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            btnAnuloP1.Text = rm.GetString("btnAnuloP1");
            btnRuajeP1.Text = rm.GetString("btnRuajeP1");
            lblEmri.Text = rm.GetString("lblEmri");
            lblPasswoed.Text = rm.GetString("lblPasswoed");
            lbl_Ditlindja1.Text = rm.GetString("lbl_Ditlindja1");
            lbl_Email1.Text = rm.GetString("lbl_Email1");
            lbl_GA.Text = rm.GetString("lbl_GA");
            lbl_infoP.Text = rm.GetString("lbl_infoP");
            lbl_Teli.Text = rm.GetString("lbl_Teli");
            lbl_Vendlindja1.Text = rm.GetString("lbl_Vendlindja1");
            grb_GJA.Text = rm.GetString("grb_GJA");
            rbt_FA.Text = rm.GetString("rbt_FA");
            rbt_MP.Text = rm.GetString("rbt_MP");
        }
        public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            btnAnuloP1.Text = rm.GetString("btnAnuloP1");
            btnRuajeP1.Text = rm.GetString("btnRuajeP1");
            lblEmri.Text = rm.GetString("lblEmri");
            lblPasswoed.Text = rm.GetString("lblPasswoed");
            lbl_Ditlindja1.Text = rm.GetString("lbl_Ditlindja1");
            lbl_Email1.Text = rm.GetString("lbl_Email1");
            lbl_GA.Text = rm.GetString("lbl_GA");
            lbl_infoP.Text = rm.GetString("lbl_infoP");
            lbl_Teli.Text = rm.GetString("lbl_Teli");
            lbl_Vendlindja1.Text = rm.GetString("lbl_Vendlindja1");
            grb_GJA.Text = rm.GetString("grb_GJA");
            rbt_FA.Text = rm.GetString("rbt_FA");
            rbt_MP.Text = rm.GetString("rbt_MP");
        }
    }
}
