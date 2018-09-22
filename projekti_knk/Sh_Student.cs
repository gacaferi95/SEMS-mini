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
    public partial class Sh_Student : Form
    {
        LidhjaMe_DB objDb = new LidhjaMe_DB();
        Identifikohu objiden = new Identifikohu();
        string _Gjina = "";

        public Sh_Student()
        {
            InitializeComponent();
        }

        private void btnRuaje_Click(object sender, EventArgs e)
        {

        }
        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            btnRuajeS.Text = rm.GetString("btnRuajeS");
            btnAnuloS.Text = rm.GetString("btnAnuloS");
            lbl_DP.Text = rm.GetString("lbl_DP");
            lbl_DrejtimiP.Text = rm.GetString("lbl_DrejtimiP");
            lbl_DRP.Text = rm.GetString("lbl_DRP");
            lbl_EmailP.Text = rm.GetString("lbl_EmailP");
            lbl_EP.Text = rm.GetString("lbl_EP");
            lbl_infoS.Text = rm.GetString("lbl_infoS");
            lbl_MP.Text = rm.GetString("lbl_MP");
            lbl_PP.Text = rm.GetString("lbl_PP");
            lbl_TP.Text = rm.GetString("lbl_TP");
            lbl_VP.Text = rm.GetString("lbl_VP");
            grb_GJP.Text = rm.GetString("grb_GJP");
            rbt_MP.Text = rm.GetString("rbt_MP");
            rbt_FP.Text = rm.GetString("rbt_FP");
        }
        public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            btnRuajeS.Text = rm.GetString("btnRuajeS");
            btnAnuloS.Text = rm.GetString("btnAnuloS");
            lbl_DP.Text = rm.GetString("lbl_DP");
            lbl_DrejtimiP.Text = rm.GetString("lbl_DrejtimiP");
            lbl_DRP.Text = rm.GetString("lbl_DRP");
            lbl_EmailP.Text = rm.GetString("lbl_EmailP");
            lbl_EP.Text = rm.GetString("lbl_EP");
            lbl_infoS.Text = rm.GetString("lbl_infoS");
            lbl_MP.Text = rm.GetString("lbl_MP");
            lbl_PP.Text = rm.GetString("lbl_PP");
            lbl_TP.Text = rm.GetString("lbl_TP");
            lbl_VP.Text = rm.GetString("lbl_VP");
            grb_GJP.Text = rm.GetString("grb_GJP");
            rbt_MP.Text = rm.GetString("rbt_MP");
            rbt_FP.Text = rm.GetString("rbt_FP");
            

        }
        
        private void Sh_Student_Load(object sender, EventArgs e)
        {
            if(objiden.Gjuha==1)
            {
                Anglisht();
            }
            else
            {
               
                Shqip();
            }
            MbushiKombot();
        }

        public void MbushiKombot()
        {
            DataSet _Shenimet =objDb.LexoShenime("Select * From tbl_Drejtimi; ");
            if (objDb.MesazhiGabim == "")
            {
                cboDrejtimi.DisplayMember = "Drejtimi";
                cboDrejtimi.ValueMember = "Drejtimi_Id";
                cboDrejtimi.DataSource = _Shenimet.Tables[0];
                cboDrejtimi.SelectedIndex = -1;
            }
        }

        public void Pastro()
        {
            txtEmri.Clear();
            txtMbiemri.Clear();
            txtPassword.Clear();
            dtpDitlindja.Value = DateTime.Now;
            txtVendlindja.Clear();
            _Gjina = "";
            txtTel.Clear();
            txtEmail.Clear();
        }

        private void btnRuajeS_Click(object sender, EventArgs e)
        {
            _Gjina = (string)(rbt_MP.Checked ? "Mashkull" : "Femer");

            string Query = "insert into tbl_Student(Emri,Mbiemri,Password,Ditlindja,Vendlindja,Gjinia,Tel,Email,Drejtimi_ID,Data_Regjistrimit)" +
               "VALUES('" + txtEmri.Text + "','" + txtMbiemri.Text + "','" + txtPassword.Text + "','" + dtpDitlindja.Text + "','" + txtVendlindja.Text + "','" +
                _Gjina + "','" + txtTel.Text + "','" + txtEmail.Text + "'," + cboDrejtimi.SelectedValue + ",'" + dtpRegjistrimi.Text + "');";

            string _Mesazhi = objDb.InsUpdDel(Query);

            if (_Mesazhi == "")
            {
                lbl_infoS.Text = "Studenti u regjistrua me sukses.";
            }
            else
            {
                lbl_infoS.Text = "Studenti nuk u regjistrua me sukses.";
            }

            Pastro();
        }

        private void btnAnuloS_Click(object sender, EventArgs e)
        {
            Pastro();
            lbl_infoS.Text = "";
        }
    }
}
