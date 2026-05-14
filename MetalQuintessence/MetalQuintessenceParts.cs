using Brimstone;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using MonoMod.Utils;


using Quintessential;
using ReductiveMetallurgy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PartType = class_139;
using Permissions = enum_149;
using Texture = class_256;

namespace MetalQuintessence;


public class MetalQuintessenceParts
{

    // note to self when dealing with offset, but 1 hexagon = 82 (just treat this like a rough value i don't know wtf going on)
    public static Texture ringhole = class_238.field_1989.field_90.field_255.field_293;

    public static Texture chromiumIcon = Brimstone.API.GetTexture("textures/parts/andytampan/pigmentation/chromiumIcon");
    public static Texture quicksilverIcon = Brimstone.API.GetTexture("textures/parts/andytampan/pigmentation/quicksilver_symbol");
    public static Texture bowl = class_238.field_1989.field_90.field_170;
    public static Texture ringedBowl = class_238.field_1989.field_90.field_163;
    public static Texture hole = class_238.field_1989.field_90.field_255.field_293;

    public static Texture leadIcon = Brimstone.API.GetTexture("textures/parts/andytampan/chromaticDispersionBase/lead_symbol");

    public static Texture pigmentationBase = Brimstone.API.GetTexture("textures/parts/andytampan/pigmentation/pigmentationBase");
    public static Texture pigmentationGlow = Brimstone.API.GetTexture("textures/select/andytampan/pigmentation_glow");
    public static Texture pigmentationStroke = Brimstone.API.GetTexture("textures/select/andytampan/pigmentation_stroke");
    public static Texture pigmentationIcon = Brimstone.API.GetTexture("textures/parts/andytampan/icons/pigmentation");
    public static Texture pigmentationIconHover = Brimstone.API.GetTexture("textures/parts/andytampan/icons/pigmentation_hover");

    public static Texture blossomBase = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/blossomBase");
    public static Texture blossomFlower = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/blossomFlower");
    public static Texture blossomTransBowl = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/blossomBowl");
    public static Texture blossomNumber = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/number");
    public static Texture blossomGlow = Brimstone.API.GetTexture("textures/select/andytampan/disposal_glow");
    public static Texture blossomStroke = Brimstone.API.GetTexture("textures/select/andytampan/disposal_stroke");
    public static Texture blossomIcon = Brimstone.API.GetTexture("textures/parts/andytampan/icons/blossom");
    public static Texture blossomIconHover = Brimstone.API.GetTexture("textures/parts/andytampan/icons/blossom_hover");

    public static Texture singleGlossMask = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/output_ring_gloss_mask");
    public static Texture glossTexture = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/output_gloss");

    public static Texture chromaticDispersionBase = Brimstone.API.GetTexture("textures/parts/andytampan/chromaticDispersionBase/pigmentationBase");
    public static Texture chromaticDispersionGlyphBase = Brimstone.API.GetTexture("textures/parts/andytampan/chromaticDispersionBase/glyphBase");
    public static Texture chromaticDispersionIcon = Brimstone.API.GetTexture("textures/parts/andytampan/icons/chromaDispersion");
    public static Texture chromaticDispersionIconHover = Brimstone.API.GetTexture("textures/parts/andytampan/icons/chromaDispersion_hover");
    public static Texture chromaticDispersionGlow = Brimstone.API.GetTexture("textures/select/andytampan/chromaDispersion_glow");
    public static Texture chromaticDispersionStroke = Brimstone.API.GetTexture("textures/select/andytampan/chromaDispersion_stroke");

    public static Texture pigmentationBond = class_238.field_1989.field_90.field_173;
    public static Texture chromaticDispersionBond = Brimstone.API.GetTexture("textures/parts/andytampan/chromaticDispersionBase/chromaDispersionBondLoop");
    public static Texture[] projectAtomAnimation => class_238.field_1989.field_81.field_614;
    public static Texture[] irisAnimation = class_238.field_1989.field_90.field_246;
    public static Vector2 HexGraphicalOffset(HexIndex hex) => class_187.field_1742.method_492(hex);

    public static readonly HexIndex pigmentationBowl = new(0, 0);
    public static readonly HexIndex pigmentationA = new(-1, 0);
    public static readonly HexIndex pigmentationB = new(0, -1);
    public static readonly HexIndex pigmentationC = new(0, -2);
    public static readonly HexIndex pigmentationD = new(2, -2);
    public static readonly HexIndex pigmentationE = new(1, -1);
    public static readonly HexIndex pigmentationF = new(1, 0);

    public static readonly HexIndex blossomBowl = new(0, 0);
    public static readonly HexIndex blossomA = new(-1, 0);
    public static readonly HexIndex blossomB = new(-1, 1);
    public static readonly HexIndex blossomC = new(0, 1);
    public static readonly HexIndex blossomD = new(1, 0);
    public static readonly HexIndex blossomE = new(1, -1);
    public static readonly HexIndex blossomF = new(0, -1);

    public static readonly HexIndex chromeDispersionInput = new(0, 0);
    public static readonly HexIndex chromeDispersionLead = new(1, 0);
    public static readonly HexIndex chromeDispersionTin = new(2, -1);
    public static readonly HexIndex chromeDispersionIron = new(3, -2);
    public static readonly HexIndex chromeDispersionCopper = new(3, -3);
    public static readonly HexIndex chromeDispersionSilver = new(2, -3);
    public static readonly HexIndex chromeDispersionGold = new(1, -2);
    public static readonly HexIndex chromeDispersionQuicksilver = new(0, -1);
    public static readonly HexIndex chromeDispersionGlyphA = new(1, -1);
    public static readonly HexIndex chromeDispersionGlyphB = new(2, -2);

    public static MethodInfo PrivateMethod<T>(string method) => typeof(T).GetMethod(method, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

    public static void playSound(Sim sim_self, Sound sound) => PrivateMethod<Sim>("method_1856").Invoke(sim_self, new object[] { sound });

    public static PartType ChromeDispersion;
    public static PartType Pigmentation;
    public static PartType Blossom;

    public static HexIndex[] inputHex = new HexIndex[]
        {
                blossomBowl,
                blossomA,
                blossomB,
                blossomC,
                blossomD,
                blossomE,
                blossomF

        };
    public static void AddPartsType()
    {
        ChromeDispersion = new()
        {
            field_1528 = "metalquintessence-chromedispersion", // ID
            field_1529 = class_134.method_253("Glyph of Chromatic Dispersion", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of chromatic dispersion disperse chromium into all of the metal grade", string.Empty), // Description
            field_1531 = 30, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = chromaticDispersionGlow, // Shadow/glow
            field_1550 = chromaticDispersionStroke, // Stroke/outline
            field_1547 = chromaticDispersionIcon, // Panel icon
            field_1548 = chromaticDispersionIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                chromeDispersionInput,
                chromeDispersionLead,
                chromeDispersionTin,
                chromeDispersionIron,
                chromeDispersionCopper,
                chromeDispersionSilver,
                chromeDispersionGold,
                chromeDispersionGlyphA,
                chromeDispersionGlyphB

            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MetalQuintessence.ChromeDispersionPermission)

        };
        Pigmentation = new()
        {
            field_1528 = "metalquintessence-pigmentation", // ID
            field_1529 = class_134.method_253("Glyph of Pigmentation", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of pigmentation transmutes each grade of metallic atom into a single chromium atom", string.Empty), // Description
            field_1531 = 30, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = pigmentationGlow, // Shadow/glow
            field_1550 = pigmentationStroke, // Stroke/outline
            field_1547 = pigmentationIcon, // Panel icon
            field_1548 = pigmentationIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                pigmentationBowl,
                pigmentationA,
                pigmentationA,
                pigmentationB,
                pigmentationC,
                pigmentationD,
                pigmentationE,
                pigmentationF

            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MetalQuintessence.PigmentationPermission)
        };
        Blossom = new()
        {
            field_1528 = "metalquintessence-blossom", // ID
            field_1529 = class_134.method_253("Glyph of Blossom", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of blossom unravel quintessence and chromium into their respective wheel", string.Empty), // Description
            field_1531 = 30, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = blossomGlow, // Shadow/glow
            field_1550 = blossomStroke, // Stroke/outline
            field_1547 = blossomIcon, // Panel icon
            field_1548 = blossomIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            
            {
                blossomBowl,
                blossomA,
                blossomB,
                blossomC,
                blossomD,
                blossomE,
                blossomF

            },
            field_1551 = Permissions.None,
            CustomPermissionCheck = perms => perms.Contains(MetalQuintessence.BlossomPermission)
        };
        AtomType[] ChromiumWheel = new AtomType[]
        {
                            Brimstone.API.VanillaAtoms.lead,
                            Brimstone.API.VanillaAtoms.tin,
                            Brimstone.API.VanillaAtoms.iron,
                            Brimstone.API.VanillaAtoms.copper,
                            Brimstone.API.VanillaAtoms.silver,
                            Brimstone.API.VanillaAtoms.gold,
                            Brimstone.API.VanillaAtoms.quicksilver

        };
        API.addBlossomRule(MetalQuintessenceAtoms.Chromium, ChromiumWheel);

        AtomType[] QuintessenceWheel = new AtomType[]
        {
                            Brimstone.API.VanillaAtoms.water,
                            Brimstone.API.VanillaAtoms.salt,
                            Brimstone.API.VanillaAtoms.earth,
                            Brimstone.API.VanillaAtoms.fire,
                            Brimstone.API.VanillaAtoms.salt,
                            Brimstone.API.VanillaAtoms.air,
                            Brimstone.API.VanillaAtoms.salt
        };
        API.addBlossomRule(Brimstone.API.VanillaAtoms.quintessence, QuintessenceWheel);

        QApi.AddPartTypeToPanel(ChromeDispersion, false);
        QApi.AddPartTypeToPanel(Pigmentation, false);
        QApi.AddPartTypeToPanel(Blossom, false);
        QApi.AddPartType(ChromeDispersion, static (part, pos, editor, renderer) =>
        {
            Vector2 offset = new(90f, 296f);


            renderer.method_529(chromaticDispersionGlyphBase, chromeDispersionGlyphA, Vector2.Zero);
            renderer.method_529(chromaticDispersionGlyphBase, chromeDispersionGlyphB, Vector2.Zero);
            renderer.method_523(chromaticDispersionBase, Vector2.Zero, offset, 0f);
            renderer.method_528(hole, chromeDispersionInput, Vector2.Zero);

            int irisFrame = 15;
            bool afterIrisOpens = false;
            PartSimState pss = editor.method_507().method_481(part);
            class_236 uco = editor.method_1989(part, pos);
            float time = editor.method_504();
            AtomType[] cardinalAtoms = new AtomType[7]
            {
                Brimstone.API.VanillaAtoms.lead,
                Brimstone.API.VanillaAtoms.tin,
                Brimstone.API.VanillaAtoms.iron,
                Brimstone.API.VanillaAtoms.copper,
                Brimstone.API.VanillaAtoms.silver,
                Brimstone.API.VanillaAtoms.gold,
                Brimstone.API.VanillaAtoms.quicksilver
            };

            HexIndex[] outputHexes = new HexIndex[7]
            {
                chromeDispersionLead,
                chromeDispersionTin,
                chromeDispersionIron,
                chromeDispersionCopper,
                chromeDispersionSilver,
                chromeDispersionGold,
                chromeDispersionQuicksilver
            };



            if (pss.field_2743)
            {
                irisFrame = class_162.method_404((int)(class_162.method_411(1f, -1f, time) * 16f), 0, 15);
                afterIrisOpens = time > 0.5f;
            }

            for (int i = 0; i < 7; i++)
            {
                HexIndex h = outputHexes[i];
                Vector2 risingOffset = uco.field_1984 + class_187.field_1742.method_492(h).Rotated(uco.field_1985);
                Molecule risingAtom = Molecule.method_1121(cardinalAtoms[i]);

                renderer.method_528(hole, h, Vector2.Zero);
                if (pss.field_2743 && !afterIrisOpens)
                {
                    // show atom rising behind iris
                    Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
                }
                renderer.method_529(irisAnimation[irisFrame], h, Vector2.Zero);
                if (pss.field_2743 && afterIrisOpens)
                {
                    // show atom rising infront of iris
                    Editor.method_925(risingAtom, risingOffset, new HexIndex(0, 0), 0f, 1f, time, 1f, false, null);
                }
            }
            // 90f, 296f ????????????????? I end up just eyeballing this
            renderer.method_523(chromaticDispersionBond, Vector2.Zero, offset, 0f);
            Vector2 offsetRotate0 = new(48f, 366f); // -48 and +70
            renderer.method_523(chromaticDispersionBond, Vector2.Zero, offsetRotate0, 0f);
            Vector2 offsetRotate1 = new(172f, 296f); // +82 and 0
            renderer.method_523(chromaticDispersionBond, Vector2.Zero, offsetRotate1, Convert.ToSingle(Math.PI / 3));
            Vector2 offsetRotate2 = new(214f, 366); // -42 and +70
            renderer.method_523(chromaticDispersionBond, Vector2.Zero, offsetRotate2, Convert.ToSingle(Math.PI / 3));
            Vector2 offsetRotate3 = new(294f, 225);
            renderer.method_523(chromaticDispersionBond, Vector2.Zero, offsetRotate3, Convert.ToSingle(Math.PI / 3 * 2));
            renderer.method_529(chromiumIcon, chromeDispersionInput, Vector2.Zero);
        });
        QApi.AddPartType(Pigmentation, static (part, pos, editor, renderer) =>
        {
            // Vector2 offset = new(41f, 48f);
            Vector2 offset = new(130f, 200f);
            renderer.method_523(pigmentationBase, Vector2.Zero, offset, 0f);

            HexIndex[] inputHex = new HexIndex[]
            {
                pigmentationBowl,
                pigmentationA,
                pigmentationB,
                pigmentationC,
                pigmentationD,
                pigmentationE,
                pigmentationF

            };
            foreach (HexIndex input in inputHex)
            {
                renderer.method_529(ringhole, input, Vector2.Zero);
                renderer.method_529(leadIcon, input, Vector2.Zero);
            }
            renderer.method_529(bowl, pigmentationBowl, Vector2.Zero);
            renderer.method_529(quicksilverIcon, pigmentationBowl, Vector2.Zero);
        });
        QApi.AddPartType(Blossom, static (part, pos, editor, renderer) =>
        {
            // Vector2 offset = new(41f, 48f);
            
            // renderer.method_523(blossomBase, Vector2.Zero, offset, 0f);
            // renderer.method_529(blossomFlower, blossomBowl, Vector2.Zero);
            


            // renderer.method_529(blossomNumber, blossomF, Vector2.Zero);

        });
        QApi.RunAfterCycle((sim, first)
            =>
        {
            SolutionEditorBase seb = sim.field_3818;
            Dictionary<Part, PartSimState> pss = sim.field_3821;
            List<Part> parts = seb.method_502().field_3919;
            
            
            foreach (Part part in parts)
            {
                PartType type = part.method_1159();
                if (type == ChromeDispersion)
                {
                    HexIndex[] outputHexes = new HexIndex[7]
                    {
                   chromeDispersionLead,
                   chromeDispersionTin,
                   chromeDispersionIron,
                   chromeDispersionCopper,
                   chromeDispersionSilver,
                   chromeDispersionGold,
                   chromeDispersionQuicksilver
                    };

                    if (first && !pss[part].field_2743)
                    {
                        if (sim.FindAtomRelative(part, chromeDispersionInput).method_99(out AtomReference chromium) && !chromium.field_2281 && !chromium.field_2282 && chromium.field_2280 == MetalQuintessenceAtoms.Chromium)
                        {
                            playSound(sim, MetalQuintessenceSound.chromatic_dispersionSound);
                            bool blocked = false; //
                            foreach (HexIndex h in outputHexes)
                            {
                                
                                if (sim.FindAtomRelative(part, h).method_1085())
                                {
                                    blocked = true;
                                    break;
                                }
                            }
                            if (!blocked)
                            {
                                Brimstone.API.RemoveAtom(chromium);
                                Brimstone.API.DrawFallingAtom(seb, chromium);
                                pss[part].field_2743 = true;
                                foreach (HexIndex h in outputHexes)
                                {
                                    Brimstone.API.AddSmallCollider(sim, part, h);
                                }
                            }
                        }
                    }
                    else if (pss[part].field_2743)
                    {
                        AtomType[] cardinalAtoms = new AtomType[7]
                        {
                        Brimstone.API.VanillaAtoms.lead,
                        Brimstone.API.VanillaAtoms.tin,
                        Brimstone.API.VanillaAtoms.iron,
                        Brimstone.API.VanillaAtoms.copper,
                        Brimstone.API.VanillaAtoms.silver,
                        Brimstone.API.VanillaAtoms.gold,
                        Brimstone.API.VanillaAtoms.quicksilver
                        };

                        for (int i = 0; i < 7; i++)
                        {
                            // Spawn new atom
                            Brimstone.API.AddAtom(sim, part, outputHexes[i], cardinalAtoms[i]);
                        }
                    }
                }

                if (type == Pigmentation)
                {
                    HexIndex[] inputHex = new HexIndex[]
                     {

                         pigmentationA,
                         pigmentationB,
                         pigmentationC,
                         pigmentationD,
                         pigmentationE,
                         pigmentationF

                     };
                    List<AtomReference> inputs = new List<AtomReference>();
                    // Input are laid
                    bool inputLaid = true;
                    foreach (HexIndex input in inputHex)
                    {
                        if (sim.FindAtomRelative(part, input).method_99(out AtomReference atom))
                        {
                            inputs.Add(atom);
                        } else
                        {
                            inputLaid = false;
                            break;
                        }

                    }

                    if (sim.FindAtomRelative(part, pigmentationBowl).method_99(out AtomReference silver) & inputLaid
                    )
                    {


                        List<AtomType> input = new List<AtomType>();

                        AtomType quicksilver = silver.field_2280;
                        foreach (AtomReference atomReference in inputs)
                        {
                            input.Add(atomReference.field_2280);
                        }

                        AtomType[] metals = new AtomType[]
                        {
                            Brimstone.API.VanillaAtoms.lead,
                            Brimstone.API.VanillaAtoms.tin,
                            Brimstone.API.VanillaAtoms.iron,
                            Brimstone.API.VanillaAtoms.copper,
                            Brimstone.API.VanillaAtoms.silver,
                            Brimstone.API.VanillaAtoms.gold,
                        };
                        bool requirement = true; //assume requirement is true, then
                        foreach (var atom in metals.Zip(inputs, (a, r) => new { type = a, reference = r })) //this iterate each atomtype and reference as one.
                        {
                            if (!metals.Contains(atom.type)) { requirement = false; break; }; //iterate if each metal is contained in the inputlist
                            if (atom.reference.field_2281 && atom.reference.field_2282) { requirement = false; break; }; //iterate if each atom are singular and dropped
                        }
                        if (quicksilver == Brimstone.API.VanillaAtoms.quicksilver && requirement) // if requirement is still true, and if the input are quicksilver
                        {
                            playSound(sim, MetalQuintessenceSound.pigmentationSound);
                            foreach (AtomReference atom in inputs) //remove each atom one by one
                            {
                                Brimstone.API.RemoveAtom(atom);
                                Brimstone.API.DrawFallingAtom(seb, atom);
                            }
                            Brimstone.API.ChangeAtom(silver, MetalQuintessenceAtoms.Chromium); //transume quicksilver into chromium with it's effect
                            silver.field_2279.field_2276 = (Maybe<class_168>)new class_168(seb, (enum_7)0, (enum_132)1, silver.field_2280, projectAtomAnimation, 30f);

                        }
                    }
                }
                if (type == Blossom)

                {
                    HexIndex[] outputHexes = new HexIndex[6]
                    {
                      blossomA,
                      blossomB,
                      blossomC,
                      blossomD,
                      blossomE,
                      blossomF,
                    };

                    bool[] blocked = new bool[6];

                    for (int i = 0; i < 6; i++)
                    {
                        if (sim.FindAtomRelative(part, outputHexes[i]).method_1085())
                        {
                            blocked[i] = true;
                        } else
                        {
                           blocked[i] = false;
                        }
                    }
                    IEnumerable<Part> arms = sim.field_3818.method_502().field_3919.Where(p => p.method_1159().field_1533);
                    foreach (Part arm in arms)
                    {
                        
                        for (int i = 0; i < 6; i++)
                            if (arm.method_1161() == part.method_1161() + outputHexes[i].Rotated(part.method_1163()))
                            {
                                blocked[i] = true;
                            }
                    }


                    if (sim.FindAtomRelative(part, blossomBowl).method_99(out AtomReference input) && blocked.Contains(false))
                    {
                        pss[part].field_2744 = new AtomType[1] { input.field_2280 };
                        AtomType inputs = pss[part].field_2744[0];

                        AtomType[] wheelType = null; //declare an empty atomtype list
                                                     //placeholder 
                                                     // support for other atomtypes if someone want to add one maybe?

                        API.applyBlossomRule(inputs, out wheelType);
                        if (wheelType != null) // if there's an atomtype which means one of the requirement above are satisfied
                        {

                            Brimstone.API.ChangeAtom(input, wheelType[6]); // do animation and transmute atom into the seventh atomtype i.e: the center atom

                            input.field_2279.field_2276 = (Maybe<class_168>)new class_168(seb, (enum_7)0, (enum_132)1, input.field_2280, projectAtomAnimation, 30f);
                            
                            Molecule wheel = new Molecule(); // create new molecule 

                            for (int i = 0; i < 6; i++)
                            {
                                if (!blocked[i])  wheel.method_1105(new Atom(wheelType[i]), part.method_1184(outputHexes[i]));
                            }

                            List<Molecule> molecules = sim.field_3823;
                            molecules.Add(wheel);



                            // play sound
                            playSound(sim, MetalQuintessenceSound.blossomSound);



                            //play animation
                            var SEB = sim.field_3818;
                            Texture[] disposalFlashAnimation = class_238.field_1989.field_90.field_240;
                            Vector2 animationPosition = HexGraphicalOffset(part.method_1161() + blossomBowl.Rotated(part.method_1163())) + new Vector2(80f, 0f);
                            SEB.field_3936.Add(new class_228(SEB, (enum_7)1, animationPosition, disposalFlashAnimation, 30f, Vector2.Zero, 0f));


                            //joins the molecule and add bond 
                            for (int i = 0; i < 6; i++)
                            {
                                // it's done here despite being inefficient to account for each part being blocked
                                if (!blocked[i]) {
                                    Brimstone.API.JoinMoleculesAtHexes(sim, part, blossomBowl, outputHexes[i]);
                                    Brimstone.API.AddBond(sim, part, blossomBowl, outputHexes[i], enum_126.Standard, true, false); }
                            }
                        }
                    }
                }
            }

        });

        
    }

    private static Vector2 hexGraphicalOffset(HexIndex hex) => MainClass.hexGraphicalOffset(hex);
    private static void drawPartGloss(class_195 renderer, Texture gloss, Texture glossMask, Vector2 offset, HexIndex hexOffset, float angle)
    {
        class_135.method_257().field_1692 = class_238.field_1995.field_1757; // MaskedGlossPS shader
        class_135.method_257().field_1693[1] = gloss;
        var hex = new HexIndex(0, 0);
        Vector2 method2001 = 0.0001f * (renderer.field_1797 + hexGraphicalOffset(hex).Rotated(renderer.field_1798) - 0.5f * class_115.field_1433);
        class_135.method_257().field_1695 = method2001;
        renderer.method_528(glossMask, hexOffset, Vector2.Zero);
        class_135.method_257().field_1692 = class_135.method_257().field_1696; // previous shader
        class_135.method_257().field_1693[1] = class_238.field_1989.field_71;
        class_135.method_257().field_1695 = Vector2.Zero;
    }
    public static void LoadMirrorRules()
    {
        
        FTSIGCTU.MirrorTool.addRule(ChromeDispersion, FTSIGCTU.MirrorTool.mirrorVanBerlo);
        FTSIGCTU.MirrorTool.addRule(Pigmentation, FTSIGCTU.MirrorTool.mirrorHorizontalPart0_0);
        FTSIGCTU.MirrorTool.addRule(Blossom, FTSIGCTU.MirrorTool.mirrorVanBerlo);
    }

    public static void BlossomHandlingHook()
    {
        Logger.Log("[MetalQuintessence] Hooking for Blossom");
        IL.Solution.method_1947 += IL_BlossomCheck;
        IL.SolutionEditorBase.method_1984 += BlossomDraw;
        On.PartDraggingInputMode.method_1 += BlossomFrontDrawDragged;
    }


    //copied from True Animismus
    private static void BlossomDraw(ILContext il)
    {
        // The Disposal Jack has to be drawn on top of every other glyph.
        // Normally the game draws each glyph in order, so I can't use QApi in the same way as with the rest of the custom glyphs
        // So instead, I'm going into method_1984, the one responsible for drawing everything on the board
        // And inserting 'draw the disposal jack' code right after the 'draw all the glyphs' code

        var gremlin = new ILCursor(il);
        gremlin.TryGotoNext(MoveType.After, x => x.MatchStloc(26));
        if (gremlin.TryGotoNext(MoveType.Before, x => x.MatchStloc(26)))
            gremlin.Emit(OpCodes.Ldloc_3);
        gremlin.Emit(OpCodes.Ldarg_0);
        gremlin.Emit(OpCodes.Ldarg_1);
        gremlin.EmitDelegate<Action<Part[], SolutionEditorBase, Vector2>>((glyphlist, SEB, param_5533) =>
        {
            foreach (var dispojack in glyphlist.Where(x => x.method_1159() == Blossom))
            {
                //Roll our own rendering helper, the ones used in the usual QApi syntax
                class_236 class_292 = SEB.method_1989(dispojack, param_5533);
                class_195 renderer = new class_195(class_292.field_1984, class_292.field_1985, Editor.method_922());
                // renderer.method_529(blossomFlower, blossomBowl, Vector2.Zero);
                Vector2 offset = new(125f, 120f);
                renderBackBlossom(renderer, offset);
            }
        });

        gremlin.Goto(350); //somewhere shortly before the right place in the code
        //Go to the right spot in the code; this is what the opcodes look like just before it
        if (gremlin.TryGotoNext(MoveType.Before,
        x => x.MatchLdarg(0),
        x => x.MatchCallvirt(out _),
        x => x.MatchLdarg(0),
        x => x.MatchCallvirt(out _),
        x => x.MatchCallvirt(out _),
        x => x.MatchLdsfld(out _),
        x => x.MatchDup(),
        x => x.MatchBrtrue(out _),
        x => x.MatchPop(),
        x => x.MatchLdsfld(out _)
            ))
            //Gonna need the list of glyphs
            gremlin.Emit(OpCodes.Ldloc_3);
        //And SolutionEditorBase
        gremlin.Emit(OpCodes.Ldarg_0);
        //And also that first argument for method_1984--Vector2 param_5533
        //I don't know what it does, but later methods want it 
        gremlin.Emit(OpCodes.Ldarg_1);

        //Use them to do this
        //Logger.Log("gremlin.EmitDelegate<Action<Part[], SolutionEditorBase, Vector2>>((glyphlist, SEB, param_5533) => ");
        gremlin.EmitDelegate<Action<Part[], SolutionEditorBase, Vector2>>((glyphlist, SEB, param_5533) =>
        {
            foreach (var dispojack in glyphlist.Where(x => x.method_1159() == Blossom))
            {
                //Roll our own rendering helper, the ones used in the usual QApi syntax
                class_236 class_292 = SEB.method_1989(dispojack, param_5533);
                class_195 renderer = new class_195(class_292.field_1984, class_292.field_1985, Editor.method_922());
                // renderer.method_529(blossomFlower, blossomBowl, Vector2.Zero);
                Vector2 offset = new(125f, 120f);
                renderFrontBlossom(renderer, offset);
            }
        });

    }
    public static void BlossomFrontDrawDragged(On.PartDraggingInputMode.orig_method_1 orig, PartDraggingInputMode PDIM, SolutionEditorScreen SES)
    {
        //There are two ways that the game renders a glyph
        //When it's on the board, it goes through SolutionEditorBase.method_1984 (we'll call SolutionEditorBase "SEB"), then through SEB.method_1993 and finally SEB.method_1996
        //When it's being dragged around, it goes through PartDraggingInputMode.method_1, then to SEB.method_1993 and finally SEB.method_1996
        //Changing the order of when the Disposal Jack needs to be drawn--last--has to be done in the outer methods, since those are the ones that know that more than one part exists
        //So DispoDrawInner() has to be called here too, otherwise the Disposal Jack does not render while it's being dragged

        //Nice of the princess to invite of over for a picnic, eh, Luigi?
        //I hope she made lotsa spaghetti!
        orig(PDIM, SES);

        Type PDIMtype = typeof(PartDraggingInputMode);
        FieldInfo reflected_field_2711 = PDIMtype.GetField("field_2711", BindingFlags.NonPublic | BindingFlags.Instance);
        Vector2 vector = class_115.method_202() - (Vector2)reflected_field_2711.GetValue(PDIM);
        FieldInfo reflected_field_2715 = PDIMtype.GetField("field_2715", BindingFlags.NonPublic | BindingFlags.Instance);
        SES.field_4019 = class_187.field_1742.method_491((HexIndex)reflected_field_2715.GetValue(PDIM), vector);

        var current_interface = SES.field_4010;
        var interfaceDyn = new DynamicData(current_interface);
        var draggedParts = interfaceDyn.Get<List<PartDraggingInputMode.DraggedPart>>("field_2712");
        foreach (PartDraggingInputMode.DraggedPart draggedpart in draggedParts)
        {   //All the parts being dragged
            if (draggedpart.field_2722.method_1159() != Blossom) { continue; } //Just the disposal jacks

            Part dispojack = draggedpart.field_2722;
            class_236 class_292 = SES.method_1989(dispojack, vector);
            class_195 renderer = new class_195(class_292.field_1984, class_292.field_1985, Editor.method_922());
            Vector2 offset = new(125f, 120f);
            renderBackBlossom(renderer, offset);
            renderFrontBlossom(renderer, offset);
            
            
            //SolutionEditorScreen inherits from SolutionEditorBase, so you can apparently juse use a SES anywhere you would use a SEB
            //You can tell I'm not formally educated in C# because that feels like it would lead to SO MUCH CONFUSION
        }
    }
    // End of thing copied from animismus
    public static void renderBackBlossom(class_195 renderer, Vector2 offset)
    {
        renderer.method_523(blossomBase, new(-1f, -1f), offset, 0f);
        renderer.method_523(blossomFlower, new(-1f, -1f), offset, 0f);
        foreach (HexIndex input in inputHex)
        {
            if (input == blossomBowl)
            {
                renderer.method_528(bowl, input, Vector2.Zero);
            } else
            {
                renderer.method_528(ringedBowl, input, Vector2.Zero);
            }
        }
    }
    public static void renderFrontBlossom(class_195 renderer, Vector2 offset)
    {
        
        foreach (HexIndex input in inputHex)
        {
            renderer.method_528(blossomTransBowl, input, Vector2.Zero);
            drawPartGloss(renderer, glossTexture, singleGlossMask, Vector2.Zero, input, 0);
        }
    }
    public static void IL_BlossomCheck(ILContext il)
    {

        ILCursor cursor = new ILCursor(il);
        if (cursor.TryGotoNext(MoveType.Before,
            instr => instr.MatchBrfalse(out _)
            ))
            
            cursor.Emit(OpCodes.Ldarg_1);
            cursor.EmitDelegate(checkBlossom);
            cursor.Emit(OpCodes.Ldloc_2);
            cursor.EmitDelegate(checkBlossom);



    }

    public static bool checkBlossom(bool oldBool, Part part)
    {
        if (part.method_1159() == Blossom) return false;
        else return oldBool;
    }

}

