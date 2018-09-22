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
    public partial class Forma_Admin : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objiden = new Identifikohu();
        string Id_Admin = "";



        public Forma_Admin()
        {
            InitializeComponent();
        }

        public Forma_Admin(string ID_A)
        {
            InitializeComponent();
            Id_Admin=ID_A  ;
        }

        private void tsm_Regjistrimi_S_Click(object sender, EventArgs e)
        {
            Sh_Student frmStudent = new Sh_Student();
            frmStudent.ShowDialog();
            

        }

        private void tsm_Regjistrimi_P_Click(object sender, EventArgs e)
        {
            Sh_Profesor frmProf = new Sh_Profesor();
            frmProf.ShowDialog();
        }

        private void tsm_Regjistrimi_A_Click(object sender, EventArgs e)
        {
            frm_SHA frmAdmin = new frm_SHA();
            frmAdmin.ShowDialog();
        }

        private void tsm_Regjistrimi_D_Click(object sender, EventArgs e)
        {
            Sh_Drejtimet frmDrejtimi = new Sh_Drejtimet();
            frmDrejtimi.ShowDialog();
        }

        private void tsm_Regjistrimi_LeRE_Click(object sender, EventArgs e)
        {
            Sh_Lendet frmLendet = new Sh_Lendet();
            frmLendet.ShowDialog();
        }

        private void tsm_PercaktoProf_Click(object sender, EventArgs e)
        {
            Sh_Percakto_Prof_Lenden frmShPP = new Sh_Percakto_Prof_Lenden();
            frmShPP.ShowDialog();
        }



        private void tsm_Lista_S_Click(object sender, EventArgs e)
        {
            HIDE();

                DataSet ds1 = objDB.LexoShenime("Select * from tbl_Student;");

                if (objDB.MesazhiGabim == "")
                {
                    dgv.DataSource = ds1.Tables[0];
                    dgv.Columns["Id_Student"].Visible = false;//fshe kolonen 
                    dgv.Columns["Password"].Visible = false;//fshe kolonen 
                    dgv.Show();
                }
        }

        private void tsm_Lista_D_Click(object sender, EventArgs e)
        {
            HIDE();

            DataSet ds = objDB.LexoShenime("Select td.Drejtimi,tp.EmriMbiemri from tbl_Drejtimi td inner join tbl_Profesorit tp on tp.Id_Profesorit=td.Shefi_Depertamentit;");

            if (objDB.MesazhiGabim == "")
            {
                dgv.DataSource = ds.Tables[0];
                dgv.Show();

            }
        }

        private void tsm_Lista_P_Click(object sender, EventArgs e)
        {
            HIDE();

            DataSet ds1 = objDB.LexoShenime("Select * from tbl_Profesorit;");

            if (objDB.MesazhiGabim == "")
            {
                dgv.DataSource = ds1.Tables[0];
                dgv.Columns["Id_Profesorit"].Visible = false;//fshe kolonen 
                dgv.Columns["Password"].Visible = false;//fshe kolonen 
                dgv.Show();
            }

        }

        private void tsm_Lista_A_Click(object sender, EventArgs e)
        {
            HIDE();

            DataSet ds = objDB.LexoShenime("Select * from tbl_Admini;");

            if (objDB.MesazhiGabim == "")
            {
                dgv.DataSource = ds.Tables[0];
                dgv.Columns["Id_Admin"].Visible = false;//fshe kolonen 
                dgv.Columns["Password"].Visible = false;//fshe kolonen 
                dgv.Show();
            }
        }

        private void tsm_Lista_lL_Click(object sender, EventArgs e)
        {
            HIDE();

            DataSet ds = objDB.LexoShenime("Select * from tbl_Lenda;");

            if (objDB.MesazhiGabim == "")
            {
                dgv.DataSource = ds.Tables[0];
                dgv.Columns["Id_Lendes"].Visible = false;//fshe kolonen 
                dgv.Show();

            }
        }

        private void tsm_Lista_lP_Click(object sender, EventArgs e)
        {
            HIDE();

            DataSet ds = objDB.LexoShenime("Select tl.Lenda,tp.EmriMbiemri from tbl_LendetProf tlp inner join tbl_Lenda tl on tl.Id_Lendes=tlp.Id_Lendes "+
                "inner join tbl_Profesorit tp on tp.Id_Profesorit=tlp.Id_Profesorit ;");

            if (objDB.MesazhiGabim == "")
            {
                dgv.DataSource = ds.Tables[0];
                dgv.Show();

            }
        }
       
        private void Forma_Admin_Load(object sender, EventArgs e)
        {
            DataSet ds = objDB.LexoShenime("Select Emri,Mbiemri from tbl_Admini where Id_Admin='"+ Id_Admin+"' ;");

            dgv.DataSource = ds.Tables[0];

            string _Emri = ds.Tables[0].Rows[0]["Emri"].ToString();
            string _Mbiemri = ds.Tables[0].Rows[0]["Mbiemri"].ToString();
            
            dgv.Hide();
            lbl_Eadmin.Text = _Emri;
            lbl_Madmin.Text = _Mbiemri;
            if (objiden.Gjuha == 1)
            {
                Anglisht();
            }
            else
            {
               
                Shqip();
            }
        }

        public void HIDE()
        {
            lbl_Eadmin.Hide();
            lbl_Madmin.Hide();
            lbl_EA.Hide();
            lbl_MA.Hide();
        }

        private void lbl_Pastro_Click(object sender, EventArgs e)
        {
            lbl_Eadmin.Show();
            lbl_Madmin.Show();
            lbl_EA.Show();
            lbl_MA.Show();

            dgv.Hide();
        }
        
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            lbl_EA.Text = rm.GetString("lbl_EA");
            lbl_Eadmin.Text = rm.GetString("lbl_Eadmin");
            lbl_MA.Text = rm.GetString("lbl_MA");
            lbl_Madmin.Text = rm.GetString("lbl_Madmin");
            lbl_Pastro.Text = rm.GetString("lbl_Pastro");
            tsm_Lista.Text = rm.GetString("tsm_Lista");
            tsm_Lista_A.Text = rm.GetString("tsm_Lista_A"); 
            tsm_Lista_D.Text = rm.GetString("tsm_Lista_D"); 
            tsm_Lista_L.Text = rm.GetString("tsm_Lista_L");
            tsm_Lista_lL.Text = rm.GetString("tsm_Lista_lL");
            tsm_Lista_lP.Text = rm.GetString("tsm_Lista_lP");
            tsm_Lista_P.Text = rm.GetString("tsm_Lista_P");
            tsm_Lista_S.Text = rm.GetString("tsm_Lista_S");
            tsm_PercaktoProf.Text = rm.GetString("tsm_PercaktoProf"); 
            tsm_Regjistrimi.Text = rm.GetString("tsm_Regjistrimi");
            tsm_Regjistrimi_A.Text = rm.GetString("tsm_Regjistrimi_A");
            tsm_Regjistrimi_D.Text = rm.GetString("tsm_Regjistrimi_D");
            tsm_Regjistrimi_L.Text = rm.GetString("tsm_Regjistrimi_L");
            tsm_Regjistrimi_LeRE.Text = rm.GetString("tsm_Regjistrimi_LeRE");
            tsm_Regjistrimi_P.Text = rm.GetString("tsm_Regjistrimi_P");
            tsm_Regjistrimi_S.Text = rm.GetString("tsm_Regjistrimi_S");
            lblShkyqu.Text = rm.GetString("lblShkyqu");



        }
            public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            lbl_EA.Text = rm.GetString("lbl_EA");
            lbl_Eadmin.Text = rm.GetString("lbl_Eadmin");
            lbl_MA.Text = rm.GetString("lbl_MA");
            lbl_Madmin.Text = rm.GetString("lbl_Madmin");
            lbl_Pastro.Text = rm.GetString("lbl_Pastro");
            tsm_Lista.Text = rm.GetString("tsm_Lista");
            tsm_Lista_A.Text = rm.GetString("tsm_Lista_A");
            tsm_Lista_D.Text = rm.GetString("tsm_Lista_D");
            tsm_Lista_L.Text = rm.GetString("tsm_Lista_L");
            tsm_Lista_lL.Text = rm.GetString("tsm_Lista_lL");
            tsm_Lista_lP.Text = rm.GetString("tsm_Lista_lP");
            tsm_Lista_P.Text = rm.GetString("tsm_Lista_P");
            tsm_Lista_S.Text = rm.GetString("tsm_Lista_S");
            tsm_PercaktoProf.Text = rm.GetString("tsm_PercaktoProf");
            tsm_Regjistrimi.Text = rm.GetString("tsm_Regjistrimi");
            tsm_Regjistrimi_A.Text = rm.GetString("tsm_Regjistrimi_A");
            tsm_Regjistrimi_D.Text = rm.GetString("tsm_Regjistrimi_D");
            tsm_Regjistrimi_L.Text = rm.GetString("tsm_Regjistrimi_L");
            tsm_Regjistrimi_LeRE.Text = rm.GetString("tsm_Regjistrimi_LeRE");
            tsm_Regjistrimi_P.Text = rm.GetString("tsm_Regjistrimi_P");
            tsm_Regjistrimi_S.Text = rm.GetString("tsm_Regjistrimi_S");
            lblShkyqu.Text = rm.GetString("lblShkyqu");
        }
       

        private void lblShkyqu_Click(object sender, EventArgs e)
        {
            this.Close();
            objiden.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
