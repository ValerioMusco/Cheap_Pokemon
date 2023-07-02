using Pokemon.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models {
    public static class PokemonLearnset {

        public static Dictionary<string, string> GetLearnSet( string name ) {

            switch( name.ToLower() ) {
                case "bulbizarre":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1"},
                                    { "Croissance", "3" },
                                    { "ViveAttaque", "7" },
                                    { "TranchHerbe", "13" },
                                    { "Morsure", "20" },
                                    { "LanceSoleil", "32" }
                                };

                case "herbizarre":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1"},
                                    { "Croissance", "1" },
                                    { "ViveAttaque", "1" },
                                    { "TranchHerbe", "1" },
                                    { "Fouet Lianes", "15" },
                                    { "Morsure", "20" },
                                    { "LanceSoleil", "32" }
                                };

                case "florizarre":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Croissance", "1" },
                                    { "ViveAttaque", "1" },
                                    { "TranchHerbe", "1" },
                                    { "Fouet Lianes", "1" },
                                    { "Morsure", "1" },
                                    { "LanceSoleil", "39" }
                                };

                case "salameche":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "MimiQueue", "1" },
                                    { "Flammeche", "7" },
                                    { "Brouillard", "10" }
                                };

                case "reptincel":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Flammeche", "1" },
                                    { "MimiQueue", "1" },
                                    { "Brouillard", "1" },
                                    { "Danse Flamme", "19" },
                                    { "Morsure", "24" }
                                };

                case "dracaufeu":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Flameche", "1" },
                                    { "MimiQueue", "1" },
                                    { "Brouillard", "1" },
                                    { "Danse Flamme", "1" },
                                    { "Morsure", "1" },
                                    { "LanceFlammes", "1" },
                                    { "Deflagration", "57" }
                                };

                case "carapuce":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Pistolet a O", "4" },
                                    { "MimiQueue", "7" },
                                    { "Ecume", "10" }
                                };

                case "carabaffe":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Pistolet a O", "1" },
                                    { "MimiQueue", "1" },
                                    { "Ecume", "13" },
                                    { "Bulles dO", "16" },
                                    { "Vibraqua", "21" }
                                };

                case "tortank":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Pistolet a O", "1" },
                                    { "MimiQueue", "1" },
                                    { "Ecume", "1" },
                                    { "Bulles dO", "1" },
                                    { "Vibraqua", "1" },
                                    { "Hydrocanon", "42" }
                                };

                case "chenipan":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" }
                                };

                case "chrysacier":
                    return new Dictionary<string, string>()
                                {
                                    { "Armure", "1" }
                                };

                case "papilusion":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Tornade", "1" },
                                    { "Vent Argente", "10" },
                                    { "Poudre Dodo", "12" },
                                    { "Psyko", "16" }
                                };

                case "aspicot":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Secretion", "1" }
                                };

                case "coconfort":
                    return new Dictionary<string, string>()
                                {
                                    { "Bouclier", "1" }
                                };

                case "dardargnan":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Secretion", "1" },
                                    { "Pique", "12" },
                                    { "ComboGriffe", "15" },
                                    { "DardVenin", "20" },
                                    { "BecVrille", "26" }
                                };

                case "roucool":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Tornade", "1" },
                                    { "Jet de Sable", "5" },
                                    { "ViveAttaque", "9" }
                                };

                case "roucoups":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Tornade", "1" },
                                    { "Jet de Sable", "1" },
                                    { "ViveAttaque", "13" },
                                    { "CruAile", "18" },
                                };

                case "roucarnage":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Tornade", "1" },
                                    { "Jet de Sable", "1" },
                                    { "ViveAttaque", "1" },
                                    { "CruAile", "1" },
                                    { "Cyclone", "44" }
                                };

                case "rattata":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "MimiQueue", "1" },
                                    { "Morsure", "4" },
                                    { "Crocs Givre", "9" }
                                };

                case "rattatac":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "MimiQueue", "1" },
                                    { "Morsure", "1" },
                                    { "Crocs Givre", "1" },
                                    { "Ultimapoing", "23" },
                                    { "Danse Lames", "32" }
                                };

                case "piafabec":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Picpic", "1" },
                                    { "GrozYeux", "4" },
                                    { "ViveAttaque", "9" }
                                };

                case "rapasdepic":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Picpic", "1" },
                                    { "GrozYeux", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Furie", "20" },
                                    { "LanceSoleil", "31" }
                                };

                case "abo":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Morsure", "1" },
                                    { "GrozYeux", "10" },
                                    { "Croc de Mort", "17" }
                                };

                case "arbok":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Morsure", "1" },
                                    { "GrozYeux", "1" },
                                    { "Croc de Mort", "1" },
                                    { "Glare", "33" },
                                    { "Ligotage", "44" }
                                };

                case "pikachu":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Eclair", "5" },
                                    { "Foudre", "9" },
                                    { "Queue de Fer", "13" },
                                    { "Tonnerre", "25" }
                                };

                case "raichu":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Eclair", "1" },
                                    { "Foudre", "1" },
                                    { "Queue de Fer", "1" },
                                    { "Tonnerre", "33" },
                                    { "FatalFoudre", "42" }
                                };

                case "sabelette":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Jet de Sable", "10" },
                                    { "Tunnel", "17" }
                                };

                case "sablaireau":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Jet de Sable", "1" },
                                    { "Tunnel", "1" },
                                    { "LanceFlammes", "41" }
                                };

                case "nidoranf":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "DardVenin", "8" },
                                    { "Morsure", "12" }
                                };

                case "nidorina":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "DardVenin", "1" },
                                    { "Morsure", "1" },
                                    { "Double Pied", "30" },
                                    { "Plaquage", "38" }
                                };

                case "nidoqueen":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "DardVenin", "1" },
                                    { "Morsure", "1" },
                                    { "Double Pied", "1" },
                                    { "Ruse", "24" },
                                    { "Contre", "38" }
                                };

                case "nidoranm":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "DardVenin", "8" },
                                    { "Morsure", "12" }
                                };

                case "nidorino":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "DardVenin", "1" },
                                    { "Morsure", "1" },
                                    { "Double Pied", "30" },
                                    { "EmpalKorne", "38" }
                                };

                case "nidoking":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "DardVenin", "1" },
                                    { "Morsure", "1" },
                                    { "Double Pied", "1" },
                                    { "Furie", "24" },
                                    { "Seisme", "38" }
                                };

                case "melofee":
                    return new Dictionary<string, string>()
                                {
                                    { "Charme", "1" },
                                    { "Metronome", "1" },
                                    { "ViveAttaque", "13" },
                                    { "Doux Parfum", "19" }
                                };

                case "melodelfe":
                    return new Dictionary<string, string>()
                                {
                                    { "Charme", "1" },
                                    { "Metronome", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Doux Parfum", "1" },
                                    { "Rayon Lune", "52" }
                                };

                case "goupix":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Rugissement", "1" },
                                    { "Flameche", "7" },
                                    { "Pouvoir Antique", "12" }
                                };

                case "feunard":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Rugissement", "1" },
                                    { "Flameche", "1" },
                                    { "Pouvoir Antique", "1" },
                                    { "LanceFlammes", "57" }
                                };

                case "rondoudou":
                    return new Dictionary<string, string>()
                                {
                                    { "Charme", "1" },
                                    { "Metronome", "1" },
                                    { "ViveAttaque", "9" },
                                    { "Roulade", "14" }
                                };

                case "grodoudou":
                    return new Dictionary<string, string>()
                                {
                                    { "Charme", "1" },
                                    { "Metronome", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Roulade", "1" },
                                    { "Regeneration", "49" }
                                };

                case "nosferapti":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Supersonic", "1" },
                                    { "Vampirisme", "10" },
                                    { "CruAile", "15" }
                                };

                case "nosferalto":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Supersonic", "1" },
                                    { "Vampirisme", "1" },
                                    { "CruAile", "1" },
                                    { "Soin", "49" }
                                };

                case "mystherbe":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "7" },
                                    { "TranchHerbe", "14" }
                                };

                case "ortide":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "1" },
                                    { "TranchHerbe", "1" },
                                    { "MegaSangsue", "49" }
                                };

                case "rafflesia":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "1" },
                                    { "TranchHerbe", "1" },
                                    { "Toxik", "1" },
                                    { "MegaSangsue", "49" },
                                    { "GigaSangsue", "55" }
                                };

                case "paras":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Vampirisme", "13" },
                                    { "TranchHerbe", "20" }
                                };

                case "parasect":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Vampirisme", "1" },
                                    { "TranchHerbe", "1" },
                                    { "Spore", "60" }
                                };

                case "mimitoss":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Vampirisme", "1" },
                                    { "GrozYeux", "13" },
                                    { "Megacorne", "20" }
                                };

                case "aeromite":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Vampirisme", "1" },
                                    { "GrozYeux", "1" },
                                    { "Megacorne", "1" },
                                    { "DanseLames", "60" }
                                };

                case "taupiqueur":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Jet de Sable", "10" },
                                    { "Tunnel", "17" }
                                };

                case "triopikeur":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Jet de Sable", "1" },
                                    { "Tunnel", "1" },
                                    { "Triplattaque", "41" }
                                };

                case "miaouss":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Morsure", "12" },
                                    { "Jet de Sable", "19" }
                                };

                case "persian":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "GrozYeux", "1" },
                                    { "Morsure", "1" },
                                    { "Jet de Sable", "1" },
                                    { "ComboGriffe", "45" }
                                };

                case "psykokwak":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Belier", "1" },
                                    { "Pistolet a O", "13" },
                                    { "Hydrocanon", "20" }
                                };

                case "akwakwak":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Belier", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Hydrocanon", "34" },
                                    { "Amnesie", "45" }
                                };

                case "ferosinge":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Flair", "1" },
                                    { "ComboGriffe", "15" },
                                    { "PoingKarate", "21" }
                                };

                case "colossinge":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Flair", "1" },
                                    { "ComboGriffe", "1" },
                                    { "PoingKarate", "43" },
                                    { "Poing de Feu", "52" }
                                };

                case "caninos":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Rugissement", "1" },
                                    { "Flameche", "9" },
                                    { "Morsure", "14" }
                                };

                case "arcanin":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Rugissement", "1" },
                                    { "Flameche", "1" },
                                    { "Morsure", "1" },
                                    { "Danse Flamme", "41" }
                                };

                case "ptitard":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Hypnose", "1" },
                                    { "Bulle dO", "15" },
                                    { "Hydrocanon", "19" }
                                };

                case "tetarte":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Hypnose", "1" },
                                    { "Bulle dO", "1" },
                                    { "Hydrocanon", "1" },
                                    { "Cognobidon", "45" }
                                };

                case "tartard":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Hypnose", "1" },
                                    { "Bulle dO", "1" },
                                    { "Hydrocanon", "1" },
                                    { "Cognobidon", "52" },
                                    { "Explosion", "57" }
                                };

                case "abra":
                    return new Dictionary<string, string>()
                                {
                                    { "Teleport", "1" }
                                };

                case "kadabra":
                    return new Dictionary<string, string>()
                                {
                                    { "Teleport", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Regard Medusant", "1" },
                                    { "Choc Mental", "36" },
                                    { "Psyko", "41" }
                                };

                case "alakazam":
                    return new Dictionary<string, string>()
                                {
                                    { "Teleport", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Regard Medusant", "1" },
                                    { "Choc Mental", "1" },
                                    { "Psyko", "36" },
                                    { "Chatiment", "46" }
                                };

                case "machoc":
                    return new Dictionary<string, string>()
                                {
                                    { "Poing de Feu", "1" },
                                    { "Poingeclair", "1" },
                                    { "Frappe Atlas", "21" },
                                    { "MitraPoing", "26" }
                                };

                case "machopeur":
                    return new Dictionary<string, string>()
                                {
                                    { "Poing de Feu", "1" },
                                    { "Poingeclair", "1" },
                                    { "Frappe Atlas", "1" },
                                    { "MitraPoing", "32" },
                                    { "Seisme", "37" }
                                };

                case "mackogneur":
                    return new Dictionary<string, string>()
                                {
                                    { "Poing de Feu", "1" },
                                    { "Poingeclair", "1" },
                                    { "Frappe Atlas", "1" },
                                    { "MitraPoing", "1" },
                                    { "Seisme", "1" },
                                    { "Balayage", "37" },
                                    { "PoingGlace", "52" }
                                };

                case "chetiflor":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "7" },
                                    { "TranchHerbe", "14" }
                                };

                case "boustiflor":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "1" },
                                    { "TranchHerbe", "1" },
                                    { "MegaSangsue", "26" }
                                };

                case "empiflor":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "1" },
                                    { "TranchHerbe", "1" },
                                    { "Toxik", "1" },
                                    { "GigaSangsue", "45" },
                                    { "Explosion", "50" }
                                };

                case "tentacool":
                    return new Dictionary<string, string>()
                                {
                                    { "Ecume", "1" },
                                    { "Ligotage", "4" },
                                    { "Picots", "7" },
                                    { "Secretion", "10" },
                                    { "Pistolet à O", "13" },
                                    { "Hydrocanon", "16" },
                                    { "Vibraqua", "19" },
                                    { "Acidarmure", "22" },
                                    { "HydroPompe", "25" },
                                    { "Reflet", "28" },
                                    { "Tenacite", "31" },
                                    { "Pique", "34" },
                                    { "Toxik", "37" },
                                    { "Cascade", "40" },
                                    { "Synthese", "43" },
                                    { "Gicledo", "46" }
                                };

                case "tentacruel":
                    return new Dictionary<string, string>()
                                {
                                    { "Ecume", "1" },
                                    { "Ligotage", "1" },
                                    { "Picots", "1" },
                                    { "Secretion", "1" },
                                    { "Pistolet à O", "13" },
                                    { "Hydrocanon", "16" },
                                    { "Vibraqua", "19" },
                                    { "Acidarmure", "22" },
                                    { "HydroPompe", "25" },
                                    { "Reflet", "28" },
                                    { "Tenacite", "33" },
                                    { "Pique", "38" },
                                    { "Toxik", "43" },
                                    { "Cascade", "48" },
                                    { "Gicledo", "58" }
                                };

                case "racaillou":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "JetPierres", "4" },
                                    { "Mur de Fer", "6" },
                                    { "Eboulement", "10" },
                                    { "Explosion", "14" },
                                    { "Plaquage", "17" },
                                    { "Provoc", "20" },
                                    { "Dynamopoing", "23" },
                                    { "Lame de Roc", "26" },
                                    { "Piege de Roc", "30" },
                                    { "Ampleur", "37" },
                                    { "Tomberoche", "40" },
                                    { "Seisme", "46" }
                                };

                case "gravalanch":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "JetPierres", "1" },
                                    { "Mur de Fer", "1" },
                                    { "Eboulement", "1" },
                                    { "Explosion", "14" },
                                    { "Plaquage", "17" },
                                    { "Provoc", "20" },
                                    { "Dynamopoing", "23" },
                                    { "Lame de Roc", "26" },
                                    { "Piege de Roc", "30" },
                                    { "Ampleur", "38" },
                                    { "Tomberoche", "42" },
                                    { "Seisme", "50" }
                                };

                case "grolem":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "JetPierres", "1" },
                                    { "Mur de Fer", "1" },
                                    { "Eboulement", "1" },
                                    { "Explosion", "14" },
                                    { "Plaquage", "17" },
                                    { "Provoc", "20" },
                                    { "Dynamopoing", "23" },
                                    { "Lame de Roc", "26" },
                                    { "Piege de Roc", "30" },
                                    { "Ampleur", "38" },
                                    { "Tomberoche", "42" },
                                    { "Seisme", "50" }
                                };

                case "ponyta":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "MimiQueue", "4" },
                                    { "Flammeche", "12" },
                                    { "Nitrocharge", "16" },
                                    { "Pied Voltige", "20" },
                                    { "Danseflamme", "24" },
                                    { "Ampleur", "28" },
                                    { "LanceFlammes", "36" },
                                    { "Effort", "40" },
                                    { "Deflagration", "44" },
                                    { "Galop Infernal", "48" },
                                    { "DemiTour", "52" }
                                };

                case "galopa":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "MimiQueue", "1" },
                                    { "Vitesse Extreme", "1" },
                                    { "Flammeche", "12" },
                                    { "Nitrocharge", "16" },
                                    { "Pied Voltige", "20" },
                                    { "Danseflamme", "24" },
                                    { "Ampleur", "28" },
                                    { "LanceFlammes", "40" },
                                    { "Effort", "46" },
                                    { "Deflagration", "52" },
                                    { "Galop Infernal", "58" },
                                    { "DemiTour", "64" }
                                };

                case "ramoloss":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Tourniquet", "1" },
                                    { "Calinerie", "6" },
                                    { "Belier", "12" },
                                    { "Choc Mental", "18" },
                                    { "Pistolet à O", "24" },
                                    { "Amnesie", "30" },
                                    { "Hydroqueue", "36" },
                                    { "Psyko", "42" },
                                    { "Relache", "48" },
                                    { "Seisme", "54" },
                                    { "Degommage", "60" },
                                    { "Luminocanon", "66" },
                                    { "Cascade", "72" },
                                    { "Plaquage", "78" },
                                    { "LanceFlammes", "84" },
                                    { "Psychoboost", "90" }
                                };

                case "flagadoss":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Tourniquet", "1" },
                                    { "Calinerie", "1" },
                                    { "Belier", "1" },
                                    { "Choc Mental", "18" },
                                    { "Pistolet à O", "24" },
                                    { "Amnesie", "30" },
                                    { "Hydroqueue", "36" },
                                    { "Psyko", "43" },
                                    { "Relache", "50" },
                                    { "Seisme", "57" },
                                    { "Degommage", "64" },
                                    { "Luminocanon", "71" },
                                    { "Cascade", "78" },
                                    { "Plaquage", "85" },
                                    { "LanceFlammes", "92" },
                                    { "Psychoboost", "99" }
                                };

                case "magneti":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Eclair", "1" },
                                    { "Supersonik", "5" },
                                    { "CageEclair", "11" },
                                    { "Jet de Sable", "15" },
                                    { "Force Cosmik", "21" },
                                    { "Onde de Choc", "25" },
                                    { "Mur de Fer", "31" },
                                    { "Electacle", "35" },
                                    { "Triplattaque", "41" },
                                    { "Flash", "45" },
                                    { "Zap Cannon", "51" },
                                    { "Gravite", "55" },
                                    { "MagneContrôle", "61" },
                                    { "Magnetic Flux", "65" },
                                    { "Tonnerre", "71" },
                                    { "Explosion", "75" }
                                };

                case "magneton":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Eclair", "1" },
                                    { "Supersonik", "1" },
                                    { "CageEclair", "1" },
                                    { "Jet de Sable", "15" },
                                    { "Force Cosmik", "21" },
                                    { "Onde de Choc", "25" },
                                    { "Mur de Fer", "31" },
                                    { "Electacle", "35" },
                                    { "Triplattaque", "41" },
                                    { "Flash", "45" },
                                    { "Zap Cannon", "51" },
                                    { "Gravite", "55" },
                                    { "MagneContrôle", "61" },
                                    { "Magnetic Flux", "65" },
                                    { "Tonnerre", "71" },
                                    { "Explosion", "75" }
                                };

                case "canarticho":
                    return new Dictionary<string, string>()
                                {
                                    { "Picpic", "1" },
                                    { "Etonnement", "1" },
                                    { "Grincement", "4" },
                                    { "Bec Vrille", "8" },
                                    { "MimiQueue", "12" },
                                    { "Faux Chage", "16" },
                                    { "Plaquage", "20" },
                                    { "Furie", "24" },
                                    { "Tranche", "28" },
                                    { "Plongee", "32" },
                                    { "Lame d'Air", "36" },
                                    { "CruAile", "40" },
                                    { "Danse Plume", "44" },
                                    { "Hate", "56" },
                                    { "Lame Sainte", "60" },
                                };

                case "doduo":
                    return new Dictionary<string, string>()
                                {
                                    { "Rugissement", "1" },
                                    { "Picpic", "1" },
                                    { "ViveAttaque", "5" },
                                    { "CruAile", "10" },
                                    { "Furie", "15" },
                                    { "Pique", "20" },
                                    { "Danse Plume", "25" },
                                    { "Tornade", "30" },
                                    { "Tranche", "35" },
                                    { "Sabotage", "40" },
                                    { "Lame d'Air", "45" },
                                    { "Dracocharge", "50" },
                                    { "Danse Lames", "55" },
                                    { "Hate", "60" },
                                };

                case "dodrio":
                    return new Dictionary<string, string>()
                                {
                                    { "Rugissement", "1" },
                                    { "Picpic", "1" },
                                    { "ViveAttaque", "1" },
                                    { "CruAile", "1" },
                                    { "Furie", "15" },
                                    { "Pique", "20" },
                                    { "Danse Plume", "25" },
                                    { "Tornade", "30" },
                                    { "Tranche", "38" },
                                    { "Sabotage", "46" },
                                    { "Lame d'Air", "54" },
                                    { "Dracocharge", "62" },
                                    { "Danse Lames", "70" },
                                    { "Hate", "78" },
                                };

                case "otaria":
                    return new Dictionary<string, string>()
                                {
                                    { "Vent Glace", "1" },
                                    { "Rugissement", "1" },
                                    { "Groz'Yeux", "1" },
                                    { "Pistolet à O", "7" },
                                    { "Blizzard", "13" },
                                    { "Encornebois", "19" },
                                    { "Pouvoir Antique", "25" },
                                    { "Brouillard", "31" },
                                    { "Grele", "37" },
                                    { "Hydrocanon", "43" },
                                    { "HurleTemps", "49" }
                                };

                case "lamantine":
                    return new Dictionary<string, string>()
                                {
                                    { "Vent Glace", "1" },
                                    { "Rugissement", "1" },
                                    { "Groz'Yeux", "1" },
                                    { "Pistolet à O", "1" },
                                    { "Blizzard", "13" },
                                    { "Encornebois", "19" },
                                    { "Pouvoir Antique", "25" },
                                    { "Brouillard", "31" },
                                    { "Grele", "38" },
                                    { "Hydrocanon", "47" },
                                    { "HurleTemps", "56" }
                                };

                case "tadmorv":
                    return new Dictionary<string, string>()
                                {
                                    { "Acide", "1" },
                                    { "BombBeurk", "1" },
                                    { "DardVenin", "30" },
                                    { "Detritus", "39" }
                                };

                case "grotadmorv":
                    return new Dictionary<string, string>()
                                {
                                    { "Acide", "1" },
                                    { "BombBeurk", "1" },
                                    { "DardVenin", "1" },
                                    { "Detritus", "1" },
                                    { "BueeNoire", "54" }
                                };

                case "kokiyas":
                    return new Dictionary<string, string>()
                                {
                                    { "Retour", "1" },
                                    { "Survinsecte", "1" },
                                    { "Protection", "17" },
                                    { "Surf", "27" }
                                };

                case "crustabri":
                    return new Dictionary<string, string>()
                                {
                                    { "Retour", "1" },
                                    { "Survinsecte", "1" },
                                    { "Protection", "1" },
                                    { "Surf", "1" },
                                    { "Plaquage", "44" },
                                    { "Onde Boreale", "54" }
                                };

                case "fantominus":
                    return new Dictionary<string, string>()
                                {
                                    { "Lechouille", "1" },
                                    { "Hypnose", "1" },
                                    { "Cauchemar", "27" },
                                    { "BallOmbre", "37" }
                                };

                case "spectrum":
                    return new Dictionary<string, string>()
                                {
                                    { "Lechouille", "1" },
                                    { "Hypnose", "1" },
                                    { "Cauchemar", "15" },
                                    { "BallOmbre", "20" },
                                    { "Explosion", "53" }
                                };

                case "ectoplasma":
                    return new Dictionary<string, string>()
                                {
                                    { "Lechouille", "1" },
                                    { "Hypnose", "1" },
                                    { "Cauchemar", "1" },
                                    { "BallOmbre", "1" },
                                    { "Explosion", "1" },
                                    { "Griffe Ombre", "40" }
                                };

                case "onix":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "JetPierres", "13" },
                                    { "Damocles", "23" }
                                };

                case "soporifik":
                    return new Dictionary<string, string>()
                                {
                                    { "Cauchemar", "1" },
                                    { "Choc Mental", "1" },
                                    { "RafalePsy", "17" },
                                    { "Psyko", "25" }
                                };

                case "hypnomade":
                    return new Dictionary<string, string>()
                                {
                                    { "Cauchemar", "1" },
                                    { "Choc Mental", "1" },
                                    { "RafasePsy", "1" },
                                    { "Psyko", "42" },
                                    { "CoupdBoule", "49" }
                                };

                case "krabby":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Levee de Boue", "1" },
                                    { "Pistolet a O", "12" },
                                    { "Surf", "20" }
                                };

                case "krabboss":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Levee de Boue", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Surf", "1" },
                                    { "Martobois", "44" },
                                    { "Hydrocanon", "52" }
                                };

                case "voltorbe":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Sonicboom", "1" },
                                    { "Tonnerre", "17" },
                                    { "Explosion", "22" }
                                };

                case "electrode":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Sonicboom", "1" },
                                    { "Tonnerre", "1" },
                                    { "Explosion", "1" },
                                    { "Rayon Signal", "44" },
                                    { "Calinerie", "52" }
                                };

                case "noeunoeuf":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Brouillard", "1" },
                                    { "Poudre Dodo", "13" },
                                    { "Psychocroc", "19" }
                                };

                case "noadkoko":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Brouillard", "1" },
                                    { "Poudre Dodo", "1" },
                                    { "Psychocroc", "1" },
                                    { "Luminocanon", "44" },
                                    { "Deflagration", "52" }
                                };

                case "osselait":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Osmerang", "13" },
                                    { "MassdOs", "23" }
                                };

                case "ossatueur":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Osmerang", "1" },
                                    { "MassdOs", "1" },
                                    { "DanseLames", "44" },
                                    { "Seisme", "52" }
                                };

                case "kicklee":
                    return new Dictionary<string, string>()
                                {
                                    { "ForcePoing", "1" },
                                    { "MawashiGeri", "1" },
                                    { "PiedSaute", "20" },
                                    { "Balayage", "30" }
                                };

                case "tygnon":
                    return new Dictionary<string, string>()
                                {
                                    { "Poing de Feu", "1" },
                                    { "Poingeclair", "1" },
                                    { "PoingGlace", "20" },
                                    { "PoingKarate", "30" }
                                };

                case "excelangue":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Lechouille", "23" },
                                };

                case "smogo":
                    return new Dictionary<string, string>()
                                {
                                    { "Acide", "1" },
                                    { "DardVenin", "1" },
                                    { "Explosion", "32" },
                                    { "Brouillard", "39" }
                                };

                case "smogogo":
                    return new Dictionary<string, string>()
                                {
                                    { "Acide", "1" },
                                    { "DardVenin", "1" },
                                    { "Brouillard", "1" },
                                    { "Explosion", "1" },
                                    { "Detritus", "45" },
                                    { "Toxic", "49" }
                                };

                case "rhinocorne":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Rugissement", "1" },
                                    { "Frappe Atlas", "30" },
                                    { "Tete de Fer", "40" }
                                };

                case "rhinoferos":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Rugissement", "1" },
                                    { "Frappe Atlas", "1" },
                                    { "Tete de Fer", "34" },
                                    { "Tete de Roc", "44" },
                                    { "Seisme", "51" }
                                };

                case "leveinard":
                    return new Dictionary<string, string>()
                                {
                                    { "eclats Glace", "1" },
                                    { "Doux Parfum", "1" },
                                    { "ecoSphere", "18" },
                                    { "Vibra Soin", "36" }
                                };

                case "saquedeneu":
                    return new Dictionary<string, string>()
                                {
                                    { "Vampirisme", "1" },
                                    { "Poudre Toxik", "1" },
                                    { "Growth", "35" },
                                    { "Canon Graine", "44" }
                                };

                case "kangourex":
                    return new Dictionary<string, string>()
                                {
                                    { "Coupe", "1" },
                                    { "Repos", "1" },
                                    { "Griffe Ombre", "25" },
                                    { "Machouille", "35" }
                                };

                case "hypotrempe":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Brouillard", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Laser Glace", "17" },
                                    { "Hydrocanon", "26" }
                                };

                case "hypocean":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Brouillard", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Laser Glace", "1" },
                                    { "Hydrocanon", "48" }
                                };

                case "poissirene":
                    return new Dictionary<string, string>()
                                {
                                    { "Ultrason", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Laser Glace", "15" },
                                    { "Hydrocanon", "25" }
                                };

                case "poissoroy":
                    return new Dictionary<string, string>()
                                {
                                    { "Ultrason", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Laser Glace", "1" },
                                    { "Hydrocanon", "34" },
                                    { "Tornade", "40" },
                                    { "Surf", "48" }
                                };

                case "stari":
                    return new Dictionary<string, string>()
                                {
                                    { "Ultrason", "1" },
                                    { "Charge", "1" },
                                    { "GrozYeux", "12" },
                                    { "Pistolet a O", "18" }
                                };

                case "staross":
                    return new Dictionary<string, string>()
                                {
                                    { "Ultrason", "1" },
                                    { "Charge", "1" },
                                    { "GrozYeux", "1" },
                                    { "Pistolet a O", "1" },
                                    { "Rebondifeu", "40" },
                                    { "Hydrocanon", "47" }
                                };

                case "mmime":
                    return new Dictionary<string, string>()
                                {
                                    { "Baillement", "1" },
                                    { "eclats Glace", "1" },
                                    { "Mur Lumiere", "23" },
                                    { "Psyko", "33" }
                                };

                case "insecateur":
                    return new Dictionary<string, string>()
                                {
                                    { "Tranche", "1" },
                                    { "Furie", "1" },
                                    { "LameFeuille", "17" },
                                    { "Vampirisme", "29" }
                                };

                case "lippoutou":
                    return new Dictionary<string, string>()
                                {
                                    { "Charme", "1" },
                                    { "eclats Glace", "1" },
                                    { "Poudreuse", "17" },
                                    { "Vibra Soin", "31" }
                                };

                case "elektek":
                    return new Dictionary<string, string>()
                                {
                                    { "Poingeclair", "1" },
                                    { "Poing de Feu", "1" },
                                    { "PoingGlace", "1" },
                                    { "PoingKarate", "1" },
                                    { "Tonnerre", "53" }
                                };

                case "magmar":
                    return new Dictionary<string, string>()
                                {
                                    { "Embrasement", "1" },
                                    { "Poing de Feu", "1" },
                                    { "Danseflamme", "1" },
                                    { "Megacorne", "1" },
                                    { "LanceFlammes", "52" }
                                };

                case "scarabrute":
                    return new Dictionary<string, string>()
                                {
                                    { "Griffe", "1" },
                                    { "Charge", "1" },
                                    { "ViveAttaque", "17" },
                                    { "Pique", "28" }
                                };

                case "tauros":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Cornebre", "23" },
                                    { "Megacorne", "33" }
                                };

                case "magicarpe":
                    return new Dictionary<string, string>()
                                {
                                    { "Trempette", "1" }
                                };

                case "leviator":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Trempette", "1" },
                                    { "Danse Pluie", "25" },
                                    { "Hydrocanon", "51" }
                                };

                case "lokhlass":
                    return new Dictionary<string, string>()
                                {
                                    { "ecume", "1" },
                                    { "Vent Glace", "1" },
                                    { "Laser Glace", "1" },
                                    { "Blizzard", "1" },
                                    { "Hydrocanon", "51" }
                                };

                case "metamorph":
                    return new Dictionary<string, string>()
                                {
                                    { "Morphing", "1" }
                                };

                case "evoli":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Meteores", "1" },
                                    { "Choc Mental", "1" },
                                    { "Belier", "37" }
                                };

                case "aquali":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Meteores", "1" },
                                    { "Choc Mental", "1" },
                                    { "Hydrocanon", "1" },
                                    { "Vibraqua", "31" }
                                };

                case "voltali":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Meteores", "1" },
                                    { "Choc Mental", "1" },
                                    { "Tonnerre", "1" },
                                    { "FatalFoudre", "31" }
                                };

                case "pyroli":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "ViveAttaque", "1" },
                                    { "Meteores", "1" },
                                    { "Choc Mental", "1" },
                                    { "Deflagration", "1" },
                                    { "LanceFlammes", "31" }
                                };

                case "porygon":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Conversion", "1" },
                                    { "Vitesse", "1" },
                                    { "Psyko", "23" },
                                    { "Triplattaque", "30" }
                                };

                case "amonita":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Repos", "1" },
                                    { "Jet de Sable", "34" },
                                    { "Hydrocanon", "43" }
                                };

                case "amonistar":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Repos", "1" },
                                    { "Jet de Sable", "1" },
                                    { "Hydrocanon", "1" },
                                    { "Tornade", "43" },
                                    { "Surf", "52" }
                                };

                case "kabuto":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Jet de Sable", "34" },
                                    { "Hydrocanon", "43" }
                                };

                case "kabutops":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Jet de Sable", "1" },
                                    { "Hydrocanon", "1" },
                                    { "LameFeuille", "43" },
                                    { "DanseLames", "52" }
                                };

                case "ptera":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Jet de Sable", "1" },
                                    { "Morsure", "1" },
                                    { "Hurlement", "1" },
                                    { "Crocs eclair", "43" },
                                    { "Danse Draco", "52" }
                                };

                case "ronflex":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Rugissement", "1" },
                                    { "Metronome", "1" },
                                    { "Baillement", "1" },
                                    { "Giga Impact", "43" },
                                    { "Apaisement", "52" }
                                };

                case "artikodin":
                    return new Dictionary<string, string>()
                                {
                                    { "ViveAttaque", "1" },
                                    { "Vent Glace", "1" },
                                    { "Blizzard", "1" },
                                    { "Poudreuse", "43" },
                                    { "Laser Glace", "52" }
                                };

                case "electhor":
                    return new Dictionary<string, string>()
                                {
                                    { "ViveAttaque", "1" },
                                    { "Cageeclair", "1" },
                                    { "Tonnerre", "1" },
                                    { "FatalFoudre", "1" },
                                    { "eclair", "52" }
                                };

                case "sulfura":
                    return new Dictionary<string, string>()
                                {
                                    { "ViveAttaque", "1" },
                                    { "Danseflamme", "1" },
                                    { "Deflagration", "1" },
                                    { "LanceFlammes", "1" },
                                };

                case "minidraco":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Pistolet a O", "1" },
                                    { "ecume", "10" },
                                    { "Dracosouffle", "20" }
                                };

                case "draco":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Pistolet a O", "1" },
                                    { "ecume", "1" },
                                    { "Dracosouffle", "1" },
                                    { "CruAile", "40" },
                                    { "Danse Draco", "50" }
                                };

                case "dracolosse":
                    return new Dictionary<string, string>()
                                {
                                    { "Charge", "1" },
                                    { "Pistolet a O", "1" },
                                    { "ecume", "1" },
                                    { "Dracosouffle", "1" },
                                    { "CruAile", "40" },
                                    { "Colere", "50" }
                                };

                case "mewtwo":
                    return new Dictionary<string, string>()
                                {
                                    { "ViveAttaque", "1" },
                                    { "Baillement", "1" },
                                    { "Rugissement", "1" },
                                    { "Psyko", "11" },
                                    { "Laser Glace", "22" },
                                };

                case "mew":
                    return new Dictionary<string, string>()
                                {
                                    { "ViveAttaque", "1" },
                                    { "Baillement", "1" },
                                    { "Rugissement", "1" },
                                    { "Psyko", "1" },
                                    { "Laser Glace", "22" },
                                };
                case "mamadot":
                    return new Dictionary<string, string>()
                                {
                                    { "Clonage", "1" },
                                    { "Soin", "1" },
                                    { "Toxic", "1" },
                                    { "FrappeAtlas", "1" },
                                    { "Entrave", "1" },
                                    { "OndeFolie", "1" },
                                    { "CrocFatal", "1" },
                                    { "Etreinte", "1" },
                                };
                default:
                    throw new AttackNotFoundException( $"Erreur learnset {name}" );
            }
        }
    }
}
