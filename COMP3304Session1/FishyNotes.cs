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
    }
}
