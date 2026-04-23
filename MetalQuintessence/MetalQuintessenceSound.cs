using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Quintessential;

namespace MetalQuintessence
{
    public class MetalQuintessenceSound
    {
        public static Sound blossomSound, chromatic_dispersionSound, pigmentationSound;
        public static void LoadAllCustomSounds()
        {
            foreach (var dir in QuintessentialLoader.ModContentDirectories)
            {
                string blossomPath = Path.Combine(dir, "Content/sounds/chromium-andytampan/blossom.wav");
                if (File.Exists(blossomPath))
                {
                    blossomSound = new Sound()
                    {
                        field_4060 = Path.GetFileNameWithoutExtension(blossomPath),
                        field_4061 = class_158.method_375(blossomPath)
                    };
                    string chromaticDispersionPath = Path.Combine(dir, "Content/sounds/chromium-andytampan/chromatic_dispersion.wav");
                    chromatic_dispersionSound = new Sound()
                    {
                        field_4060 = Path.GetFileNameWithoutExtension(chromaticDispersionPath),
                        field_4061 = class_158.method_375(chromaticDispersionPath)
                    };
                    string pigmentationPath = Path.Combine(dir, "Content/sounds/chromium-andytampan/pigmentation.wav");
                    pigmentationSound = new Sound()
                    {
                        field_4060 = Path.GetFileNameWithoutExtension(pigmentationPath),
                        field_4061 = class_158.method_375(pigmentationPath)
                    };
                    break;
                }
            }
            // add entry to the volume dictionary
            var field = typeof(class_11).GetField("field_52", BindingFlags.Static | BindingFlags.NonPublic);
            var dictionary = (Dictionary<string, float>)field.GetValue(null);
            dictionary.Add("blossom", 0.2f);
            dictionary.Add("chromatic_dispersion", 0.4f);
            dictionary.Add("pigmentation", 0.2f); 

            // modify the method that reenables sounds after they are triggered
            void Method_540(On.class_201.orig_method_540 orig, class_201 class201_self)
            {
                orig(class201_self);
                blossomSound.field_4062 = false;
                chromatic_dispersionSound.field_4062 = false;
                pigmentationSound.field_4062 = false;
            }
            On.class_201.method_540 += Method_540;
        }
    }
}
