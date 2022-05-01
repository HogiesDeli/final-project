using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace final_project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new D2RandomContext(serviceProvider.GetRequiredService<DbContextOptions<D2RandomContext>>()))
            {
                if (db.Primary.Any())
                {
                    return;
                }
                if (db.Secondary.Any())
                {
                    return;
                }
                if (db.Heavy.Any())
                {
                    return;
                }
                if (db.Armor.Any())
                {
                    return;
                }
                //Adds 15 Primary Weapons to Database
                db.Primary.AddRange(
                    new Primary { Pname = "The Steady Hand" },
                    new Primary { Pname = "Emperical Evidence" },
                    new Primary { Pname = "Eye of Sol" },
                    new Primary { Pname = "Herod-C" },
                    new Primary { Pname = "Persis-D" },
                    new Primary { Pname = "Piece of Mind" },
                    new Primary { Pname = "Survivor's Epitaph" },
                    new Primary { Pname = "Astral Horizon" },
                    new Primary { Pname = "Ragnhild-D" },
                    new Primary { Pname = "Ignition Code" },
                    new Primary { Pname = "Extraordinary Rendition" },
                    new Primary { Pname = "The Messenger" },
                    new Primary { Pname = "Multimach CCX" },
                    new Primary { Pname = "True Prophecy" },
                    new Primary { Pname = "Khvostov 7G-02" }
                );
                //Adds 15 Secondary Weapons to Database
                db.Secondary.AddRange(
                    new Secondary { Sname = "Found Verdict" },
                    new Secondary { Sname = "Funnelweb" },
                    new Secondary { Sname = "Shayura's Wrath" },
                    new Secondary { Sname = "Matador 64" },
                    new Secondary { Sname = "Frozen Orbit" },
                    new Secondary { Sname = "Cold Front" },
                    new Secondary { Sname = "Likely Suspect" },
                    new Secondary { Sname = "Palindrome" },
                    new Secondary { Sname = "Igneous Hammer" },
                    new Secondary { Sname = "Gnawing Hunger" },
                    new Secondary { Sname = "Orewing's Maul" },
                    new Secondary { Sname = "Salvager's Salvo" },
                    new Secondary { Sname = "1000 Yard Stare" },
                    new Secondary { Sname = "The Summoner" },
                    new Secondary { Sname = "The Enigma" }
                );
                //Adds 15 Heavy Weapons to Database
                db.Heavy.AddRange(
                    new Heavy { Hname = "Tomorrow's Answer" },
                    new Heavy { Hname = "Red Herring" },
                    new Heavy { Hname = "Typhon GL5" },
                    new Heavy { Hname = "Archon's Thunder" },
                    new Heavy { Hname = "Cataclysmic" },
                    new Heavy { Hname = "Palmyra-B" },
                    new Heavy { Hname = "Tarnation" },
                    new Heavy { Hname = "Recurrent Impact" },
                    new Heavy { Hname = "Ascendancy" },
                    new Heavy { Hname = "Bad Omens" },
                    new Heavy { Hname = "Canis Major" },
                    new Heavy { Hname = "Code Duello" },
                    new Heavy { Hname = "Commemoration" },
                    new Heavy { Hname = "Corrective Measure" },
                    new Heavy { Hname = "Sola's Scar" }
                );
                //Adds all 36 Warlock Exotic Armor to Database
                db.Armor.AddRange(
                    //Helmets
                    new Armor { Aname = "Skull of Dire Ahamkara" },
                    new Armor { Aname = "Crown Of Tempests" },
                    new Armor { Aname = "Eye of Another World" },
                    new Armor { Aname = "Nezarac's Sin" },
                    new Armor { Aname = "The Stag" },
                    new Armor { Aname = "Verity's Brow" },
                    new Armor { Aname = "Apotheosis Veil" },
                    new Armor { Aname = "Astrocyte Verse" },
                    new Armor { Aname = "Felwinter's Helm" },
                    new Armor { Aname = "Dawn Chorus" },
                    //Gauntlets
                    new Armor { Aname = "Sunbracers" },
                    new Armor { Aname = "Karnstein Armlets" },
                    new Armor { Aname = "Winter's Guile" },
                    new Armor { Aname = "Aeon Soul" },
                    new Armor { Aname = "Ophidian Aspect" },
                    new Armor { Aname = "Claws of Ahamkara" },
                    new Armor { Aname = "Contraverse Hold" },
                    new Armor { Aname = "Getaway Artists" },
                    new Armor { Aname = "Necrotic Grip" },
                    new Armor { Aname = "Nothing Manacles" },
                    new Armor { Aname = "Osmiomancy Gloves" },
                    //Chest
                    new Armor { Aname = "Starfire Protocol" },
                    new Armor { Aname = "Wings of Sacred Dawn" },
                    new Armor { Aname = "Vesper of Radius" },
                    new Armor { Aname = "Sanguine Alchemy" },
                    new Armor { Aname = "Chromatic Fire" },
                    new Armor { Aname = "Phoenix Protocol" },
                    new Armor { Aname = "Stormdancer's Brace" },
                    new Armor { Aname = "Mantle of Battle Harmony" },
                    //Legs
                    new Armor { Aname = "Transversive Steps" },
                    new Armor { Aname = "Lunafaction Boots" },
                    new Armor { Aname = "Geomag Stabilizers" },
                    new Armor { Aname = "Promethium Spur" },
                    new Armor { Aname = "Boots of the Assembler" },
                    new Armor { Aname = "Secant Filaments" }
                );

                db.SaveChanges();
            }
        }
    }
}