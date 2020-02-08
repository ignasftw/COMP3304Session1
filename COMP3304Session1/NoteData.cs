using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    class NoteData : INoteText, INotes
    {
        //Declairing an int, which will show current note's id, used for assigning notes, call it '_id'
        private int _id = 0;
        //Declaire a Form, which will store an instance for a note, call it'_newNote'
        private List<Form> _notes = new List<Form>();
        //Declaire a Disctionary, which will store Note's text, call it '_noteText'
        private Dictionary<int, string> _noteText = new Dictionary<int, string>();

        public void AddNote(INotes parentref)
        {
            Console.WriteLine("FishyNote " + _id + ": has requested to be created.");
            //Adding the FishNote to the list
            _notes.Add(new FishyNote(parentref, _id));
            //Showing the last element created
            _notes.Last().Show();
            //Increasing id count by 1
            _id++;
        }

        public void RemoveNote(int id)
        {
            _notes[id].Dispose();
            //_notes.Remove(_notes[id]);
        }
    }
}
