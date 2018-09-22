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
    public partial class Sh_Lendet : Form
    {
        LidhjaMe_DB objDB = new LidhjaMe_DB();
        Identifikohu objident = new Identifikohu();

        public Sh_Lendet()
        {
            InitializeComponent();
        }


        public void Pastro()
        {
            txtLenda.Clear();
            txtECTS.Clear();
            txtOre.Clear();
            txtLloji.Clear();
            txtSemestri.Clear();
        }



        private void btnRuajeL_Click(object sender, EventArgs e)
        {
            string _Query = "insert into tbl_Lenda (Lenda,ECTS,Ore,Lloji,Semestri) Values" +
                 "('" + txtLenda.Text + "','" + txtECTS.Text + "','" + txtOre.Text + "','" + txtLloji.Text + "','" + txtSemestri.Text + "');";

            string _Mesazhi = objDB.InsUpdDel(_Query);
            if (_Mesazhi == "")
            {
                lbl_infoL.Text = "Lënda u Regjistrua.";
            }
            else
            {
                lbl_infoL.Text = "Lënda nuk u Ruajt !!";
            }
            Pastro();
        }

        private void btnAnuloL_Click(object sender, EventArgs e)
        {
            Pastro();
            lbl_infoL.Text = "";
        }

        private void Sh_Lendet_Load(object sender, EventArgs e)
        {
            if(objident.Gjuha==1)
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
            btnAnuloL.Text = rm.GetString("btnAnuloL");
            btnRuajeL.Text = rm.GetString("btnRuajeL");
            lblETCs.Text = rm.GetString("lblETCs");
            lblLenda.Text = rm.GetString("lblLenda");
            lblLloji.Text = rm.GetString("lblLloji");
            lblOre.Text = rm.GetString("lblOre");
            lblSemestri.Text = rm.GetString("lblSemestri");
            lbl_infoL.Text = rm.GetString("lbl_infoL");
            
        }






        public void Shqip()
        {
            Assembly a = Assembly.Load("Projekti_KNK");
            ResourceManager rm = new ResourceManager("Projekti_KNK.Gjuha.Shqip1", a);
            btnAnuloL.Text = rm.GetString("btnAnuloL");
            btnRuajeL.Text = rm.GetString("btnRuajeL");
            lblETCs.Text = rm.GetString("lblETCs");
            lblLenda.Text = rm.GetString("lblLenda");
            lblLloji.Text = rm.GetString("lblLloji");
            lblOre.Text = rm.GetString("lblOre");
            lblSemestri.Text = rm.GetString("lblSemestri");
            lbl_infoL.Text = rm.GetString("lbl_infoL");
        }
    }
}