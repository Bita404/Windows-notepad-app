using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotepad
{
   public class undoRedo
    {
        string[] textList = new string[100];
        int index;
        int currentPostition;

        public undoRedo()
        {
            index = 0;
            currentPostition = 0;
        }
        public void setText(string s)
        {
            textList[index] = s;
            currentPostition = index;
            index++;
        }
        public string myUndo()
        {
            if (currentPostition > 0)
                return textList[--currentPostition];
            return null;
        }
        public string myRedo()
        {
            if (currentPostition > 0)
                return textList[++currentPostition];
            return null;
        }
    }
}
