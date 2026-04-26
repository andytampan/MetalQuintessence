using Quintessential;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using PartType = class_139;
using Permissions = enum_149;
using Texture = class_256;

namespace MetalQuintessence;

public class MetalQuintessenceAtoms
{
    public static AtomType Chromium;

    public static void AddAtomTypes()
    {

        Chromium = Brimstone.API.CreateNormalAtom(
            ID: 89,
            modName: "MetalQuintessence",
            name: "Chromium",
            pathToSymbol: "textures/atoms/andytampan/metalquintessence/chromium_symbol",
            pathToDiffuse: "textures/atoms/andytampan/metalquintessence/chromium_diffuse",
            pathToShade: "textures/atoms/andytampan/metalquintessence/mors_shade"

            );

        QApi.AddAtomType(Chromium);
        
    }
}