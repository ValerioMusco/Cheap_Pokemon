using Pokemon.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models {
    public static class PokemonLearnset {

        public static Dictionary<string, string> GetLearnSet( string name ) {

            return name.ToLower() switch {
                "bulbizarre" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1"},
                    { "Croissance", "3" },
                    { "ViveAttaque", "7" },
                    { "TranchHerbe", "13" },
                    { "Morsure", "20" },
                    { "LanceSoleil", "32" }
                },
                "herbizarre" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1"},
                    { "Croissance", "1" },
                    { "ViveAttaque", "1" },
                    { "TranchHerbe", "1" },
                    { "FouetLianes", "15" },
                    { "Morsure", "20" },
                    { "LanceSoleil", "32" }
                },
                "florizarre" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Croissance", "1" },
                    { "ViveAttaque", "1" },
                    { "TranchHerbe", "1" },
                    { "FouetLianes", "1" },
                    { "Morsure", "1" },
                    { "LanceSoleil", "39" }
                },
                "salameche" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "MimiQueue", "1" },
                    { "Flammeche", "7" },
                    { "Brouillard", "10" }
                },
                "reptincel" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Flammeche", "1" },
                    { "MimiQueue", "1" },
                    { "Brouillard", "1" },
                    { "Danse Flamme", "19" },
                    { "Morsure", "24" }
                },
                "dracaufeu" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Flammeche", "1" },
                    { "MimiQueue", "1" },
                    { "Brouillard", "1" },
                    { "Danse Flamme", "1" },
                    { "Morsure", "1" },
                    { "LanceFlammes", "1" },
                    { "Deflagration", "57" }
                },
                "carapuce" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Pistolet a O", "4" },
                    { "MimiQueue", "7" },
                    { "Ecume", "10" }
                },
                "carabaffe" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Pistolet a O", "1" },
                    { "MimiQueue", "1" },
                    { "Ecume", "13" },
                    { "Bulle dO", "16" },
                    { "Surf", "21" }
                },
                "tortank" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Pistolet a O", "1" },
                    { "MimiQueue", "1" },
                    { "Ecume", "1" },
                    { "Bulle dO", "1" },
                    { "Surf", "1" },
                    { "Hydrocanon", "42" }
                },
                "chenipan" => new Dictionary<string, string>(){

                    { "Charge", "1" }
                },
                "chrysacier" => new Dictionary<string, string>(){

                    { "Armure", "1" }
                },
                "papilusion" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Poudre Toxik", "1" },
                    { "Tornade", "1" },
                    { "Poudre Dodo", "12" },
                    { "Psyko", "16" }
                },
                "aspicot" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Secretion", "1" }
                },
                "coconfort" => new Dictionary<string, string>(){

                    { "Bouclier", "1" }
                },
                "dardargnan" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Secretion", "1" },
                    { "Pique", "12" },
                    { "ComboGriffe", "15" },
                    { "DardVenin", "20" },
                    { "BecVrille", "26" }
                },
                "roucool" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Tornade", "1" },
                    { "Jet de Sable", "5" },
                    { "ViveAttaque", "9" }
                },
                "roucoups" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Tornade", "1" },
                    { "Jet de Sable", "1" },
                    { "ViveAttaque", "13" },
                    { "CruAile", "18" },
                },
                "roucarnage" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Tornade", "1" },
                    { "Jet de Sable", "1" },
                    { "ViveAttaque", "1" },
                    { "CruAile", "1" },
                    { "Cyclone", "44" }
                },
                "rattata" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "MimiQueue", "1" },
                    { "Morsure", "4" },
                    { "Crocs Givre", "9" }
                },
                "rattatac" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "MimiQueue", "1" },
                    { "Morsure", "1" },
                    { "Crocs Givre", "1" },
                    { "Ultimapoing", "23" },
                    { "Danse Lames", "32" }
                },
                "piafabec" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Picpic", "1" },
                    { "GrozYeux", "4" },
                    { "ViveAttaque", "9" }
                },
                "rapasdepic" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Picpic", "1" },
                    { "GrozYeux", "1" },
                    { "ViveAttaque", "1" },
                    { "Furie", "20" },
                    { "LanceSoleil", "31" }
                },
                "abo" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Morsure", "1" },
                    { "GrozYeux", "10" },
                    { "Croc de Mort", "17" }
                },
                "arbok" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Morsure", "1" },
                    { "GrozYeux", "1" },
                    { "Croc de Mort", "1" },
                    { "Ligotage", "44" }
                },
                "pikachu" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "ViveAttaque", "1" },
                    { "Eclair", "5" },
                    { "Tonnerre", "25" }
                },
                "raichu" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "ViveAttaque", "1" },
                    { "Eclair", "1" },
                    { "Tonnerre", "33" },
                    { "FatalFoudre", "42" }
                },
                "sabelette" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Jet de Sable", "10" },
                    { "Tunnel", "17" }
                },
                "sablaireau" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Jet de Sable", "1" },
                    { "Tunnel", "1" },
                    { "LanceFlammes", "41" }
                },
                "nidoranf" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "DardVenin", "8" },
                    { "Morsure", "12" }
                },
                "nidorina" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "DardVenin", "1" },
                    { "Morsure", "1" },
                    { "Double Pied", "30" },
                    { "Plaquage", "38" }
                },
                "nidoqueen" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "DardVenin", "1" },
                    { "Morsure", "1" },
                    { "Double Pied", "1" },
                },
                "nidoranm" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "DardVenin", "8" },
                    { "Morsure", "12" }
                },
                "nidorino" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "DardVenin", "1" },
                    { "Morsure", "1" },
                    { "Double Pied", "30" },
                    { "EmpalKorne", "38" }
                },
                "nidoking" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "DardVenin", "1" },
                    { "Morsure", "1" },
                    { "Double Pied", "1" },
                    { "Furie", "24" },
                    { "Seisme", "38" }
                },
                "melofee" => new Dictionary<string, string>(){

                    { "Metronome", "1" },
                    { "ViveAttaque", "13" },
                },
                "melodelfe" => new Dictionary<string, string>(){

                    { "Metronome", "1" },
                    { "ViveAttaque", "1" }
                },
                "goupix" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Flammeche", "7" }
                },
                "feunard" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Flammeche", "1" },
                    { "LanceFlammes", "57" }
                },
                "rondoudou" => new Dictionary<string, string>(){

                    { "Metronome", "1" },
                    { "ViveAttaque", "9" }
                },
                "grodoudou" => new Dictionary<string, string>(){

                    { "Metronome", "1" },
                    { "ViveAttaque", "1" }
                },
                "nosferapti" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Vampirisme", "10" },
                    { "CruAile", "15" }
                },
                "nosferalto" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Vampirisme", "1" },
                    { "CruAile", "1" },
                    { "Soin", "49" }
                },
                "mystherbe" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" },
                    { "TranchHerbe", "14" }
                },
                "ortide" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" },
                    { "TranchHerbe", "1" },
                    { "MegaSangsue", "49" }
                },
                "rafflesia" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" },
                    { "TranchHerbe", "1" },
                    { "Toxik", "1" },
                    { "MegaSangsue", "49" }
                },
                "paras" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Vampirisme", "13" },
                    { "TranchHerbe", "20" }
                },
                "parasect" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Vampirisme", "1" },
                    { "TranchHerbe", "1" },
                    { "Spore", "60" }
                },
                "mimitoss" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Vampirisme", "1" },
                    { "GrozYeux", "13" }
                },
                "aeromite" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Vampirisme", "1" },
                    { "GrozYeux", "1" },
                    { "DanseLames", "60" }
                },
                "taupiqueur" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Jet de Sable", "10" },
                    { "Tunnel", "17" }
                },
                "triopikeur" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Jet de Sable", "1" },
                    { "Tunnel", "1" },
                    { "Triplattaque", "41" }
                },
                "miaouss" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Morsure", "12" },
                    { "Jet de Sable", "19" }
                },
                "persian" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "GrozYeux", "1" },
                    { "Morsure", "1" },
                    { "Jet de Sable", "1" },
                    { "ComboGriffe", "45" }
                },
                "psykokwak" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Belier", "1" },
                    { "Pistolet a O", "13" },
                    { "Hydrocanon", "20" }
                },
                "akwakwak" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Belier", "1" },
                    { "Pistolet a O", "1" },
                    { "Hydrocanon", "34" },
                    { "Amnesie", "45" }
                },
                "ferosinge" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "ComboGriffe", "15" },
                    { "PoingKarate", "21" }
                },
                "colossinge" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "ComboGriffe", "1" },
                    { "PoingKarate", "43" },
                    { "Poing de Feu", "52" }
                },
                "caninos" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Flammeche", "9" },
                    { "Morsure", "14" }
                },
                "arcanin" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Flammeche", "1" },
                    { "Morsure", "1" },
                    { "Danse Flamme", "41" }
                },
                "ptitard" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Hypnose", "1" },
                    { "Bulle dO", "15" },
                    { "Hydrocanon", "19" }
                },
                "tetarte" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Hypnose", "1" },
                    { "Bulle dO", "1" },
                    { "Hydrocanon", "1" }
                },
                "tartard" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Hypnose", "1" },
                    { "Bulle dO", "1" },
                    { "Hydrocanon", "1" },
                    { "Explosion", "57" }
                },
                "abra" => new Dictionary<string, string>(){

                    { "Teleport", "1" }
                },
                "kadabra" => new Dictionary<string, string>(){

                    { "Teleport", "1" },
                    { "Pistolet a O", "1" },
                    { "Regard Medusant", "1" },
                    { "Choc Mental", "36" },
                    { "Psyko", "41" }
                },
                "alakazam" => new Dictionary<string, string>(){

                    { "Teleport", "1" },
                    { "Regard Medusant", "1" },
                    { "Choc Mental", "1" },
                    { "Psyko", "36" },
                },
                "machoc" => new Dictionary<string, string>(){

                    { "Poing de Feu", "1" },
                    { "Poingeclair", "1" },
                    { "Frappe Atlas", "21" },
                },
                "machopeur" => new Dictionary<string, string>(){

                    { "Poing de Feu", "1" },
                    { "Poingeclair", "1" },
                    { "Frappe Atlas", "1" },
                    { "Seisme", "37" }
                },
                "mackogneur" => new Dictionary<string, string>(){

                    { "Poing de Feu", "1" },
                    { "Poingeclair", "1" },
                    { "Frappe Atlas", "1" },
                    { "Seisme", "1" },
                    { "Balayage", "37" },
                    { "PoingGlace", "52" }
                },
                "chetiflor" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" },
                    { "TranchHerbe", "14" }
                },
                "boustiflor" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" },
                    { "TranchHerbe", "1" },
                    { "MegaSangsue", "26" }
                },
                "empiflor" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" },
                    { "TranchHerbe", "1" },
                    { "Toxik", "1" },
                    { "Explosion", "50" }
                },
                "tentacool" => new Dictionary<string, string>(){

                    { "Ecume", "1" },
                    { "Ligotage", "4" },
                    { "Secretion", "10" },
                    { "Pistolet a O", "13" },
                    { "Hydrocanon", "16" },
                    { "Surf", "19" },
                    { "Acidarmure", "22" },
                    { "Reflet", "28" },
                    { "Pique", "34" },
                    { "Toxik", "37" },
                    { "Cascade", "40" }
                },
                "tentacruel" => new Dictionary<string, string>(){

                    { "Ecume", "1" },
                    { "Ligotage", "1" },
                    { "Secretion", "1" },
                    { "Pistolet a O", "13" },
                    { "Hydrocanon", "16" },
                    { "Surf", "19" },
                    { "Acidarmure", "22" },
                    { "Reflet", "28" },
                    { "Pique", "38" },
                    { "Toxik", "43" },
                    { "Cascade", "48" }
                },
                "racaillou" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "JetPierres", "4" },
                    { "Eboulement", "10" },
                    { "Explosion", "14" },
                    { "Plaquage", "17" },
                    { "Seisme", "46" }
                },
                "gravalanch" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "JetPierres", "1" },
                    { "Eboulement", "1" },
                    { "Explosion", "14" },
                    { "Plaquage", "17" },
                    { "Seisme", "50" }
                },
                "grolem" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "JetPierres", "1" },
                    { "Eboulement", "1" },
                    { "Explosion", "14" },
                    { "Plaquage", "17" },
                    { "Seisme", "50" }
                },
                "ponyta" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "MimiQueue", "4" },
                    { "Flammeche", "12" },
                    { "Pied Voltige", "20" },
                    { "Danseflamme", "24" },
                    { "LanceFlammes", "36" },
                    { "Deflagration", "44" }
                },
                "galopa" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "MimiQueue", "1" },
                    { "Flammeche", "12" },
                    { "Pied Voltige", "20" },
                    { "Danseflamme", "24" },
                    { "LanceFlammes", "40" },
                    { "Deflagration", "52" }
                },
                "ramoloss" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Belier", "12" },
                    { "Choc Mental", "18" },
                    { "Pistolet a O", "24" },
                    { "Amnesie", "30" },
                    { "Psyko", "42" },
                    { "Seisme", "54" },
                    { "Cascade", "72" },
                    { "Plaquage", "78" },
                    { "LanceFlammes", "84" }
                },
                "flagadoss" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Belier", "1" },
                    { "Choc Mental", "18" },
                    { "Pistolet a O", "24" },
                    { "Amnesie", "30" },
                    { "Psyko", "43" },
                    { "Seisme", "57" },
                    { "Cascade", "78" },
                    { "Plaquage", "85" }
                },
                "magneti" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Eclair", "1" },
                    { "CageEclair", "11" },
                    { "Jet de Sable", "15" },
                    { "Triplattaque", "41" },
                    { "Flash", "45" },
                    { "Tonnerre", "71" },
                    { "Explosion", "75" }
                },
                "magneton" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Eclair", "1" },
                    { "CageEclair", "1" },
                    { "Jet de Sable", "15" },
                    { "Triplattaque", "41" },
                    { "Flash", "45" },
                    { "Tonnerre", "71" },
                    { "Explosion", "75" }
                },
                "canarticho" => new Dictionary<string, string>(){

                    { "Picpic", "1" },
                    { "Grincement", "4" },
                    { "Bec Vrille", "8" },
                    { "MimiQueue", "12" },
                    { "Plaquage", "20" },
                    { "Furie", "24" },
                    { "Tranche", "28" },
                    { "CruAile", "40" },
                    { "Hate", "56" },
                },
                "doduo" => new Dictionary<string, string>(){

                    { "Rugissement", "1" },
                    { "Picpic", "1" },
                    { "ViveAttaque", "5" },
                    { "CruAile", "10" },
                    { "Furie", "15" },
                    { "Pique", "20" },
                    { "Tornade", "30" },
                    { "Tranche", "35" },
                    { "Dracocharge", "50" },
                    { "Danse Lames", "55" },
                    { "Hate", "60" },
                },
                "dodrio" => new Dictionary<string, string>(){

                    { "Rugissement", "1" },
                    { "Picpic", "1" },
                    { "ViveAttaque", "1" },
                    { "CruAile", "1" },
                    { "Furie", "15" },
                    { "Pique", "20" },
                    { "Tornade", "30" },
                    { "Tranche", "38" },
                    { "Dracocharge", "62" },
                    { "Danse Lames", "70" },
                    { "Hate", "78" },
                },
                "otaria" => new Dictionary<string, string>(){

                    { "Rugissement", "1" },
                    { "GrozYeux", "1" },
                    { "Pistolet a O", "7" },
                    { "Blizzard", "13" },
                    { "Brouillard", "31" },
                    { "Hydrocanon", "43" },
                },
                "lamantine" => new Dictionary<string, string>(){

                    { "Rugissement", "1" },
                    { "GrozYeux", "1" },
                    { "Pistolet a O", "1" },
                    { "Blizzard", "13" },
                    { "Brouillard", "31" },
                    { "Hydrocanon", "47" }
                },
                "tadmorv" => new Dictionary<string, string>(){

                    { "Acide", "1" },
                    { "DardVenin", "30" },
                    { "Detritus", "39" }
                },
                "grotadmorv" => new Dictionary<string, string>(){

                    { "Acide", "1" },
                    { "DardVenin", "1" },
                    { "Detritus", "1" },
                    { "BueeNoire", "54" }
                },
                "kokiyas" => new Dictionary<string, string>(){

                    { "Protection", "1" },
                    { "Surf", "1" }
                },
                "crustabri" => new Dictionary<string, string>(){

                    { "Protection", "1" },
                    { "Surf", "1" },
                    { "Plaquage", "44" },
                    { "Onde Boreale", "54" }
                },
                "fantominus" => new Dictionary<string, string>(){

                    { "Lechouille", "1" },
                    { "Hypnose", "1" },
                },
                "spectrum" => new Dictionary<string, string>(){

                    { "Lechouille", "1" },
                    { "Hypnose", "1" },
                    { "Explosion", "53" }
                },
                "ectoplasma" => new Dictionary<string, string>(){

                    { "Lechouille", "1" },
                    { "Hypnose", "1" },
                    { "Explosion", "1" },
                },
                "onix" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "JetPierres", "13" },
                    { "Damocles", "23" }
                },
                "soporifik" => new Dictionary<string, string>(){

                    { "Choc Mental", "1" },
                    { "RafalePsy", "17" },
                    { "Psyko", "25" }
                },
                "hypnomade" => new Dictionary<string, string>(){

                    { "Choc Mental", "1" },
                    { "RafalePsy", "1" },
                    { "Psyko", "42" },
                    { "CoupdBoule", "49" }
                },
                "krabby" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Pistolet a O", "12" },
                    { "Surf", "20" }
                },
                "krabboss" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Pistolet a O", "1" },
                    { "Surf", "1" },
                    { "Hydrocanon", "52" }
                },
                "voltorbe" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Sonicboom", "1" },
                    { "Tonnerre", "17" },
                    { "Explosion", "22" }
                },
                "electrode" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Sonicboom", "1" },
                    { "Tonnerre", "1" },
                    { "Explosion", "1" }
                },
                "noeunoeuf" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Brouillard", "1" },
                    { "Poudre Dodo", "13" },
                },
                "noadkoko" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Brouillard", "1" },
                    { "Poudre Dodo", "1" },
                    { "Deflagration", "52" }
                },
                "osselait" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "Osmerang", "13" },
                    { "MassdOs", "23" }
                },
                "ossatueur" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "Osmerang", "1" },
                    { "MassdOs", "1" },
                    { "DanseLames", "44" },
                    { "Seisme", "52" }
                },
                "kicklee" => new Dictionary<string, string>(){

                    { "ForcePoing", "1" },
                    { "MawashiGeri", "1" },
                    { "PiedSaute", "20" },
                    { "Balayage", "30" }
                },
                "tygnon" => new Dictionary<string, string>(){

                    { "Poing de Feu", "1" },
                    { "Poingeclair", "1" },
                    { "PoingGlace", "20" },
                    { "PoingKarate", "30" }
                },
                "excelangue" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "ViveAttaque", "1" },
                    { "Lechouille", "23" },
                },
                "smogo" => new Dictionary<string, string>(){

                    { "Acide", "1" },
                    { "DardVenin", "1" },
                    { "Explosion", "32" },
                    { "Brouillard", "39" }
                },
                "smogogo" => new Dictionary<string, string>(){

                    { "Acide", "1" },
                    { "DardVenin", "1" },
                    { "Brouillard", "1" },
                    { "Explosion", "1" },
                    { "Detritus", "45" },
                    { "Toxik", "49" }
                },
                "rhinocorne" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Frappe Atlas", "30" }
                },
                "rhinoferos" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Frappe Atlas", "1" },
                    { "Seisme", "51" }
                },
                "leveinard" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Frappe Atlas", "1" },
                },
                "saquedeneu" => new Dictionary<string, string>(){

                    { "Vampirisme", "1" },
                    { "Poudre Toxik", "1" }
                },
                "kangourex" => new Dictionary<string, string>(){

                    { "Coupe", "1" },
                    { "Repos", "1" }
                },
                "hypotrempe" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Brouillard", "1" },
                    { "Pistolet a O", "1" },
                    { "Laser Glace", "17" },
                    { "Hydrocanon", "26" }
                },
                "hypocean" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Brouillard", "1" },
                    { "Pistolet a O", "1" },
                    { "Laser Glace", "1" },
                    { "Hydrocanon", "48" }
                },
                "poissirene" => new Dictionary<string, string>(){

                    { "Ultrason", "1" },
                    { "Pistolet a O", "1" },
                    { "Laser Glace", "15" },
                    { "Hydrocanon", "25" }
                },
                "poissoroy" => new Dictionary<string, string>(){

                    { "Ultrason", "1" },
                    { "Pistolet a O", "1" },
                    { "Laser Glace", "1" },
                    { "Hydrocanon", "34" },
                    { "Tornade", "40" },
                    { "Surf", "48" }
                },
                "stari" => new Dictionary<string, string>(){

                    { "Ultrason", "1" },
                    { "Charge", "1" },
                    { "GrozYeux", "12" },
                    { "Pistolet a O", "18" }
                },
                "staross" => new Dictionary<string, string>(){

                    { "Ultrason", "1" },
                    { "Charge", "1" },
                    { "GrozYeux", "1" },
                    { "Pistolet a O", "1" },
                    { "Hydrocanon", "47" }
                },
                "mmime" => new Dictionary<string, string>(){

                    { "Mur Lumiere", "1" },
                    { "Psyko", "33" }
                },
                "insecateur" => new Dictionary<string, string>(){

                    { "Tranche", "1" },
                    { "Furie", "1" },
                    { "Vampirisme", "29" }
                },
                "lippoutou" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Rugissement", "1" },
                    { "Frappe Atlas", "1" },
                },
                "elektek" => new Dictionary<string, string>(){

                    { "Poingeclair", "1" },
                    { "Poing de Feu", "1" },
                    { "PoingGlace", "1" },
                    { "PoingKarate", "1" },
                    { "Tonnerre", "53" }
                },
                "magmar" => new Dictionary<string, string>(){

                    { "Poing de Feu", "1" },
                    { "Danseflamme", "1" },
                    { "LanceFlammes", "52" }
                },
                "scarabrute" => new Dictionary<string, string>(){

                    { "Griffe", "1" },
                    { "Charge", "1" },
                    { "ViveAttaque", "17" },
                    { "Pique", "28" }
                },
                "tauros" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                },
                "magicarpe" => new Dictionary<string, string>(){

                    { "Trempette", "1" }
                },
                "leviator" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Trempette", "1" },
                    { "Hydrocanon", "51" }
                },
                "lokhlass" => new Dictionary<string, string>(){

                    { "ecume", "1" },
                    { "Laser Glace", "1" },
                    { "Blizzard", "1" },
                    { "Hydrocanon", "51" }
                },
                "metamorph" => new Dictionary<string, string>(){

                    { "Morphing", "1" }
                },
                "evoli" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "ViveAttaque", "1" },
                    { "Meteores", "1" },
                    { "Choc Mental", "1" },
                    { "Belier", "37" }
                },
                "aquali" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "ViveAttaque", "1" },
                    { "Meteores", "1" },
                    { "Choc Mental", "1" },
                    { "Hydrocanon", "1" },
                    { "Surf", "31" }
                },
                "voltali" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "ViveAttaque", "1" },
                    { "Meteores", "1" },
                    { "Choc Mental", "1" },
                    { "Tonnerre", "1" },
                    { "FatalFoudre", "31" }
                },
                "pyroli" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "ViveAttaque", "1" },
                    { "Meteores", "1" },
                    { "Choc Mental", "1" },
                    { "Deflagration", "1" },
                    { "LanceFlammes", "31" }
                },
                "porygon" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Conversion", "1" },
                    { "Psyko", "23" },
                    { "Triplattaque", "30" }
                },
                "amonita" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Repos", "1" },
                    { "Jet de Sable", "34" },
                    { "Hydrocanon", "43" }
                },
                "amonistar" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Repos", "1" },
                    { "Jet de Sable", "1" },
                    { "Hydrocanon", "1" },
                    { "Tornade", "43" },
                    { "Surf", "52" }
                },
                "kabuto" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "Jet de Sable", "34" },
                    { "Hydrocanon", "43" }
                },
                "kabutops" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "Jet de Sable", "1" },
                    { "Hydrocanon", "1" },
                    { "DanseLames", "52" }
                },
                "ptera" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "Jet de Sable", "1" },
                    { "Morsure", "1" },
                    { "Hurlement", "1" },
                    { "Danse Draco", "52" }
                },
                "ronflex" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Rugissement", "1" },
                    { "Metronome", "1" },
                },
                "artikodin" => new Dictionary<string, string>(){

                    { "ViveAttaque", "1" },
                    { "Blizzard", "1" },
                    { "Laser Glace", "52" }
                },
                "electhor" => new Dictionary<string, string>(){

                    { "ViveAttaque", "1" },
                    { "Cageeclair", "1" },
                    { "Tonnerre", "1" },
                    { "FatalFoudre", "1" },
                    { "eclair", "52" }
                },
                "sulfura" => new Dictionary<string, string>(){

                    { "ViveAttaque", "1" },
                    { "Danseflamme", "1" },
                    { "Deflagration", "1" },
                    { "LanceFlammes", "1" },
                },
                "minidraco" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Pistolet a O", "1" },
                    { "ecume", "10" },
                },
                "draco" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Pistolet a O", "1" },
                    { "ecume", "1" },
                    { "CruAile", "40" },
                    { "Danse Draco", "50" }
                },
                "dracolosse" => new Dictionary<string, string>(){

                    { "Charge", "1" },
                    { "Pistolet a O", "1" },
                    { "ecume", "1" },
                    { "CruAile", "40" },
                    { "Danse Draco", "50" }
                },
                "mewtwo" => new Dictionary<string, string>(){

                    { "ViveAttaque", "1" },
                    { "Rugissement", "1" },
                    { "Psyko", "11" },
                    { "Laser Glace", "22" },
                },
                "mew" => new Dictionary<string, string>(){

                    { "ViveAttaque", "1" },
                    { "Rugissement", "1" },
                    { "Psyko", "1" },
                    { "Laser Glace", "22" },
                },
                "mamadot" => new Dictionary<string, string>(){

                    { "Clonage", "1" },
                    { "Soin", "1" },
                    { "Toxik", "1" },
                    { "FrappeAtlas", "1" },
                    { "Entrave", "1" },
                    { "OndeFolie", "1" },
                    { "CrocFatal", "1" },
                    { "Etreinte", "1" },
                },
                _ => throw new AttackNotFoundException( $"Erreur learnset {name}" ),
            };
        }
    }
}
