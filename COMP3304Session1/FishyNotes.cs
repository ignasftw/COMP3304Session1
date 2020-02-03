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
        //Declairing a Form, call it'_newNote', which will store an instance for a note
        //private List <FishyNote.IFishyNote> _newNote = new List<FishyNote.IFishyNote>();
        private List<Form> _newNote = new List<Form>();

        private Dictionary <int, string> _noteText = new Dictionary<int, string>();

        FishyNote.Delegates delegates;

        public FishyNotes()
        {
            InitializeComponent();
            delegates = new FishyNote.Delegates();
        }


        private void AddNote_Click(object sender, EventArgs e)
        {
            //Adding the FishNote to the list
            
            //TODO: bellow it shoukd pass the deligate interface to FishyNote
            _newNote.Add(new FishyNote.FishyNote(delegates));

            //Showing the last element created
            _newNote.Last().Show();
        }

        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        public void AddText(int id, string text)
        {
            _noteText.Add(id, text);
        }

        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        public void UpdateText(int id, string text)
        {
            _noteText[id] = text;
        }

        /*
         * Removes text from the FishyNote
         */
        public void RemoveText(int id)
        {
            _noteText.Remove(id);
        }
    }
}
