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

        /*METHOD:
         * FishyNote asks to be retrived from FishyNotes
         Parameters:
         int id - id of a note which should be retrieved
         IFishyNotes - an interface reference of who should send it it
             */
        public void AddNote(int id, IFishyNotes reference)
        {

            //After receiving a request Deligate asks FishyNotes to remove FishyNote
            //reference.RemoveNote(id);
        }

        /*METHOD:
         * FishyNote asks to be retrived from FishyNotes
         Parameters:
         int id - id of a note which should be retrieved
         IFishyNotes - an interface reference of who should send it it
             */
        public void GetNote(int id, IFishyNotes reference)
        {
            Console.WriteLine("FishyNote " + id + ": has requested to be retrieved.");

            //After receiving a request Deligate asks FishyNotes to remove FishyNote
            reference.RemoveNote(id);
        }


        /*METHOD:
         * FishyNote asks to be removen by FishyNotes
         Parameters:
         int id - id of a note which should be removed
         IFishyNotes - an interface reference of who should remove it
             */
        public void RemoNote(int id, INotes reference)
        {
            Console.WriteLine("FishyNote " +id +": has requested to be removed.");
            //After receiving a request Deligate asks FishyNotes to remove FishyNote
            reference.RemoveNote(id);
        }


        /*METHOD:
         * FishyNote asks to be updated by FishyNotes
         Parameters:
         int id - id of a note which should be updated
         IFishyNotes - an interface reference of who should update it it
             */
        public FishyNote UpdateNote(int id, INotes reference)
        {
            Console.WriteLine("FishyNote " + id + ": has requested to be updated.");

            //After receiving a request Deligate asks FishyNotes to remove FishyNote
            return new FishyNote(reference, id);
        }
    }
}
