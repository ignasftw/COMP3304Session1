using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    class NoteData : INoteText, INotes, IFishyNotes
    {
        //Declairing an int, which will show current note's id, used for assigning notes, call it '_id'
        private int _id = 0;
        //Declaire a Form, which will store an instance for a note, call it'_newNote'
        private List<Form> _notes = new List<Form>();
        //Declaire a Disctionary, which will store Note's text, call it '_noteText'
        private Dictionary<int, string> _noteText = new Dictionary<int, string>();

        //Creating and initializing a delegate, this should be created somewhere else and passed as an interface
        Delegates del = new Delegates();

        public void AddNote(INotes parentref)
        {
            Console.WriteLine("FishyNote " + _id + ": has requested to be created.");
            //Adding the FishNote to the list
            _notes.Add(new FishyNote(RemoveNote,AddText, GetNote, _id));
            //Showing the last element created
            _notes.Last().Show();
            //Increasing id count by 1
            _id++;
        }

        public void RemoveNote(int id)
        {
            _notes[id].Dispose();
            //Cannot remove notes from the list yet because then it needs to shift ids
            //_notes.Remove(_notes[id]);
        }

        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        public void AddText(int id, string text)
        {
            if(!_noteText.ContainsKey(id))
            {
                _noteText.Add(id, text);
                Console.WriteLine("Text has been created on {0} note. Text: {1}", id, text);
            }
            else
            {
                Console.WriteLine("\n\n\nThe text already exists on {0} note.", id);
                _noteText[id] = text + "Where is Jack? ";
                Console.WriteLine("The note was updated into: {0}", text);
            }
        }


        /*
         * Returns a text from the dictionary
         * this can be used to retrieve text to update the note
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        public string UpdateText(int id)
        {
            if (_noteText.ContainsKey(id))
                return _noteText[id];
            else return "";
        }


        /*
         * Removes text from the FishyNote
         */
        public void RemoveText(int id)
        {
            if(_noteText.ContainsKey(id))
            {
                Console.WriteLine("...the note {0} was removed.", id);
                _noteText[id] = "";
                _noteText.Remove(id);
            }
        }
    }
}
