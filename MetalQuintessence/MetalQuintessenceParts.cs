using Quintessential;
using System.Collections.Generic;
using System.Linq;
using PartType = class_139;
using Permissions = enum_149;
using Texture = class_256;

namespace MetalQuintessence;


public class MetalQuintessenceParts
{
    public static Texture ringhole = class_238.field_1989.field_90.field_255.field_293;

    public static Texture chromiumIcon = Brimstone.API.GetTexture("textures/parts/andytampan/pigmentation/chromiumIcon");
    public static Texture quicksilverIcon = Brimstone.API.GetTexture("textures/parts/andytampan/pigmentation/quicksilver_symbol");
    public static Texture bowl = class_238.field_1989.field_90.field_170;
    public static Texture ringedBowl = class_238.field_1989.field_90.field_163;
    public static Texture hole = class_238.field_1989.field_90.field_255.field_293;

    public static Texture pigmentationBase = Brimstone.API.GetTexture("textures/parts/andytampan/pigmentation/pigmentationBase");
    public static Texture pigmentationGlow = class_238.field_1989.field_97.field_374;
    public static Texture pigmentationStroke = class_238.field_1989.field_97.field_375;
    public static Texture pigmentationIcon = Brimstone.API.GetTexture("textures/parts/andytampan/icons/pigmentation");
    public static Texture pigmentationIconHover = Brimstone.API.GetTexture("textures/parts/andytampan/icons/pigmentation_hover");

    public static Texture blossomBase = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/blossomBase");
    public static Texture blossomFlower = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/blossomFlower");
    public static Texture blossomTransBowl = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/blossomBowl");
    public static Texture blossomNumber = Brimstone.API.GetTexture("textures/parts/andytampan/blossom/number");
    public static Texture blossomGlow = class_238.field_1989.field_97.field_374;
    public static Texture blossomStroke = class_238.field_1989.field_97.field_375;
    public static Texture blossomIcon = Brimstone.API.GetTexture("textures/parts/andytampan/icons/pigmentation");
    public static Texture blossomIconHover = Brimstone.API.GetTexture("textures/parts/andytampan/icons/pigmentation_hover");

    public static Texture chromaticDispersionBase = Brimstone.API.GetTexture("textures/parts/andytampan/chromaticDispersionBase/pigmentationBase");

    public static Texture pigmentationBond = class_238.field_1989.field_90.field_173;
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



    public static PartType ChromeDispersion;
    public static PartType Pigmentation;
    public static PartType Blossom;

    public static void AddPartsType()
    {
        ChromeDispersion = new()
        {
            field_1528 = "metalquintessence-chromedispersion", // ID
            field_1529 = class_134.method_253("Glyph of Chromatic Dispersion", string.Empty), // Name
            field_1530 = class_134.method_253("The glyph of chromatic dispersion disperse chromium into all of the metal grade", string.Empty), // Description
            field_1531 = 30, // Cost
            field_1539 = true, // Is a glyph
            field_1549 = pigmentationGlow, // Shadow/glow
            field_1550 = pigmentationStroke, // Stroke/outline
            field_1547 = pigmentationIcon, // Panel icon
            field_1548 = pigmentationIconHover, // Hovered panel icon
            field_1540 = new HexIndex[]
            {
                chromeDispersionInput,
                chromeDispersionLead,
                chromeDispersionTin,
                chromeDispersionIron,
                chromeDispersionCopper,
                chromeDispersionSilver,
                chromeDispersionGold

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
            field_1549 = pigmentationGlow, // Shadow/glow
            field_1550 = pigmentationStroke, // Stroke/outline
            field_1547 = pigmentationIcon, // Panel icon
            field_1548 = pigmentationIconHover, // Hovered panel icon
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
        QApi.AddPartTypeToPanel(ChromeDispersion, false);
        QApi.AddPartTypeToPanel(Pigmentation, false);
        QApi.AddPartTypeToPanel(Blossom, false);
        QApi.AddPartType(ChromeDispersion, static (part, pos, editor, renderer) =>
        {
            Vector2 offset = new(50f, 296f);
            renderer.method_523(chromaticDispersionBase, Vector2.Zero, offset, 0f);
            renderer.method_528(hole, chromeDispersionInput, Vector2.Zero);
            int irisFrame = 15;
            bool afterIrisOpens = false;
            PartSimState pss = editor.method_507().method_481(part);
            class_236 uco = editor.method_1989(part, pos);
            float time = editor.method_504();
            AtomType[] cardinalAtoms = new AtomType[6]
            {
                Brimstone.API.VanillaAtoms.lead,
                Brimstone.API.VanillaAtoms.tin,
                Brimstone.API.VanillaAtoms.iron,
                Brimstone.API.VanillaAtoms.copper,
                Brimstone.API.VanillaAtoms.silver,
                Brimstone.API.VanillaAtoms.gold
            };

            HexIndex[] outputHexes = new HexIndex[6]
            {
                chromeDispersionLead,
                chromeDispersionTin,
                chromeDispersionIron,
                chromeDispersionCopper,
                chromeDispersionSilver,
                chromeDispersionGold
            };



            if (pss.field_2743)
            {
                irisFrame = class_162.method_404((int)(class_162.method_411(1f, -1f, time) * 16f), 0, 15);
                afterIrisOpens = time > 0.5f;
            }

            for (int i = 0; i < 6; i++)
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
        });
        QApi.AddPartType(Pigmentation, static (part, pos, editor, renderer) =>
        {
            // Vector2 offset = new(41f, 48f);
            Vector2 offset = new(130f, 200f);
            renderer.method_523(pigmentationBase, Vector2.Zero, offset, 0f);
            renderer.method_529(ringhole, pigmentationA, Vector2.Zero);
            renderer.method_529(ringhole, pigmentationB, Vector2.Zero);
            renderer.method_529(ringhole, pigmentationC, Vector2.Zero);
            renderer.method_529(ringhole, pigmentationD, Vector2.Zero);
            renderer.method_529(ringhole, pigmentationE, Vector2.Zero);
            renderer.method_529(ringhole, pigmentationF, Vector2.Zero);

            renderer.method_529(chromiumIcon, pigmentationA, Vector2.Zero);
            renderer.method_529(chromiumIcon, pigmentationB, Vector2.Zero);
            renderer.method_529(chromiumIcon, pigmentationC, Vector2.Zero);
            renderer.method_529(chromiumIcon, pigmentationD, Vector2.Zero);
            renderer.method_529(chromiumIcon, pigmentationE, Vector2.Zero);
            renderer.method_529(chromiumIcon, pigmentationF, Vector2.Zero);

            renderer.method_529(bowl, pigmentationBowl, Vector2.Zero);
            renderer.method_529(quicksilverIcon, pigmentationBowl, Vector2.Zero);
        });
        QApi.AddPartType(Blossom, static (part, pos, editor, renderer) =>
        {
            // Vector2 offset = new(41f, 48f);
            Vector2 offset = new(125f, 120f);
            renderer.method_523(blossomBase, Vector2.Zero, offset, 0f);
            renderer.method_529(blossomFlower, blossomBowl, Vector2.Zero);
            renderer.method_529(blossomTransBowl, blossomA, Vector2.Zero);
            renderer.method_529(blossomNumber, blossomA, Vector2.Zero);
            renderer.method_529(blossomTransBowl, blossomB, Vector2.Zero);
            renderer.method_529(blossomTransBowl, blossomC, Vector2.Zero);
            renderer.method_529(blossomTransBowl, blossomD, Vector2.Zero);
            renderer.method_529(blossomTransBowl, blossomE, Vector2.Zero);
            renderer.method_529(blossomTransBowl, blossomF, Vector2.Zero);

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
                    HexIndex[] outputHexes = new HexIndex[6]
                    {
                   chromeDispersionLead,
                   chromeDispersionTin,
                   chromeDispersionIron,
                   chromeDispersionCopper,
                   chromeDispersionSilver,
                   chromeDispersionGold
                    };

                if (first && !pss[part].field_2743)
                {
                    if (sim.FindAtomRelative(part, chromeDispersionInput).method_99(out AtomReference chromium) && !chromium.field_2281 && !chromium.field_2282 && chromium.field_2280 == MetalQuintessenceAtoms.Chromium)
                    {
                        bool blocked = false;
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
                    AtomType[] cardinalAtoms = new AtomType[6]
                    {
                        Brimstone.API.VanillaAtoms.lead,
                        Brimstone.API.VanillaAtoms.tin,
                        Brimstone.API.VanillaAtoms.iron,
                        Brimstone.API.VanillaAtoms.copper,
                        Brimstone.API.VanillaAtoms.silver,
                        Brimstone.API.VanillaAtoms.gold
                    };

                    for (int i = 0; i < 6; i++)
                    {
                        // Spawn new atom
                        Brimstone.API.AddAtom(sim, part, outputHexes[i], cardinalAtoms[i]);
                    }
                }
                }

                if (type == Pigmentation)

                    if (sim.FindAtomRelative(part, pigmentationBowl).method_99(out AtomReference silver) &&
                        sim.FindAtomRelative(part, pigmentationA).method_99(out AtomReference A) &&
                        sim.FindAtomRelative(part, pigmentationB).method_99(out AtomReference B) &&
                        sim.FindAtomRelative(part, pigmentationC).method_99(out AtomReference C) &&
                        sim.FindAtomRelative(part, pigmentationD).method_99(out AtomReference D) &&
                        sim.FindAtomRelative(part, pigmentationE).method_99(out AtomReference E) &&
                        sim.FindAtomRelative(part, pigmentationF).method_99(out AtomReference F)
                    )
                    {

                        pss[part].field_2744 = new AtomType[1] { silver.field_2280 };
                        AtomType quicksilver = pss[part].field_2744[0];
                        pss[part].field_2744 = new AtomType[1] { A.field_2280 };
                        AtomType a = pss[part].field_2744[0];
                        pss[part].field_2744 = new AtomType[1] { B.field_2280 };
                        AtomType b = pss[part].field_2744[0];
                        pss[part].field_2744 = new AtomType[1] { C.field_2280 };
                        AtomType c = pss[part].field_2744[0];
                        pss[part].field_2744 = new AtomType[1] { D.field_2280 };
                        AtomType d = pss[part].field_2744[0];
                        pss[part].field_2744 = new AtomType[1] { E.field_2280 };
                        AtomType e = pss[part].field_2744[0];
                        pss[part].field_2744 = new AtomType[1] { F.field_2280 };
                        AtomType f = pss[part].field_2744[0];
                        AtomType[] input = new AtomType[]
                        {
                              a, b, c, d, e, f
                        };
                        /*AtomType[] metal = new AtomType[]
                        {
                            Brimstone.API.VanillaAtoms.lead,
                            Brimstone.API.VanillaAtoms.tin,
                            Brimstone.API.VanillaAtoms.iron,
                            Brimstone.API.VanillaAtoms.copper,
                            Brimstone.API.VanillaAtoms.silver,
                            Brimstone.API.VanillaAtoms.gold
                        }; */
                        if (input.Contains(Brimstone.API.VanillaAtoms.lead) && !A.field_2281 && !A.field_2282 &&
                            input.Contains(Brimstone.API.VanillaAtoms.tin) && !B.field_2281 && !B.field_2282 &&
                            input.Contains(Brimstone.API.VanillaAtoms.iron) && !C.field_2281 && !C.field_2282 &&
                            input.Contains(Brimstone.API.VanillaAtoms.copper) && !D.field_2281 && !D.field_2282 &&
                            input.Contains(Brimstone.API.VanillaAtoms.silver) && !E.field_2281 && !E.field_2282 &&
                            input.Contains(Brimstone.API.VanillaAtoms.gold) && !F.field_2281 && !F.field_2282 &&
                            quicksilver == Brimstone.API.VanillaAtoms.quicksilver
                            )
                        {
                            Brimstone.API.RemoveAtom(A);
                            Brimstone.API.RemoveAtom(B);
                            Brimstone.API.RemoveAtom(C);
                            Brimstone.API.RemoveAtom(D);
                            Brimstone.API.RemoveAtom(E);
                            Brimstone.API.RemoveAtom(F);
                            Brimstone.API.DrawFallingAtom(seb, A);
                            Brimstone.API.DrawFallingAtom(seb, B);
                            Brimstone.API.DrawFallingAtom(seb, C);
                            Brimstone.API.DrawFallingAtom(seb, D);
                            Brimstone.API.DrawFallingAtom(seb, E);
                            Brimstone.API.DrawFallingAtom(seb, F);
                            Brimstone.API.ChangeAtom(silver, MetalQuintessenceAtoms.Chromium);
                            silver.field_2279.field_2276 = (Maybe<class_168>)new class_168(seb, (enum_7)0, (enum_132)1, silver.field_2280, projectAtomAnimation, 30f);

                        }
                    }
                if (type == Blossom)

                    if (sim.FindAtomRelative(part, blossomBowl).method_99(out AtomReference input) &&
                        !sim.FindAtomRelative(part, blossomA).method_99(out AtomReference a) &&
                        !sim.FindAtomRelative(part, blossomB).method_99(out AtomReference b) &&
                        !sim.FindAtomRelative(part, blossomC).method_99(out AtomReference c) &&
                        !sim.FindAtomRelative(part, blossomD).method_99(out AtomReference d) &&
                        !sim.FindAtomRelative(part, blossomE).method_99(out AtomReference e) &&
                        !sim.FindAtomRelative(part, blossomF).method_99(out AtomReference f))
                    {
                        pss[part].field_2744 = new AtomType[1] { input.field_2280 };
                        AtomType inputs = pss[part].field_2744[0];
                        bool activated = false;
                        if (inputs == MetalQuintessenceAtoms.Chromium)
                        {
                            Molecule wheel = new Molecule();
                            Brimstone.API.ChangeAtom(input, Brimstone.API.VanillaAtoms.quicksilver);
                            input.field_2279.field_2276 = (Maybe<class_168>)new class_168(seb, (enum_7)0, (enum_132)1, input.field_2280, projectAtomAnimation, 30f);
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.lead), part.method_1184(blossomA));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.tin), part.method_1184(blossomB));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.iron), part.method_1184(blossomC));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.copper), part.method_1184(blossomD));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.silver), part.method_1184(blossomE));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.gold), part.method_1184(blossomF));
                            List<Molecule> molecules = sim.field_3823;
                            molecules.Add(wheel);
                            Brimstone.API.JoinMoleculesAtHexes(sim, part, blossomBowl, blossomA);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomA, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomB, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomC, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomD, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomE, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomF, enum_126.Standard, true, false);

                            activated = true;
                            
                        }
                        if (inputs == Brimstone.API.VanillaAtoms.quintessence)
                        {
                            Molecule wheel = new Molecule();
                            Brimstone.API.ChangeAtom(input, Brimstone.API.VanillaAtoms.salt);
                            input.field_2279.field_2276 = (Maybe<class_168>)new class_168(seb, (enum_7)0, (enum_132)1, input.field_2280, projectAtomAnimation, 30f);
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.water), part.method_1184(blossomA));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.salt), part.method_1184(blossomB));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.earth), part.method_1184(blossomC));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.fire), part.method_1184(blossomD));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.salt), part.method_1184(blossomE));
                            wheel.method_1105(new Atom(Brimstone.API.VanillaAtoms.air), part.method_1184(blossomF));
                            List<Molecule> molecules = sim.field_3823;
                            molecules.Add(wheel);
                            Brimstone.API.JoinMoleculesAtHexes(sim, part, blossomBowl, blossomA);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomA, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomB, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomC, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomD, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomE, enum_126.Standard, true, false);
                            Brimstone.API.AddBond(sim, part, blossomBowl, blossomF, enum_126.Standard, true, false);

                            activated = true;
                        }
                        if (activated)
                        {
                            var SEB = sim.field_3818;
                            Texture[] disposalFlashAnimation = class_238.field_1989.field_90.field_240;
                            Vector2 animationPosition = HexGraphicalOffset(part.method_1161() + blossomBowl.Rotated(part.method_1163())) + new Vector2(80f, 0f);
                            SEB.field_3936.Add(new class_228(SEB, (enum_7)1, animationPosition, disposalFlashAnimation, 30f, Vector2.Zero, 0f));
                        }
                    }
                
            }
        });
            
        }
        
}

