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
    public partial class agrescitas : Form
    {
        public agrescitas()
        {
            InitializeComponent();
        }

        private void agrescitas_Load(object sender, EventArgs e)
        {
            string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1, query);
            
            query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff";
            c.load_dgv(dataGridView2, query);
               
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            

            string query = "INSERT INTO datem(idpatient,namepa,iddoctor,namedoctor,assist,date,time) values('" + txtidpa.Text + "','" + txtpaciente.Text + "','" + txtiddo.Text + "','" + txtdoct.Text + "','Pendiente','" + dtpfecha.Text + "','" + dtphora.Text + "')";
            DBManager c = new DBManager();
            c.command(query);
            txtidpa.Clear();
            txtpaciente.Clear();
            txtdoct.Clear();
            txtiddo.Clear();



            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    string comando = "INSERT INTO datem(idpatient,namepa,iddoctor,namedoctor,assist,date,time) values('" + txtidpa.Text + "','" + txtpaciente.Text + "','" + txtiddo.Text + "','" + txtdoct.Text + "','Pendiente','" + dtpfecha.Text + "','" + dtphora.Text + "')";
            //    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);


            //    if (insertion.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Se agrego correctamente");
            //        txtidpa.Clear();
            //        txtpaciente.Clear();
            //        txtdoct.Clear();
            //        txtiddo.Clear();
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE datem  set idpatient ='" + txtidpa.Text + "', namepa ='" + txtpaciente.Text + "', iddoctor = '" + txtiddo.Text + "', namedoctor = '" + txtdoct.Text + "', date = '" + dtpfecha.Text + "', time = '" + dtphora.Text + "' where id = '" + txtid.Text + "'";
                    DBManager c = new DBManager();
                    c.command(query);
                }
                else if (result == DialogResult.No)
                {

                }

            



            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        string comando = "UPDATE datem  set idpatient ='" + txtidpa.Text + "', namepa ='" + txtpaciente.Text + "', iddoctor = '" + txtiddo.Text + "', namedoctor = '" + txtdoct.Text + "', date = '" + dtpfecha.Text + "', time = '" + dtphora.Text + "' where id = '" + txtid.Text + "'";
            //        SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            //        if (insertion.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Se ha actualizado!");
            //            Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Algo fallo!!!");
            //        }
            //    }
            //    else if (result == DialogResult.No)
            //    {

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            txtidpa.Text = act.Cells["ID"].Value.ToString();
            txtpaciente.Text = act.Cells["Nombre"].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView2.Rows[e.RowIndex];
            txtiddo.Text = act.Cells["ID"].Value.ToString();
            txtdoct.Text = act.Cells["Nombre"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscard();
        }
        private void buscard()
        {
            string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff where namestaff like '%" + txtbuscardoc.Text + "%'";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView2, query);
               
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                    string query = "DELETE FROM datem WHERE id = '" + txtid.Text + "'";
                    DBManager c = new DBManager();
                    c.command(query);
                    Close();
                    

            }
            else if (result == DialogResult.No)
            {
            }



            //DialogResult result = MessageBox.Show("Seguro que desea eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //    try
            //    {
            //        cnx.Open();
            //        string comando = "DELETE FROM datem WHERE id = '" + txtid.Text + "'";
            //        SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            //        if (insertion.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Se ha eliminado!");
            //            Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Algo fue mal");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error");
            //    }

            //}
            //else if (result == DialogResult.No)
            //{
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
                string asis = "Asistio";
                string query = "UPDATE datem  set assist = '" + asis + "' where id = '" + txtid.Text + "'";
                DBManager c = new DBManager();
                c.command(query);

                

        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscarp_TextChanged(object sender, EventArgs e)
        {
            buscarp();
        }
        private void buscarp()
        {
            string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where name like '%" + txtbuscarp.Text + "%'";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1, query);
                
        }

        private void txtbuscardoc_TextChanged(object sender, EventArgs e)
        {
            buscard();
        }
    }
}

