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

namespace Zad1_Chess_Kamentseva
{
    public partial class ChessCoordinates : Form
    {
        public ChessCoordinates()
        {
            InitializeComponent();
            MessageBox.Show("Введите координаты ладьи x1y1 и координаты фигуры x2y2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_СalculationСoordinates_Click(object sender, EventArgs e) // Этот метод обрабатывает нажатие кнопки
        {
            string input = textBox_coordinates.Text;
            string[] coordinates = input.Split(' ');
            

            if (coordinates.Length != 2)
            {
                MessageBox.Show("Введены некорректные координаты");
                return;
            }

            string rookPosition = coordinates[0];
            string figurePosition = coordinates[1];
            char rookX = rookPosition[0];
            char rookY = rookPosition[1];
            char figureX = figurePosition[0];
            char figureY = figurePosition[1];

            if (rookX < 'a' || rookX > 'h' || rookY < '1' || rookY > '8' ||
                figureX < 'a' || figureX > 'h' || figureY < '1' || figureY > '8')
            {
                MessageBox.Show("Введены некорректные координаты");
                return;
            }

            if (rookX == figureX || rookY == figureY)
            {
                MessageBox.Show("Ладья сможет побить фигуру");
            }
            else
            {
                MessageBox.Show("Ладья не сможет побить фигуру");
            }
        }

        private void textBox_coordinates_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
