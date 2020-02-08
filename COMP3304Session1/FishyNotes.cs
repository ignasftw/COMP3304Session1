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
        //Declairing a Form, which will store an instance for a note, call it'_newNote'
        private List<Form> _notes = new List<Form>();
        //Declairing an int, which will show current note's id, used for assigning notes, call it '_id'
        private int _id =0;
        //Declaire a Container which will store data of _notes, call it '_noteData'
        Container _noteData = new Container();

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
            //Adding the FishNote to the list
            _notes.Add(new FishyNote((IFishyNotes)this, _id));
            //Showing the last element created
            _notes.Last().Show();
            //Increasing id count by 1
            _id++;
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
            _notes[id].Text = text;
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
            _notes[id].Dispose();
            _notes.Remove(_notes[id]);
        }
    }
}
