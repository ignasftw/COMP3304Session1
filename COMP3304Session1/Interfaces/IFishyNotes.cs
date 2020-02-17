using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IFishyNotes
    {
        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        void AddText(int id, string text);

        /*
         * Adds 'FishyNote''s text into a dictionary
         * int id - id of the FishyNote
         * string text - text content of the FishyNote
         */
        string UpdateText(int id);

        /*
         * Removes text from the FishyNote
         */
        void RemoveText(int id);

        void RemoveNote(int id);
    }
}
