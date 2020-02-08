using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface INotes
    {
        void AddNote(INotes parentref);

        void RemoveNote(int id);
    }
}
