using Quintessential;
using ReductiveMetallurgy;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using PartType = class_139;
using Permissions = enum_149;
using Texture = class_256;

namespace MetalQuintessence;

public class MetalQuintessence : QuintessentialMod
{
    public static readonly bool ReductiveMetallurgyLoaded = Brimstone.API.IsModLoaded("ReductiveMetallurgy");
    public static readonly bool FTSIGCTULoaded = Brimstone.API.IsModLoaded("FTSIGCTU");

    public const string PigmentationPermission = "MetalQuintessence:Pigmentation";
    public const string BlossomPermission = "MetalQuintessence:Blossom";
    public const string ChromeDispersionPermission = "MetalQuintessence:ChromaDispersionPermission";
    public override void Load()
    {
        Logger.Log("Metal Quintessence - Implementing sanity check");
        MetalQuintessenceSound.LoadAllCustomSounds();
    }

    public override void PostLoad()
    {
        // Blank 
    }
 

    public override void LoadPuzzleContent()
    {

        MetalQuintessenceAtoms.AddAtomTypes();
        MetalQuintessenceParts.AddPartsType();
        QApi.AddPuzzlePermission(PigmentationPermission, "Glyph of Pigmentation", "MetalQuintessence");
        QApi.AddPuzzlePermission(BlossomPermission, "Glyph of Blossom", "MetalQuintessence");
        QApi.AddPuzzlePermission(ChromeDispersionPermission, "Glyph of Chrome Dispersion", "MetalQuintessence");
        

        if (FTSIGCTULoaded)
        {
            Logger.Log("[MetalQuintessence] Detected optional dependency 'FTSIGCTU' - adding mirror rules for parts.");
            MetalQuintessenceParts.LoadMirrorRules();
        }
        
        if (ReductiveMetallurgyLoaded)
        {
            Logger.Log("[MetalQuintessence] Detected optional dependency 'Reductive Metallurgy' - exploding your alchemical machine.");
            ReductiveMetallurgy.API.addProliferationRule(MetalQuintessenceAtoms.Chromium);
        }

    }
    public override void Unload()
    {
        // Blank
    }
}