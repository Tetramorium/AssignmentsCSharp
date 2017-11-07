using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment._2.FlagsOfTheWorld.Model
{
    [XmlRoot("language")]
    public class Language
    {
        [XmlElement("Dutch")]
        public Dutch Dutch { get; set; }
        [XmlElement("French")]
        public French French { get; set; }
        [XmlElement("German")]
        public German German { get; set; }
    }

    public abstract class translationText
    {
        public string StartButton { get; set; }
        public string InfoText_MainMenu { get; set; }
        public string NextButton { get; set; }
        public string WrongAnswer { get; set; }
        public string LabelCountriesRemaining { get; set; }
        public string GameOver { get; set; }
    }

    public class Dutch : translationText
    {
    }
    public class German : translationText
    {
    }

    public class French :translationText
    {
    }
}
