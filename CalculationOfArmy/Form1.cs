using CalculationOfArmy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationOfArmy
{
    public partial class Form1 : Form
    {
        private Army _army;
        public Form1()
        {
            InitializeComponent();
            _army = null;
        }

        private void btnGenerateArmy_Click(object sender, EventArgs e)
        {
            _army = new Army();
            lbArmy.Items.Clear();

            for(int i = 0; i < _army.Units.Count; i++)
            {
                lbArmy.Items.Add(_army.Units[i]);
            }

        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            if(_army != null)
            {
                MessageBox.Show($"Загальна ціна армії на день: ${_army.GetPrice()}. Середня швидкість: {Math.Round(_army.GetAverageSpeed(), 2)}",
                    "Результат обрахування:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"З початку згенеруйте армію!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
