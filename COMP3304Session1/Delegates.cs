using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{

    public class Delegates
    {
        /*DELEGATE SIGNATURE:
         * FishyNote asks to be retrived from FishyNotes
         Parameters:
         int id - id of a note which should be retrieved
         IFishyNotes - an interface reference of who should send it it
         */
        public delegate string GetNote(IFishyNotes reff, int id);



        /*DELEGATE SIGNATURE:
         * FishyNote asks to be removen by FishyNotes
         Parameters:
         int id - id of a note which should be removed
         IFishyNotes - an interface reference of who should remove it
         */
        public delegate void RemoveNote(int id);



        /*DELEGATE SIGNATURE:
         * FishyNote asks to be updated by FishyNotes
         Parameters:
         int id - id of a note which should be updated
         IFishyNotes - an interface reference of who should update it it
         */
        public delegate FishyNote UpdateNote(int id, INotes reference);


        /*DELEGATE SIGNATURE:
         * FishyNote asks to add text
         Parameters:
         IFishyNotes - an interface reference of who should update it it
         int id - id of a note which should have
         string text - text that should be added
         */
        public delegate void AddText(IFishyNotes reff, int id, string text);
    }
}
