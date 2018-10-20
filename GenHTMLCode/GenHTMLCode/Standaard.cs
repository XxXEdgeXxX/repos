using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenHTMLCode
{
    [Serializable]
    public class Standaard
    {
        
        public string CSS;
        public string Title;
        public Standaard() { }
        public Standaard(string ATitle, string ACSS)
        {
        
            CSS = ACSS;
            Title = ATitle;
        }
        public void ChangeVars(string ATitle, string ACSS)
        {
            Title = ATitle;
            CSS = ACSS;
        }


    }
}
