using System;
using System.Windows.Forms;

namespace toDoListRemaster
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ttTextBoxes.SetToolTip(tbNoteName, "Název poznámky");
            ttTextBoxes.SetToolTip(rtbNote, "Poznámka");
        }
        public string NoteNameText
        {
            get
            {
                return tbNoteName.Text;
            }
            set
            {
                tbNoteName.Text = value;
            }
        }
        public string NoteText
        {
            get
            {
                return rtbNote.Text;
            }
            set
            {
                rtbNote.Text = value;
            }
        }
        //public static string NoteNameText = string.Empty;
        //public static string NoteText = string.Empty;
        private void bSubmit_Click(object sender, EventArgs e)
        {
            if (tbNoteName.Text == string.Empty || rtbNote.Text == string.Empty)
            {
                MessageBox.Show("Prázdný vstup", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NoteNameText = tbNoteName.Text;
                NoteText = rtbNote.Text;
                this.Hide();
            }
        }
    }
}
