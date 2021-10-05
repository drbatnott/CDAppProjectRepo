using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDProjectApp
{
    public partial class Form1 : Form
    {
        string currentGenre;
        CDDataClass currentCD;
        List<CDDataClass> cdList;
        public Form1()
        {
            InitializeComponent();
            cdList = new List<CDDataClass>();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGenre = genreComboBox.Items[genreComboBox.SelectedIndex].ToString();
            addDataToListButton.Enabled = true;
        }

        private void addDataToListButton_Click(object sender, EventArgs e)
        {
            currentCD = new CDDataClass(currentGenre);
            cdList.Add(currentCD);
            saveToolStripMenuItem.Enabled = true;
            //Next we would display this in a list box on the screen
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genreComboBox.Visible = true;
            genreLabel.Visible = true;
            addDataToListButton.Visible = true;
            addDataToListButton.Enabled = false;
            cdList = new List<CDDataClass>();
            genreComboBox.SelectedIndex = 0;
        }
    }
}
