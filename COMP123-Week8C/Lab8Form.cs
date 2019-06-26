using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Week8C
{
    public partial class Lab8Form : Form
    { 
        public string UserName { get; set; }
        public float UserAge { get; set; }
    
        /// <summary>
        /// this is the constructor for the lab 8 form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for the Lb8 form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }



        /// <summary>
        /// this is the event handler for the submitbutton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = Name_Text_Box.Text;
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = Name_Text_Box + "" + AgeTextBox.Text;
            Name_Text_Box.Text = string.Empty;
            AgeTextBox.Text = string.Empty;

        }

        
        private void Lab8Form_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}
