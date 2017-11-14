using Assignment._2.FlagsOfTheWorld.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._2.FlagsOfTheWorld.Model
{
    public static class Translation
    {
        public static XmlController<Language> xmlController = new XmlController<Language>();
        public static Language Language = xmlController.Load("Languages.xml");
    }
}
