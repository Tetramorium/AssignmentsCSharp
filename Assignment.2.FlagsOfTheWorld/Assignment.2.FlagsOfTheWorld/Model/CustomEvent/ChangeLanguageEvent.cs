using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment._2.FlagsOfTheWorld.Model.Enum.Enums;

namespace Assignment._2.FlagsOfTheWorld.Model.CustomEvent
{
    public class ChangeLanguageEventArg : EventArgs
    {
        public AppLanguage AppLanguage { get; set; }
    }
}
