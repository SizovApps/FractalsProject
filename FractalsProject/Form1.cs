using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsProject
{
    public partial class Form1 : Form
    {
        Graphics graphics;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // Выравниваем текст по центру.
            chooseLabel.Left = (this.ClientSize.Width - chooseLabel.Width) / 2;
        }

        /// <summary>
        /// Выравниваем текст по центру.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            chooseLabel.Left = (this.ClientSize.Width - chooseLabel.Width) / 2;
        }
        /// <summary>
        /// Скрываем главное меню и открываем форму дерева с такими же параметрами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseFractalTree_Click(object sender, EventArgs e)
        {
            this.Hide();
            TreesForm treesForm = new TreesForm();
            treesForm.Width = this.Width;
            treesForm.Left = this.Left;
            treesForm.Top = this.Top;
            treesForm.WindowState = this.WindowState;
            treesForm.Show();
        }

        /// <summary>
        /// Скрываем главное меню и открываем форму множества Кантора с такими же параметрами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseKantorSet_Click(object sender, EventArgs e)
        {
            KantorSetForm kantorSetForm = new KantorSetForm();
            kantorSetForm.Width = this.Width;
            kantorSetForm.Height = this.Height;
            kantorSetForm.Left = this.Left;
            kantorSetForm.Top = this.Top;
            kantorSetForm.WindowState = this.WindowState;
            kantorSetForm.Show();
            this.Hide();          
        }

        /// <summary>
        /// Скрываем главное меню и открываем форму кривой Коха с такими же параметрами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseCochCurve_Click(object sender, EventArgs e)
        {
            CochCurveForm cochCurveForm = new CochCurveForm();
            cochCurveForm.Width = this.Width;
            cochCurveForm.Left = this.Left;
            cochCurveForm.Top = this.Top;
            cochCurveForm.WindowState = this.WindowState;
            cochCurveForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Скрываем главное меню и открываем форму треугольника Серпинского с такими же параметрами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseTriangle_Click(object sender, EventArgs e)
        {
            TriangleForm triangleForm = new TriangleForm();
            triangleForm.Width = this.Width;
            triangleForm.Left = this.Left;
            triangleForm.Top = this.Top;
            triangleForm.WindowState = this.WindowState;
            triangleForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Скрываем главное меню и открываем форму ковра Серпинского с такими же параметрами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseCarpet_Click(object sender, EventArgs e)
        {
            CarpetForm carpetForm = new CarpetForm();
            carpetForm.Width = this.Width;
            carpetForm.Left = this.Left;
            carpetForm.Top = this.Top;
            carpetForm.WindowState = this.WindowState;
            carpetForm.Show();
            this.Hide();
        }
    }
}
