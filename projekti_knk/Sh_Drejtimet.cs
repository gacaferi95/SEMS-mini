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
    public partial class Sh_Drejtimet : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();

        Identifikohu objident = new Identifikohu();

        public Sh_Drejtimet()
        {
            InitializeComponent();
        }

        public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            btnAnloD.Text = rm.GetString("");
            btnRuajeD.Text = rm.GetString("");
            lbl_Drejtimi.Text = rm.GetString("");
            lbl_infoD.Text = rm.GetString("");
            lbl_ShD.Text = rm.GetString("");


        }




        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            btnAnloD.Text = rm.GetString("");
            btnRuajeD.Text = rm.GetString("");
            lbl_Drejtimi.Text = rm.GetString("");
            lbl_infoD.Text = rm.GetString("");
            lbl_ShD.Text = rm.GetString("");

        }



        public void MbushiKombot()
        {
            DataSet _Shenimet = objDB.LexoShenime("Select * From tbl_Profesorit; ");
            if (objDB.MesazhiGabim == "")
            {
                cboShefi.DisplayMember = "EmriMbiemri";
                cboShefi.ValueMember = "Id_Profesorit";
                cboShefi.DataSource = _Shenimet.Tables[0];
                cboShefi.SelectedIndex = 0;
            }

        }

        public void Pastro()
        {
            txtDrejtimi.Clear();
            cboShefi.SelectedIndex=-1;
        }



        private void Sh_Drejtimet_Load(object sender, EventArgs e)
        {
            MbushiKombot();
            if (objident.Gjuha == 1)
            {
                Anglisht();
            }
            else
            {
               
                Shqip();
            }
        }

        private void btnRuajeD_Click(object sender, EventArgs e)
        {
            string Query = "INSERT INTO tbl_Drejtimi(Drejtimi,Shefi_Depertamentit) " +
                       "VALUES('" + txtDrejtimi.Text + "'," + cboShefi.SelectedValue + ");";
            string _Mesazhi = objDB.InsUpdDel(Query);
            if (_Mesazhi == "")
            {
                lbl_infoD.Text = "Drejtimi u Ruajt.";
            }
            else
            {
                lbl_infoD.Text = ("Drejtimi nuk u Ruajt !!");
            }
            Pastro();
        }

        private void btnAnloD_Click(object sender, EventArgs e)
        {
            Pastro();
            lbl_infoD.Text = "";
        }
    }
}
