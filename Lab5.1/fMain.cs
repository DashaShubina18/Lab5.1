
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5._1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvBicycles.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            column.Width = 60;
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Year";
            column.Name = "Рік";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Colour";
            column.Name = "Колір";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            column.Width = 80;
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FrameLoadCapacity";
            column.Name = "Максимальне навантаження на раму";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weight";
            column.Name = "Вага";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WasUsed";
            column.Name = "Використання";
            column.Width = 60;
            gvBicycles.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "WasDamaged";
            column.Name = "Пошкодження";
            column.Width = 60;
            gvBicycles.Columns.Add(column);

            bindSrcBicycles.Add(new Bicycle("Trek FX 3", 2022, "Black", 850, 120, 12, false, false));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            fBicycle fb = new fBicycle(bicycle);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.Add(bicycle);
                bindSrcBicycles.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = (Bicycle)bindSrcBicycles.List[bindSrcBicycles.Position];

            fBicycle fb = new fBicycle(bicycle);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.List[bindSrcBicycles.Position] = bicycle;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcBicycles.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { bindSrcBicycles.Clear(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (* .txt)|*. txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        foreach (Bicycle bicycle in bindSrcBicycles.List)
                        {
                            sw.Write(bicycle.Model + "\t" + bicycle.Year + "\t" + bicycle.Colour + " \t" + bicycle.Price + " \t" + bicycle.FrameLoadCapacity + "\t" + bicycle.Weight + " \t" + bicycle.WasUsed +
                            "\t " + bicycle.WasDamaged + "\t\n");
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{e]", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}


