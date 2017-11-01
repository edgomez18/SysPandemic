﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    public partial class topay : Form
    {
        public topay()
        {
            InitializeComponent();
        }

        private void topay_Load(object sender, EventArgs e)
        {
            loadprocedure();
        }
        private void loadprocedure()
        {
            DBManager c = new DBManager();
            string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, [procedure] as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from [procedure]";
            c.load_dgv(dataGridView1, query);




            //spatient_rbtn.PerformClick();
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure", cnx);
            //    DataTable tabla = new DataTable("Procedimientos");
            //    adac.Fill(tabla);
            //    dataGridView1.DataSource = tabla;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            DBManager c = new DBManager();

            try
            {
                if (snopay_rbtn.Checked)
                {
                    string status = "NO PAGADO";
                    string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where statuspay = '" + status + "'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (spay_rbtn.Checked)
                {
                    string status = "PAGADO";
                    string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where statuspay = '" + status + "'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (search_txt.Text.Length == 0)
                {
                    string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure";
                    c.load_dgv(dataGridView1, query);
                }
                else if (sid_rbtn.Checked)
                {
                   string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where idprocedure like '%" + search_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (spatient_rbtn.Checked)
                {
                    string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where namepatient like '%" + search_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (sdoctor_rbtn.Checked)
                {
                    string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where namedoctor like '%" + search_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (sprocedure_rbtn.Checked)
                {
                    string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where procedure like '%" + search_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            loadprocedure();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addsubprocedure frm = new addsubprocedure();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idsubprocedure_txt.Text = act.Cells["ID"].Value.ToString();
            frm.spnamepatient_txt.Text = act.Cells["Paciente"].Value.ToString();
            frm.spnamedoctor_txt.Text = act.Cells["Doctor"].Value.ToString();
            frm.sprocedure_txt.Text = act.Cells["Procedimiento"].Value.ToString();
            frm.sprealpay_txt.Text = act.Cells["Precio"].Value.ToString();
            frm.spiscoverage_txt.Text = act.Cells["Cobertura"].Value.ToString();
            frm.sppricepay_txt.Text = act.Cells["Total"].Value.ToString();
            frm.status_txt.Text = act.Cells["Credito"].Value.ToString();
            string pay = act.Cells["Credito"].Value.ToString();

           


            if (pay == "NO PAGADO")
            {
                frm.printpurchase_btn.Hide();
            }
            else if (pay == "")
            {
                frm.printpurchase_btn.Hide();
            }
            else if (pay == "PAGADO")
            {
                frm.checkout_btn.Hide();
            }
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
