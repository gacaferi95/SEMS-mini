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
    public partial class Forma_Profesorit : Form
    {
        
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objiden = new Identifikohu();
        int StudentiID = 0;
        string _Perdoruesi = "";


        public Forma_Profesorit()
        {
            InitializeComponent();
        }
        public Forma_Profesorit(string Perdoruesi)
        {
            InitializeComponent();
            this._Perdoruesi = Perdoruesi;

        }




        private void Forma_Profesorit_Load(object sender, EventArgs e)
        {

        }


        public int _nrButoni = 1;
        public int _YB = 0;
        private void Forma_Profesorit_Load_1(object sender, EventArgs e)
        {


        }

        private void Forma_Profesorit_Load_2(object sender, EventArgs e)
        {
           
        }
        private void Shfaqlendet(object sender, EventArgs e)
        {

            string Lendet = "select tl.Lenda from tbl_Lenda tl inner join " +

              "tbl_LendetProf tlp on tlp.Id_Lendes = tl.Id_Lendes " +
               "where tlp.Id_Profesorit =" + _Perdoruesi;

            //numerimi
            string numerimi = "select count(tlp.Id_Profesorit) from tbl_Lenda tl inner join " +

              "tbl_LendetProf tlp on tlp.Id_Lendes = tl.Id_Lendes " +
               "where tlp.Id_Profesorit =" + _Perdoruesi;

            DataSet dsLendet = objDB.LexoShenime(Lendet);
            DataSet dsNr = objDB.LexoShenime(numerimi);
            string Nr = dsNr.Tables[0].Rows[0][0].ToString();

            int Nr1 = int.Parse(Nr);

            string[] lendet = new string[Nr1];
            for (int i = 0; i < lendet.Length; i++)
            {
                lendet[i] = dsLendet.Tables[0].Rows[i][0].ToString();
            }




            for (int i = 0; i < lendet.Length; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + i;

                btn.Text = lendet[i];

                string notat1 = "Select n.Id_Lendes as 'Id Lenda',st.Emri,st.Mbiemri,n.Id_Student,n.Nota " +
            "From tbl_Notimi n inner join tbl_Student st on st.Id_Student=n.Id_Student " +
            "inner join tbl_Lenda tl on tl.Id_Lendes=n.Id_Lendes " +
           "Where n.Id_Profesorit = " + _Perdoruesi +
           " and tl.Lenda='" + ((Button)sender).Text + "' and n.Nota=0";

                DataSet ds = objDB.LexoShenime(notat1);
                dgvNota.DataSource = ds.Tables[0];

            }

        }

        private void cmsModifikimi_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuModifiko_Click(object sender, EventArgs e)
        {

        }
        public void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            lblShkyqu.Text = rm.GetString("lblShkyqu");
           

        }




        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            lblShkyqu.Text = rm.GetString("lblShkyqu");
        }

        private void Forma_Profesorit_Load_3(object sender, EventArgs e)
        {
            if (objiden.Gjuha == 1)
            {
               
                Anglisht();
            }
            else
            {
                Shqip();
            }
            string Lendet = "select tl.Lenda from tbl_Lenda tl inner join " +

             "tbl_LendetProf tlp on tlp.Id_Lendes = tl.Id_Lendes " +
              "where tlp.Id_Profesorit =" + _Perdoruesi;

            //numerimi
            string numerimi = "select count(tlp.Id_Profesorit) from tbl_Lenda tl inner join " +

              "tbl_LendetProf tlp on tlp.Id_Lendes = tl.Id_Lendes " +
               "where tlp.Id_Profesorit =" + _Perdoruesi;

            DataSet dsLendet = objDB.LexoShenime(Lendet);
            DataSet dsNr = objDB.LexoShenime(numerimi);
            string Nr = dsNr.Tables[0].Rows[0][0].ToString();
            
            int Nr1 = int.Parse(Nr);
            string[] lendet = new string[Nr1];
            for (int i = 0; i < lendet.Length; i++)
            {
                lendet[i] = dsLendet.Tables[0].Rows[i][0].ToString();
            }



            for (int i = 0; i < lendet.Length; i++)
            {

                Button btn = new Button();
                btn.Name = "btn" + i;

                btn.Text = lendet[i];
                btn.Width = 180;
                btn.Height = 30;
               

                btn.Click += new EventHandler(Shfaqlendet);


                btn.Location = new Point(5, 40 * (i));
                pnlKontrolla.Controls.Add(btn);
            }
        }

        private void lblShkyqu_Click(object sender, EventArgs e)
        {
            this.Close();
            objiden.Show();
        }

        private void mnuModifiko_Click_1(object sender, EventArgs e)
        {
          
        }

        private void modifikoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modifikoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                int _indeksi = dgvNota.CurrentRow.Index;

                dgvNota.Rows[_indeksi].Cells["Nota"].Value.ToString();
                StudentiID = int.Parse(
                    dgvNota.Rows[_indeksi].Cells["Id_Student"].Value.ToString());
                DialogResult dr = MessageBox.Show(
                    "A jeni i sigurte se deshironi modifikoni noten ?",
                    "Infromim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                try
                {
                    if (dr == DialogResult.Yes)
                    {
                        string nota = dgvNota.Rows[_indeksi].Cells["Nota"].Value.ToString();
                        string studentiID = dgvNota.Rows[_indeksi].Cells["Id_Student"].Value.ToString();
                        string lendaID = dgvNota.Rows[_indeksi].Cells["Id Lenda"].Value.ToString();
                        string _Query =
                            "Update tbl_Notimi set Nota=" + nota + " WHERE Id_Student=" + studentiID + " and Id_Lendes=" + lendaID + " ;";
                        string _Mesazhi = objDB.InsUpdDel(_Query);

                        if (_Mesazhi == "")
                        {
                            _Mesazhi = "Ndryshimi u be";
                            Shfaqlendet(sender, e);
                        }
                       
                    }
                }
                catch (Exception ex) {  MessageBox.Show(ex.Message); }


            }
            catch
            {

            }
        }
    }
}
