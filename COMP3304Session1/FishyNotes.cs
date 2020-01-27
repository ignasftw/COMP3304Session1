using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNotes : Form
    {
        //Declairing a Form, call it'_newNote', which will store an instance for a note
        List <Form> _newNote = new List<Form>();

        public FishyNotes()
        {
            InitializeComponent();
        }


        private void AddNote_Click(object sender, EventArgs e)
        {
            //Adding the FishNote to the list
            _newNote.Add(new FishyNote.FishyNote());
            //Showing the last element created
            _newNote.Last().Show();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    Form _new;
                    //fish fish fish fish fish
                    _new = new FishyNotes();
                    //Showing the last element created
                    _new.Show();
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

    }
}
