
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
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();
            fBicycle fb = new fBicycle(bicycle);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.Add(bicycle);

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
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
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
                            sw.Write(bicycle.Model + "\t" + bicycle.Year + "\t" + bicycle.Colour + " \t" + bicycle.Price +
                                " \t" + bicycle.FrameLoadCapacity + "\t" + bicycle.Weight + " \t" + bicycle.WasUsed +
                            "\t " + bicycle.WasDamaged + "\t\n");
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.bicycles)|*.bicycles|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (Bicycle bicycle in bindSrcBicycles.List)
                    {
                        bw.Write(bicycle.Model);
                        bw.Write(bicycle.Year); bw.Write(bicycle.Colour);
                        bw.Write(bicycle.Price); bw.Write(bicycle.FrameLoadCapacity);
                        bw.Write(bicycle.Weight);
                        bw.Write(bicycle.WasUsed);
                        bw.Write(bicycle.WasDamaged);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Bicycle bicycle = new Bicycle(split[0], int.Parse(split[1]), split[2],
                        int.Parse(split[3]), int.Parse(split[4]), double.Parse(split[5]), bool.Parse(split[6]), bool.Parse(split[7]));
                        bindSrcBicycles.Add(bicycle);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n {ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.bicycles)|*.bicycles|All files (*.*)|*.* ";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    Bicycle bicycle; while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        bicycle = new Bicycle();
                        for (int i = 1; i <= 8; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    bicycle.Model = br.ReadString();
                                    break;
                                case 2:
                                    bicycle.Year = br.ReadInt32(); break;
                                case 3:
                                    bicycle.Colour = br.ReadString(); break;
                                case 4:
                                    bicycle.Price = br.ReadInt32();
                                    break;
                                case 5:
                                    bicycle.FrameLoadCapacity = br.ReadInt32();
                                    break;
                                case 6:
                                    bicycle.Weight = br.ReadDouble();
                                    break;
                                case 7:
                                    bicycle.WasUsed = br.ReadBoolean();
                                    break;
                                case 8:
                                    bicycle.WasDamaged = br.ReadBoolean();
                                    break;
                            }
                        }
                        bindSrcBicycles.Add(bicycle);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: {0}", ex.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
            }
        }
    }
}




