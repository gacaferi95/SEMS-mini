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


    public  partial class Identifikohu : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        int KendiS = 6;//ashtu qe si te starton forma me vizatu diqka
        int KendiM = 6;
        int KendiO = 30;
        int _startkendiM = (DateTime.Now.Minute * 6) - 90;
        int _startkendiO = ((DateTime.Now.Hour % 12) * (30)) - 90;
        int _startkendiS = (DateTime.Now.Second * 6) - 90;


        public Identifikohu()
        {
            InitializeComponent();
        }
        public int Gjuha;
        //ORA
        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics objgrafika = e.Graphics;

            SolidBrush brushaB = new SolidBrush(Color.Blue);
            SolidBrush brushaW = new SolidBrush(Color.White);
            SolidBrush brushaR = new SolidBrush(Color.Red);
            SolidBrush brushaBl = new SolidBrush(Color.Black);
            SolidBrush brushaG = new SolidBrush(Color.Silver);

            //duhet me pyt qqfar rrethi jemi


            objgrafika.FillPie(brushaG, 200, 50, 230, 230, 0, 360);
            objgrafika.DrawString("12", new Font("Arial", 10), brushaBl, 305, 50);
            objgrafika.DrawString("6", new Font("Arial", 10), brushaBl, 305, 265);
            objgrafika.DrawString("9", new Font("Arial", 10), brushaBl, 202, 160);
            objgrafika.DrawString("3", new Font("Arial", 10), brushaBl, 417, 160);
            objgrafika.FillPie(brushaW, 215, 65, 200, 200, 0, 360);


            //per sekonda
            objgrafika.FillPie(brushaB, 215, 65, 200, 200, _startkendiS, KendiS);
            objgrafika.FillPie(brushaW, 215, 65, 200, 200, _startkendiS, KendiS - 6);


            //per minuta
            objgrafika.FillPie(brushaR, 215, 65, 200, 200, _startkendiM, KendiM);
            objgrafika.FillPie(brushaW, 215, 65, 200, 200, _startkendiM, KendiM - 6);


            //per Ore

            objgrafika.FillPie(brushaBl, 215, 65, 200, 200, _startkendiO, KendiO);
            objgrafika.FillPie(brushaW, 215, 65, 200, 200, _startkendiO, KendiO - 30);
        }

        private void btnRuaje_Click(object sender, EventArgs e)
        {
             string Perdorusi = txtPerdorusi.Text;
             string _Query= "";


            if (Perdorusi.Substring(0, 1) == "1" && Perdorusi.Length==7)
            {
                _Query = "Select * from tbl_Admini where Id_Admin='" + txtPerdorusi.Text + "' and Password=+'" + txtFjalkalimi.Text + "';";
                DataSet shenime = objDB.LexoShenime(_Query);

                if (shenime.Tables[0].Rows.Count > 0)
                {
                    if (Gjuha == 1)
                    {
                        
                        MessageBox.Show("Welcome Administrator", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mire se Erdhet Administrator", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Forma_Admin frmAdmin = new Forma_Admin(txtPerdorusi.Text);
                    frmAdmin.Show();
                }
                else
                {
                    if (Gjuha == 1)
                    {
                       
                        MessageBox.Show("You enter a wrong information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nuk keni dhënë informata te sakta", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Perdorusi.Substring(0, 1) == "2" && Perdorusi.Length == 7)
            {
                _Query = "Select * from tbl_Student where Id_Student='" + txtPerdorusi.Text + "' and Password=+'" + txtFjalkalimi.Text + "';";
                DataSet shenime = objDB.LexoShenime(_Query);

                if (shenime.Tables[0].Rows.Count > 0)
                {
                    if (Gjuha == 1)
                    {
                        
                        MessageBox.Show("Weclome Student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mire se Erdhet Student", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Forma_Student frmStudent = new Forma_Student(txtPerdorusi.Text);
                    frmStudent.Show();

                }
                else
                {
                    if (Gjuha == 1)
                    {
                        
                        MessageBox.Show("You enter a wrong Username or Password", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nuk keni dhënë informata te sakta", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Perdorusi.Substring(0, 1) == "3" && Perdorusi.Length == 7)
            {
                _Query = "Select * from tbl_Profesorit where Id_Profesorit='" + txtPerdorusi.Text + "' and Password=+'" + txtFjalkalimi.Text + "';";
                DataSet shenime = objDB.LexoShenime(_Query);

                if (shenime.Tables[0].Rows.Count > 0)
                {
                    if (Gjuha == 1)
                    {
                       
                        MessageBox.Show("Welcome dear Profesor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mire se Erdhet Profesor", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Forma_Profesorit frmProf = new Forma_Profesorit(txtPerdorusi.Text);
                    frmProf.Show();
                }
                else
                {
                    if (Gjuha == 1)
                    {
                        
                        MessageBox.Show("You enter a wrong information", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Nuk keni dhënë informata te sakta", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (Gjuha == 1)
                {
                   
                    MessageBox.Show("You enter a wrong information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nuk keni dhënë informata te sakta", "Informat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //this.Hide();
        }

        private void tmrSekonda_Tick(object sender, EventArgs e)
        {
            if (KendiS < 360)
            {
                KendiS += 6;
            }
            else
            {
                KendiS = 6;

            }
            this.Invalidate();
        }

        private void tmrMinuta_Tick(object sender, EventArgs e)
        {
            if (KendiM < 360)
            {
                KendiM += 6;
            }
            else
            {
                KendiM = 6;

            }
            this.Invalidate();
        }

        private void tmrOra_Tick(object sender, EventArgs e)
        {
            if (KendiO < 360)
            {
                KendiO += 30;
            }
            else
            {
                KendiO = 30;

            }
            this.Invalidate();
        }

        private void Identifikohu_Load(object sender, EventArgs e)
        {

        }

        private void rdbSHQIP_CheckedChanged(object sender, EventArgs e)
        {
            
            Assembly a =Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            lbl_ID.Text = rm.GetString("lbl_ID");
            lblPassword.Text = rm.GetString("lblPassword");
            btnAnulo.Text = rm.GetString("btnAnulo");
            btnRuaje.Text = rm.GetString("btnRuaje");
            Gjuha = 2;

        }

        private void rdbAnglisht_CheckedChanged(object sender, EventArgs e)
        {
           
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.anglisht", a);
            lbl_ID.Text = rm.GetString("lbl_ID");
            lblPassword.Text = rm.GetString("lblPassword");
            btnAnulo.Text = rm.GetString("btnAnulo");
            btnRuaje.Text = rm.GetString("btnRuaje");
            Gjuha = 1;

        }
    }
}

