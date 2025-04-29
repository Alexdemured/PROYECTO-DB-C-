using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TodosLosCamposLlenos())
            {
                AgregarAFila();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos!", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TodosLosCamposLlenos()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox4.Text) &&
                   !string.IsNullOrWhiteSpace(textBox5.Text) &&
                   !string.IsNullOrWhiteSpace(textBox6.Text) &&
                   !string.IsNullOrWhiteSpace(textBox7.Text) &&
                   !string.IsNullOrWhiteSpace(textBox8.Text) &&
                   !string.IsNullOrWhiteSpace(textBox9.Text) &&
                   !string.IsNullOrWhiteSpace(textBox10.Text);
        }

        private void AgregarAFila()
        {
            dataGridView1.Rows.Add(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                checkBox1.Checked,
                textBox9.Text,
                textBox10.Text
            );
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            checkBox1.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value?.ToString();
                textBox2.Text = row.Cells[1].Value?.ToString();
                textBox3.Text = row.Cells[2].Value?.ToString();
                textBox4.Text = row.Cells[3].Value?.ToString();
                textBox5.Text = row.Cells[4].Value?.ToString();
                textBox6.Text = row.Cells[5].Value?.ToString();
                textBox7.Text = row.Cells[6].Value?.ToString();
                textBox8.Text = row.Cells[7].Value?.ToString();
                checkBox1.Checked = row.Cells[8].Value != null && (bool)row.Cells[8].Value;
                textBox9.Text = row.Cells[9].Value?.ToString();
                textBox10.Text = row.Cells[10].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                row.Cells[0].Value = textBox1.Text;
                row.Cells[1].Value = textBox2.Text;
                row.Cells[2].Value = textBox3.Text;
                row.Cells[3].Value = textBox4.Text;
                row.Cells[4].Value = textBox5.Text;
                row.Cells[5].Value = textBox6.Text;
                row.Cells[6].Value = textBox7.Text;
                row.Cells[7].Value = textBox8.Text;
                row.Cells[8].Value = checkBox1.Checked;
                row.Cells[9].Value = textBox9.Text;
                row.Cells[10].Value = textBox10.Text;

                MessageBox.Show("Fila editada correctamente.", "Edición Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.CurrentRow != null)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    MessageBox.Show("Fila eliminada correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
            }
            catch { }
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            form2.Show();

            this.Hide();
        }
    }
}
