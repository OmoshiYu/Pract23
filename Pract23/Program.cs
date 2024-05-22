using System;
using System.Text;

namespace Pract23
{
    public class CodeBuilder
    {
        private StringBuilder _builder = new StringBuilder();
        private int _indentLevel = 0;

        public CodeBuilder IncreaseIndent(int levels = 1)
        {
            _indentLevel += levels;
            return this;
        }

        public CodeBuilder IncreaseTabIndent(int levels = 1)
        {
            _indentLevel += levels * 4;
            return this;
        }

        public CodeBuilder AppendText(string text)
        {
            _builder.Append(new string(' ', _indentLevel)).Append(text);
            return this;
        }

        public CodeBuilder AppendTextLine(string text)
        {
            _builder.AppendLine(new string(' ', _indentLevel) + text);
            return this;
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }

    internal class Program
    {
        private static string lyrics = "[Verse 1]\nImmortal temptation\nTakes over my mind\nCondemned\nFalling weak on my knees\nSummon the strength\nOf mayhem\n\n[Chorus]\nI am the storm that is approaching\nProvoking\nBlack clouds in isolation\nI am reclaimer of my name\nBorn in flames\nI have been blessed\nMy family crest is a demon of death!\nForsakened, I am awakened\nA phoenix's ash in dark divine\nDescending misery\nDestiny chasing time\n\n[Verse 2]\nInherit the nightmare\nSurrounded by fate\nCan’t run away\nKeep walking the line\nBetween the light\nLed astray\nYou might also like\n[Pre-Chorus]\nThrough vacant halls I won’t surrender\nThe truth revealed in eyes of ember\nWe fight through fire and ice forever\nTwo souls once lost, and now they remember\n\n[Chorus]\nI am the storm that is approaching\nProvoking\nBlack clouds in isolation\nI am reclaimer of my name\nBorn in flames\nI have been blessed\nMy family crest is a demon of death!\nForsakened, I am awakened\nA phoenix's ash in dark divine\nDescending misery\nDestiny chasing time\nDisappear into the night\nLost shadows left behind\nObsession's pulling me\nFading, I've come to take what's mine!\n\n[Bridge]\nLurking in the shadows under veil of night\nConstellations of blood pirouette\nDancing through the graves of those who stand at my feet\nDreams of the black throne I keep on repeat\nA derelict of dark, summoned from the ashes\nThe puppetmaster congregates all the masses\nPulling strings, twisting minds as blades hit\nYou want this power? Then come try and take it\n[Breakdown]\nBeyond the tree\nFire burns\nSecret love\nBloodline yearns\nDark minds embrace\nCrimson joy\nDoes your dim heart\nHeal or destroy?\n\n[Outro]\nBury the light deep within!\nCast aside, there's no coming home!\nWe're burning chaos in the wind!\nDrifting in the ocean all alone!";

        static void Main(string[] args)
        {
            var formatter = new CodeBuilder();
            formatter.IncreaseTabIndent()
                     .AppendText("Bury the Light\n")
                     .AppendText("Casey Edwards & Victor Borba\n")
                     .IncreaseIndent(10);

            foreach (var line in lyrics.Split('\n'))
            {
                formatter.AppendTextLine(line);
            }

            Console.Write(formatter.ToString());
            Console.ReadKey(true);
        }
    }
}
