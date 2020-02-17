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
        //TO-DO change this so Notes would be contained separately from Data
        //Declaire a Container which will store data of _notes, call it '_noteData'
        INotes _noteData = new NoteData();

        public FishyNotes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new 'FishyNote'
        /// After the button has been pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            //Asking NoteData to create a Note
            _noteData.AddNote(_noteData);
        }



        public void RemoveNote(int id)
        {
            _noteData.RemoveNote(id);
        }
    }
}
