using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyNote
{
    public delegate void RemoveNoteDeligate(int id);

    public class Delegates
    {
        public void RemoveNote(int id)
        {
            //TODO:Remove the note after the 'X' was pressed
            Console.WriteLine("This deligate is for removing the FishyNote after 'X' was pressed");
        }
    }
}
