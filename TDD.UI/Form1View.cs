using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.UI
{
    public partial class Form1View : Form
    {
        private Form1ViewModel _viewModel = new Form1ViewModel(new DB());
        public Form1View()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", _viewModel, "ATextBoxText");
            textBox2.DataBindings.Add("Text", _viewModel, "BTextBoxText");
            label_result.DataBindings.Add("Text", _viewModel, "ResultLabelText");

        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            _viewModel.CalculationAction();
        }
    }
}
