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
    public partial class FishyNotes : Form, IFishyNotes
    {

        //Declaire a Container which will store data of _notes, call it '_noteData'
        INotes _noteData = new NoteData();

        public FishyNotes()
        {
            InitializeComponent();
        }

        /*
         * Adds a new 'FishyNote'
         * After the button has been pressed
         */
        private void AddNote_Click(object sender, EventArgs e)
        {
            //Asking NoteData to create a Note
            _noteData.AddNote(_noteData);
        }

        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        public void AddText(int id, string text)
        {
            //_notes[id].Add(text);
        }

        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        public void UpdateText(int id, string text)
        {
            //_notes[id].Text = text;
        }

        /*
         * Removes text from the FishyNote
         */
        public void RemoveText(int id)
        {
            //_notes.Remove(id);
        }

        public void RemoveNote(int id)
        {
            _noteData.RemoveNote(id);
        }
    }
}
