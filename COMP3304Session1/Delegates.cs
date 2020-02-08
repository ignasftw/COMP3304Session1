using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{

    public class Delegates
    {
        /*METHOD:
         * FishyNote asks to be removen by FishyNotes
         Parameters:
         int id - id of a note which should be removed
         IFishyNotes - an interface reference of who should remove it
             */
        public void RemoNote(int id, IFishyNotes reference)
        {
            //TODO:Remove the note after the 'X' was pressed
            Console.WriteLine("FishyNote " +id +": has requested to be removed.");

            //After receiving a request Deligate asks FishyNotes to remove FishyNote
            reference.RemoveNote(id);
        }
    }
}
