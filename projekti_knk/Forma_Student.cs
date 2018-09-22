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
    public partial class Forma_Student : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objiden = new Identifikohu();
        string Perdorus = "";

        public Forma_Student()
        {
            InitializeComponent();
        }

        public Forma_Student(string _Perdorusi)
        {
            InitializeComponent();
            Perdorus = _Perdorusi;
        }
        
        private void Forma_Student_Load(object sender, EventArgs e)
        {
            HIDE();
            pib_Grafika.Hide();
            if (objiden.Gjuha == 1 )
            {
               
                Anglisht();
            }
            else
            {
                Shqip();
            }

        }
        private void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            lbl_LendaP.Text = rm.GetString("lbl_LendaP");
            lbl_NM.Text = rm.GetString("lbl_NM");
            lbl_ParaqitM.Text = rm.GetString("lbl_ParaqitM");
            lbl_Pastro.Text = rm.GetString("lbl_Pastro");
            lbl_ProfP.Text = rm.GetString("lbl_ProfP");
            btnParaqit.Text = rm.GetString("btnParaqit");
            btn_Grafika.Text = rm.GetString("btn_Grafika");
            btn_Pastro.Text = rm.GetString("btn_Pastro");
            btn_Ruaj.Text = rm.GetString("btn_Ruaj");
            btn_transkripti.Text = rm.GetString("btn_transkripti");
            lblShkyqu.Text = rm.GetString("lblShkyqu");

        }
        private void Anglisht()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            lbl_LendaP.Text = rm.GetString("lbl_LendaP");
            lbl_NM.Text = rm.GetString("lbl_NM");
            lbl_ParaqitM.Text = rm.GetString("lbl_ParaqitM");
            lbl_Pastro.Text = rm.GetString("lbl_Pastro");
            lbl_ProfP.Text = rm.GetString("lbl_ProfP");
            btnParaqit.Text = rm.GetString("btnParaqit");
            btn_Grafika.Text = rm.GetString("btn_Grafika");
            btn_Pastro.Text = rm.GetString("btn_Pastro");
            btn_Ruaj.Text = rm.GetString("btn_Ruaj");
            btn_transkripti.Text = rm.GetString("btn_transkripti");
            lblShkyqu.Text = rm.GetString("lblShkyqu");
            

        }

        private void lbl_Pastro_Click(object sender, EventArgs e)
        {
            HIDE();
            pib_Grafika.Hide();

            btnParaqit.Show();
            btn_transkripti.Show();
            btn_Grafika.Show();



        }

        public void HIDE()
        {
            txtKerkLendet.Hide();
            txtNotaMesatare.Hide();
            dgvTranskripta.Hide();
            lbl_NM.Hide();
            cboLenda.Hide();
            cboProfesori.Hide();
            lbl_LendaP.Hide();
            lbl_ParaqitM.Hide();
            lbl_ProfP.Hide();
            btn_Ruaj.Hide();
            btn_Pastro.Hide();

        }

        private void btn_transkripti_Click(object sender, EventArgs e)
        {
            MbusheListen();
            NotaMesatare();
            Kerko();


            txtKerkLendet.Show();
            txtNotaMesatare.Show();
            dgvTranskripta.Show();
            lbl_NM.Show();

            pib_Grafika.Hide();
            //btn_Grafika.Hide();
            cboLenda.Hide();
            cboProfesori.Hide();
            lbl_LendaP.Hide();
            lbl_ParaqitM.Hide();
            lbl_ProfP.Hide();
            btn_Ruaj.Hide();
            btn_Pastro.Hide();
        }

        private void MbusheListen()
        {
            DataSet ds = objDB.LexoShenime("Select ts.Emri,tp.EmriMbiemri,tl.Lenda,tn.Nota from tbl_Notimi tn " +
                    "inner join tbl_Student ts on ts.Id_Student = tn.Id_Student " +
                    "inner join tbl_Lenda tl on tl.Id_Lendes = tn.Id_Lendes " +
                    "inner join tbl_Profesorit tp on tp.Id_Profesorit = tn.Id_Profesorit " +
                    "where tn.Id_Student =" + Perdorus + " and tn.Nota > 5; ");

            if (objDB.MesazhiGabim != "")
            {
                MessageBox.Show("Lista e notave nuk është shfaqur mirë !!");
                return;

            }
            dgvTranskripta.DataSource = ds.Tables[0];
        }

        private void NotaMesatare()
        {
            DataSet ds = objDB.LexoShenime("Select CAST(AVG(tn.Nota) AS DECIMAL(10,2)) as nm from tbl_Notimi tn " +
                    "where tn.Id_Student =" + Perdorus + " and tn.Nota > 5 ;");

            if (objDB.MesazhiGabim != "")
            {
                MessageBox.Show("Nota mesatare nuk është gjetur sakt !!");
                return;
            }

            string myNum = ds.Tables[0].Rows[0]["nm"].ToString();
            txtNotaMesatare.Text = myNum;

        }

        private void Kerko()
        {
            DataSet ds = objDB.LexoShenime("Select tp.EmriMbiemri,tl.Lenda,tl.ECTS,tn.Nota from tbl_Notimi tn " +
                    "inner join tbl_Student ts on ts.Id_Student = tn.Id_Student " +
                    "inner join tbl_Lenda tl on tl.Id_Lendes = tn.Id_Lendes " +
                    "inner join tbl_Profesorit tp on tp.Id_Profesorit = tn.Id_Profesorit " +
                    "where tn.Id_Student =" + Perdorus + " and tn.Nota > 5 and tl.Lenda like'%" + txtKerkLendet.Text + "%' ;");

            if (objDB.MesazhiGabim != "")
            {
                MessageBox.Show("Kerkimi nuk u realizua me sukses !!");
                return;

            }
            dgvTranskripta.DataSource = ds.Tables[0];
        }

        private void btnParaqit_Click(object sender, EventArgs e)
        {
            MbushiKombot();

            cboLenda.Show();
            cboProfesori.Show();
            lbl_LendaP.Show();
            lbl_ParaqitM.Show();
            lbl_ProfP.Show();
            btn_Ruaj.Show();
            btn_Pastro.Show();
            btn_Grafika.Show();
            btn_transkripti.Show();

            dgvTranskripta.Hide();
            txtKerkLendet.Hide();
            txtNotaMesatare.Hide();
            dgvTranskripta.Hide();
            lbl_NM.Hide();
            pib_Grafika.Hide();

        }

        private void btn_Ruaj_Click(object sender, EventArgs e)
        {
            string _Query = "insert into tbl_Notimi (Id_Student,Id_Lendes,Id_Profesorit) Values" +
             "('" + Perdorus + "'," + cboLenda.SelectedValue + "," + cboProfesori.SelectedValue + ");";

            string _Mesazhi = objDB.InsUpdDel(_Query);
            if (_Mesazhi == "")
            {
                lbl_ParaqitM.Text = "Lënda u paraqit me sukses.";
            }
            else
            {
                lbl_ParaqitM.Text = "Paraqitja e lendes deshtoi !!";
            }
            Pastro();
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            Pastro();
            lbl_ParaqitM.Text = "";
        }

        public void Pastro()
        {
            cboLenda.SelectedIndex = -1;
            cboProfesori.SelectedIndex = -1;
        }

        public void MbushiKombot()
        {
            DataSet _Shenimet = objDB.LexoShenime("Select * From tbl_Lenda;" + "Select * From tbl_Profesorit;");
            if (objDB.MesazhiGabim == "")
            {
                cboLenda.DisplayMember = "Lenda";
                cboLenda.ValueMember = "Id_Lendes";
                cboLenda.DataSource = _Shenimet.Tables[0];
                cboLenda.SelectedIndex = -1;
            }
        }

        private void cboLenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _LendaID = 0;
            try
            {
                _LendaID = int.Parse(cboLenda.SelectedValue.ToString());
            }
            catch
            { }

            if (_LendaID > 0)
            {
                DataSet dset = objDB.LexoShenime(
               "Select lp.Id_Profesorit,p.EmriMbiemri " +
               "From tbl_Profesorit p Inner Join " +
               "tbl_LendetProf lp on lp.Id_Profesorit=p.Id_Profesorit Where " +
               "lp.Id_Lendes=" + _LendaID);

                if (objDB.MesazhiGabim == "")
                {
                    cboProfesori.DisplayMember = "EmriMbiemri";
                    cboProfesori.ValueMember = "Id_Profesorit";
                    cboProfesori.DataSource = dset.Tables[0];
                    cboProfesori.SelectedIndex = -1;
                }

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        private void btn_Grafika_Click(object sender, EventArgs e)
        {
            HIDE();
            pib_Grafika.Show();
        }

        private void pib_Grafika_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds = objDB.LexoShenime("Select tn.Nota from tbl_Notimi tn " +
                 "inner join tbl_Student ts on ts.Id_Student = tn.Id_Student " +
                 "where tn.Id_Student =" + Perdorus + " and tn.Nota > 5; ");

            int gjatesia = 0;

            try
            {
                gjatesia = int.Parse(ds.Tables[0].Rows.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim", ex.Message);
            }


            float[] notat = new float[gjatesia];
            for (int i = 0; i < gjatesia; i++)
            {
                //marrim krejt notat ne nje varg
                notat[i] = float.Parse(ds.Tables[0].Rows[i][0].ToString());

            }

            float nota10 = 0;
            float nota9 = 0;
            float nota8 = 0;
            float nota7 = 0;
            float nota6 = 0;

            for (int i = 0; i < gjatesia; i++)
            {
                if (notat[i] == 10)
                    nota10++;
                else
                    if (notat[i] == 9)
                    nota9++;
                else
                    if (notat[i] == 8)
                    nota8++;
                else
                    if (notat[i] == 7)
                    nota7++;
                else
                    if (notat[i] == 6)
                    nota6++;
            }

            float shumaN = nota9 + nota10 + nota8 + nota7 + nota6;

            float N10 = nota10 / shumaN;
            float N9 = nota9 / shumaN;
            float N8 = nota8 / shumaN;
            float N7 = nota7 / shumaN;
            float N6 = nota6 / shumaN;

            Graphics objgrafika = e.Graphics;
            SolidBrush brushaR = new SolidBrush(Color.Red);
            SolidBrush brushaB = new SolidBrush(Color.Blue);
            SolidBrush brushaG = new SolidBrush(Color.Green);
            SolidBrush brushaBl = new SolidBrush(Color.Black);
            SolidBrush brushaO = new SolidBrush(Color.Orange);

            Rectangle katrori = new Rectangle(300, 80, 250, 250);
            if (objiden.Gjuha == 1 || objiden.Gjuha==0)
            {
                objgrafika.DrawString("Nota 10 - Kalter", new Font("Arial", 12), brushaB, new Point(20, 80));
                objgrafika.DrawString("Nota 9  - Kuqe", new Font("Arial", 12), brushaR, new Point(20, 100));
                objgrafika.DrawString("Nota 8  - Gjelbert", new Font("Arial", 12), brushaG, new Point(20, 120));
                objgrafika.DrawString("Nota 7  - Zeze", new Font("Arial", 12), brushaBl, new Point(20, 140));
                objgrafika.DrawString("Nota 6  - Portokallt", new Font("Arial", 12), brushaO, new Point(20, 160));

            }
            else
            {
                objgrafika.DrawString("Grade 10 - Blue", new Font("Arial", 12), brushaB, new Point(20, 50));
                objgrafika.DrawString("Grade 9  - Red", new Font("Arial", 12), brushaR, new Point(20, 70));
                objgrafika.DrawString("Grade 8  - Green", new Font("Arial", 12), brushaG, new Point(20, 90));
                objgrafika.DrawString("Grade 7  - Black", new Font("Arial", 12), brushaBl, new Point(20, 110));
                objgrafika.DrawString("Grade 6  - Orange", new Font("Arial", 12), brushaO, new Point(20, 130));

            }

            if (N10 != 0 && N9 != 0 && N8 != 0 && N7 != 0 && N6 != 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 == 0 && N8 != 0 && N7 != 0 && N6 != 0)
            {


                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                // objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, N10 * 360, N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N8 * 360) + (N10 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N8 * 360) + (N10 * 360) + (N7 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 != 0 && N8 == 0 && N7 != 0 && N6 != 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                //objgrafika.FillPie(brushaG, katrori, N10 * 360, N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N7 * 360), N6 * 360);
            }
            else
                if (N10 != 0 && N9 != 0 && N8 != 0 && N7 == 0 && N6 != 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                //objgrafika.FillPie(brushaBl, katrori, N8 * 360, N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 != 0 && N8 != 0 && N7 != 0 && N6 == 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                // objgrafika.FillPie(brushaO, katrori, N7 * 360, N6 * 360);
            }
            else
                 if (N10 != 0 && N9 == 0 && N8 == 0 && N7 != 0 && N6 != 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                //objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                // objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N7 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 == 0 && N8 != 0 && N7 == 0 && N6 != 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                // objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360), N8 * 360);
                //objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N8 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 == 0 && N8 != 0 && N7 != 0 && N6 == 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                // objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N8 * 360), N7 * 360);
                //objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            //Rasti me 8
            else
                 if (N10 != 0 && N9 != 0 && N8 == 0 && N7 == 0 && N6 != 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                // objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                // objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 != 0 && N8 == 0 && N7 != 0 && N6 == 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                //objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360), N7 * 360);
                // objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
                 if (N10 != 0 && N9 != 0 && N8 != 0 && N7 == 0 && N6 == 0)
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                //objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                //objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            // Shqyrutojm rastet kur N10=0
            else
                 if (N10 == 0 && N9 != 0 && N8 != 0 && N7 != 0 && N6 != 0)
            {

                //  objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
                 if (N10 == 0 && N9 == 0 && N8 != 0 && N7 != 0 && N6 != 0)
            {

                // objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                // objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
                 if (N10 == 0 && N9 != 0 && N8 == 0 && N7 != 0 && N6 != 0)
            {

                //  objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                // objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
                     if (N10 == 0 && N9 != 0 && N8 != 0 && N7 == 0 && N6 != 0)
            {

                // objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                // objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
                if (N10 == 0 && N9 != 0 && N8 != 0 && N7 != 0 && N6 == 0)
            {

                // objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                //objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }
            else
            {

                objgrafika.FillPie(brushaB, katrori, 0, N10 * 360);
                objgrafika.FillPie(brushaR, katrori, N10 * 360, N9 * 360);
                objgrafika.FillPie(brushaG, katrori, (N10 * 360) + (N9 * 360), N8 * 360);
                objgrafika.FillPie(brushaBl, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360), N7 * 360);
                objgrafika.FillPie(brushaO, katrori, (N10 * 360) + (N9 * 360) + (N8 * 360) + (N7 * 360), N6 * 360);
            }

        }
        
        private void lblShkyqu_Click(object sender, EventArgs e)
        {
            this.Close();
            objiden.Show();
        }
    }
}


