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
    public partial class Sh_Percakto_Prof_Lenden : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objident = new Identifikohu();
        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            btnAnloP.Text = rm.GetString("btnAnloP");
            btnRuajeP.Text = rm.GetString("btnRuajeP");
            lblLenda.Text = rm.GetString("lblLenda");
            lbl_infoLP.Text = rm.GetString("lbl_infoLP");
            lbl_Profesori.Text = rm.GetString("lbl_Profesori");
        }
        public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            btnAnloP.Text = rm.GetString("btnAnloP");
            btnRuajeP.Text = rm.GetString("btnRuajeP");
            lblLenda.Text = rm.GetString("lblLenda");
            lbl_infoLP.Text = rm.GetString("lbl_infoLP");
            lbl_Profesori.Text = rm.GetString("lbl_Profesori");
        }
        public Sh_Percakto_Prof_Lenden()
        {
            InitializeComponent();
        }


        public void MbushCbo()
        {
            DataSet _Shenimet = objDB.LexoShenime("Select * From tbl_Lenda;"+ "Select * From tbl_Profesorit;");
            if (objDB.MesazhiGabim == "")
            {
                cboLenda.DisplayMember = "Lenda";
                cboLenda.ValueMember = "Id_Lendes";
                cboLenda.DataSource = _Shenimet.Tables[0];
                cboLenda.SelectedIndex = -1;

                cboProfesori.DisplayMember = "EmriMbiemri";
                cboProfesori.ValueMember = "Id_Profesorit";
                cboProfesori.DataSource = _Shenimet.Tables[1];
                cboProfesori.SelectedIndex = -1;

            }
        }

        public void Pastro()
        {
            cboLenda.SelectedIndex = -1;
            cboProfesori.SelectedIndex = -1;
        }


        private void Sh_Percakto_Prof_Lenden_Load(object sender, EventArgs e)
        {
            MbushCbo();
            if(objident.Gjuha==1)
            {
                Anglisht();
            }
            else
            {
                
                Shqip();
            }
        }

        private void btnRuajeP_Click(object sender, EventArgs e)
        {
            string _Query = "insert into tbl_LendetProf(Id_Lendes,Id_Profesorit) Values(" +
    cboLenda.SelectedValue + "," + cboProfesori.SelectedValue + ");";
            string _Mesazhi = objDB.InsUpdDel(_Query);

            if (objDB.MesazhiGabim == "")
            {
                lbl_infoLP.Text = "Te dhenat u ruajten .";
            }
            else
            {
                lbl_infoLP.Text = "Te dhenat nuk u ruajten !!";
            }

            Pastro();
        }

        private void btnAnloP_Click(object sender, EventArgs e)
        {
            Pastro();
        }
    }
}
