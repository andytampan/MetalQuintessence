using Quintessential;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalQuintessence
{
    public class API
    {
        public static Dictionary<AtomType, AtomType[]> Blossom = new();
        public static bool applyBlossomRule(AtomType input, out AtomType[] output)
        {

            bool ret = Blossom.ContainsKey(input);
            output = ret ? Blossom[input] : default(AtomType[]);
            return ret;
        }

        public static void addBlossomRule(AtomType input, AtomType[] output)
        {
            if (Blossom.ContainsKey(input)) {
                Logger.Log("Rule already exist: ");
                throw new Exception("Unable to add rule");
            }

            Blossom.Add(input, output);
        }

    }
}
