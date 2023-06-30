// A changer pour un switch. Non plus un dictionnaire<string, dictionnaire<string, string>> mais switch(string nom) ==> dictionnaire<string, string>

Dictionary<string, Dictionary<string, string>> learnset = new Dictionary<string, Dictionary<string, string>>()
{
    {
        "Bulbizarre", new Dictionary<string, string>()
        {
            { "Charge", "1" },
	        { "Rugissement", "1"},
            { "Croissance", "3" },
            { "ViveAttaque", "7" },
            { "TranchHerbe", "13" },
            { "Morsure", "20" },
            { "LanceSoleil", "32" }
        }
    },
    {
        "Herbizarre", new Dictionary<string, string>()
        {
            { "Charge", "1" },
	        { "Rugissement", "1"},
            { "Croissance", "1" },
            { "ViveAttaque", "1" },
            { "TranchHerbe", "1" },
            { "Fouet Lianes", "15" },
            { "Morsure", "20" },
            { "LanceSoleil", "32" }
        }
    },
    {
        "Florizarre", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Croissance", "1" },
            { "ViveAttaque", "1" },
            { "TranchHerbe", "1" },
            { "Fouet Lianes", "1" },
            { "Morsure", "1" },
            { "LanceSoleil", "1" },
            { "LanceSoleil", "39" }
        }
    },
    {
        "Salameche", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "MimiQueue", "1" },
            { "Flammeche", "7" },
            { "Brouillard", "10" }
        }
    },
    {
        "Reptincel", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Flammeche", "1" },
            { "MimiQueue", "1" },
            { "Brouillard", "1" },
            { "Danse Flamme", "19" },
            { "Morsure", "24" }
        }
    },
    {
        "Dracaufeu", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Flameche", "1" },
            { "MimiQueue", "1" },
            { "Brouillard", "1" },
            { "Danse Flamme", "1" },
            { "Morsure", "1" },
            { "LanceFlammes", "1" },
            { "Deflagration", "57" }
        }
    },
    {
        "Carapuce", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Pistolet a O", "4" },
            { "MimiQueue", "7" },
            { "Ecume", "10" }
        }
    },
    {
        "Carabaffe", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Pistolet a O", "1" },
            { "MimiQueue", "1" },
            { "Ecume", "1" },
            { "Ecume", "13" },
            { "Bulles dO", "16" },
            { "Vibraqua", "21" }
        }
    },
    {
        "Tortank", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Pistolet a O", "1" },
            { "MimiQueue", "1" },
            { "Ecume", "1" },
            { "Ecume", "1" },
            { "Bulles dO", "1" },
            { "Vibraqua", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "42" }
        }
    },
    {
        "Chenipan", new Dictionary<string, string>()
        {
            { "Charge", "1" }
        }
    },
    {
        "Chrysacier", new Dictionary<string, string>()
        {
            { "Charge", "1" }
        }
    },
    {
        "Papilusion", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Poudre Toxik", "1" },
            { "Tornade", "1" },
            { "Vent Argente", "1" },
            { "Vent Argente", "10" },
            { "Poudre Dodo", "12" },
            { "Psyko", "16" }
        }
    },
    {
        "Aspicot", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Secretion", "1" }
        }
    },
    {
        "Coconfort", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Secretion", "1" }
        }
    },
    {
        "Dardargnan", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Secretion", "1" },
            { "Piqure", "1" },
            { "Piqure", "12" },
            { "Poudre Dodo", "15" },
            { "Toxic", "20" },
            { "BombBeurk", "26" }
        }
    },
    {
        "Roucool", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Tornade", "1" },
            { "Jet de Sable", "5" },
            { "ViveAttaque", "9" }
        }
    },
    {
        "Roucoups", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Tornade", "1" },
            { "Jet de Sable", "1" },
            { "ViveAttaque", "1" },
            { "ViveAttaque", "13" },
            { "CruAile", "18" },
            { "CruAile", "36" }
        }
    },
    {
        "Roucarnage", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Tornade", "1" },
            { "Jet de Sable", "1" },
            { "ViveAttaque", "1" },
            { "ViveAttaque", "1" },
            { "CruAile", "1" },
            { "CruAile", "1" },
            { "Cyclone", "1" },
            { "Cyclone", "44" }
        }
    },
    {
        "Rattata", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "MimiQueue", "1" },
            { "Morsure", "4" },
            { "Crocs Givre", "9" }
        }
    },
    {
        "Rattatac", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "MimiQueue", "1" },
            { "Morsure", "1" },
            { "Crocs Givre", "1" },
            { "Crocs Givre", "16" },
            { "Ultimapoing", "23" },
            { "Danse Lames", "32" }
        }
    },
    {
        "Piafabec", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Picpic", "1" },
            { "GrozYeux", "4" },
            { "ViveAttaque", "9" }
        }
    },
    {
        "Rapasdepic", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Picpic", "1" },
            { "GrozYeux", "1" },
            { "ViveAttaque", "1" },
            { "ViveAttaque", "1" },
            { "Furie", "1" },
            { "Furie", "20" },
            { "LanceSoleil", "31" }
        }
    },
    {
        "Abo", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Morsure", "1" },
            { "GrozYeux", "10" },
            { "Croc de Mort", "17" }
        }
    },
    {
        "Arbok", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Morsure", "1" },
            { "GrozYeux", "1" },
            { "Croc de Mort", "1" },
            { "Croc de Mort", "1" },
            { "Glare", "1" },
            { "Glare", "33" },
            { "Ligotage", "44" }
        }
    },
    {
        "Pikachu", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "ViveAttaque", "1" },
            { "Eclair", "5" },
            { "Foudre", "9" }
        }
    },
    {
        "Raichu", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "ViveAttaque", "1" },
            { "Eclair", "1" },
            { "Foudre", "1" },
            { "Queue de Fer", "1" },
            { "Tonnerre", "1" },
            { "Tonnerre", "33" },
            { "FatalFoudre", "42" }
        }
    },
    {
        "Sabelette", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Jet de Sable", "10" },
            { "Tunnel", "17" }
        }
    },
    {
        "Sablaireau", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Jet de Sable", "1" },
            { "Tunnel", "1" },
            { "Tunnel", "1" },
            { "Tunnel", "27" },
            { "LanceFlammes", "41" }
        }
    },
    {
        "Nidoranf" , new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "DardVenin", "8" },
            { "Morsure", "12" }
        }
    },
    {
        "Nidorina", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "DardVenin", "1" },
            { "Morsure", "1" },
            { "Morsure", "23" },
            { "Double Pied", "30" },
            { "Plaquage", "38" }
        }
    },
    {
        "Nidoqueen", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "DardVenin", "1" },
            { "Morsure", "1" },
            { "Morsure", "1" },
            { "Double Pied", "1" },
            { "Double Pied", "1" },
            { "Ruse", "1" },
            { "Ruse", "24" },
            { "Contre", "38" }
        }
    },
    {
        "Nidoranm" , new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "DardVenin", "8" },
            { "Morsure", "12" }
        }
    },
    {
        "Nidorino", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "DardVenin", "1" },
            { "Morsure", "1" },
            { "Morsure", "23" },
            { "Double Pied", "30" },
            { "EmpalKorne", "38" }
        }
    },
    {
        "Nidoking", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "DardVenin", "1" },
            { "Morsure", "1" },
            { "Morsure", "1" },
            { "Double Pied", "1" },
            { "Double Pied", "1" },
            { "Furie", "1" },
            { "Furie", "24" },
            { "Seisme", "38" }
        }
    },
    {
        "Melofee", new Dictionary<string, string>()
        {
            { "Charme", "1" },
            { "Metronome", "1" },
            { "ViveAttaque", "13" },
            { "Doux Parfum", "19" }
        }
    },
    {
        "Melodelfe", new Dictionary<string, string>()
        {
            { "Charme", "1" },
            { "Metronome", "1" },
            { "ViveAttaque", "1" },
            { "Doux Parfum", "1" },
            { "Metronome", "1" },
            { "Metronome", "48" },
            { "Rayon Lune", "52" }
        }
    },
    {
        "Goupix", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Rugissement", "1" },
            { "Flameche", "7" },
            { "Pouvoir Antique", "12" }
        }
    },
    {
        "Feunard", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Rugissement", "1" },
            { "Flameche", "1" },
            { "Pouvoir Antique", "1" },
            { "Pouvoir Antique", "1" },
            { "Pouvoir Antique", "52" },
            { "LanceFlammes", "57" }
        }
    },
    {
        "Rondoudou", new Dictionary<string, string>()
        {
            { "Charme", "1" },
            { "Metronome", "1" },
            { "ViveAttaque", "9" },
            { "Roulade", "14" }
        }
    },
    {
        "Grodoudou", new Dictionary<string, string>()
        {
            { "Charme", "1" },
            { "Metronome", "1" },
            { "ViveAttaque", "1" },
            { "Roulade", "1" },
            { "Roulade", "1" },
            { "Roulade", "44" },
            { "Regeneration", "49" }
        }
    },
    {
        "Nosferapti", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Supersonic", "1" },
            { "Vampirisme", "10" },
            { "CruAile", "15" }
        }
    },
    {
        "Nosferalto", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Supersonic", "1" },
            { "Vampirisme", "1" },
            { "CruAile", "1" },
            { "CruAile", "1" },
            { "CruAile", "44" },
            { "Soin", "49" }
        }
    },
    {
        "Mystherbe", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "7" },
            { "TranchHerbe", "14" }
        }
    },
    {
        "Ortide", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "44" },
            { "MegaSangsue", "49" }
        }
    },
    {
        "Rafflesia", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "Toxik", "1" },
            { "Toxik", "1" },
            { "GigaSangsue", "1" },
            { "GigaSangsue", "55" }
        }
    },
    {
        "Paras", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Vampirisme", "13" },
            { "TranchHerbe", "20" }
        }
    },
    {
        "Parasect", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Vampirisme", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "Spore", "1" },
            { "Spore", "60" }
        }
    },
    {
        "Mimitoss", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Vampirisme", "1" },
            { "GrozYeux", "13" },
            { "Megacorne", "20" }
        }
    },
    {
        "Aeromite", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Vampirisme", "1" },
            { "GrozYeux", "1" },
            { "Megacorne", "1" },
            { "Megacorne", "1" },
            { "Megacorne", "1" },
            { "Megacorne", "1" },
            { "Megacorne", "1" },
            { "DanseLames", "1" },
            { "DanseLames", "60" }
        }
    },
    {
        "Taupiqueur", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Jet de Sable", "10" },
            { "Tunnel", "17" }
        }
    },
    {
        "Triopikeur", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Jet de Sable", "1" },
            { "Tunnel", "1" },
            { "Tunnel", "1" },
            { "Tunnel", "27" },
            { "LanceFlammes", "41" }
        }
    },
    {
        "Miaouss", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Morsure", "12" },
            { "Jet de Sable", "19" }
        }
    },
    {
        "Persian", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "GrozYeux", "1" },
            { "Morsure", "1" },
            { "Jet de Sable", "1" },
            { "Jet de Sable", "1" },
            { "Jet de Sable", "34" },
            { "Laser Glace", "45" }
        }
    },
    {
        "Psykokwak", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Belier", "1" },
            { "Pistolet a O", "13" },
            { "Hydrocanon", "20" }
        }
    },
    {
        "Akwakwak", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Belier", "1" },
            { "Pistolet a O", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "34" },
            { "Amnesie", "45" }
        }
    },
    {
        "Ferosinge", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Flair", "1" },
            { "ComboGriffe", "15" },
            { "PoingKarate", "21" }
        }
    },
    {
        "Colossinge", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Flair", "1" },
            { "ComboGriffe", "1" },
            { "PoingKarate", "1" },
            { "PoingKarate", "1" },
            { "PoingKarate", "43" },
            { "Poing de Feu", "52" }
        }
    },
    {
        "Caninos", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Rugissement", "1" },
            { "Flameche", "9" },
            { "Morsure", "14" }
        }
    },
    {
        "Arcanin", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Rugissement", "1" },
            { "Flameche", "1" },
            { "Morsure", "1" },
            { "Morsure", "1" },
            { "Morsure", "34" },
            { "Danse Flamme", "41" }
        }
    },
    {
        "Ptitard", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Hypnose", "1" },
            { "Bulle dO", "15" },
            { "Hydrocanon", "19" }
        }
    },
    {
        "Tetarte", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Hypnose", "1" },
            { "Bulle dO", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "34" },
            { "Cognobidon", "45" }
        }
    },
    {
        "Tartard", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Hypnose", "1" },
            { "Bulle dO", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Cognobidon", "1" },
            { "Cognobidon", "52" },
            { "Explosion", "57" }
        }
    },
    {
        "Abra", new Dictionary<string, string>()
        {
            { "Teleport", "1" }
        }
    },
    {
        "Kadabra", new Dictionary<string, string>()
        {
            { "Teleport", "1" },
            { "Pistolet a O", "1" },
            { "Regard Medusant", "1" },
            { "Choc Mental", "1" },
            { "Choc Mental", "1" },
            { "Choc Mental", "36" },
            { "Psyko", "41" }
        }
    },
    {
        "Alakazam", new Dictionary<string, string>()
        {
            { "Teleport", "1" },
            { "Pistolet a O", "1" },
            { "Regard Medusant", "1" },
            { "Choc Mental", "1" },
            { "Choc Mental", "1" },
            { "Choc Mental", "1" },
            { "Choc Mental", "1" },
            { "Choc Mental", "1" },
            { "Psyko", "1" },
            { "Psyko", "36" },
            { "Chatiment", "46" }
        }
    },
    {
        "Machoc", new Dictionary<string, string>()
        {
            { "Poing de Feu", "1" },
            { "Poingeclair", "1" },
            { "Frappe Atlas", "21" },
            { "MitraPoing", "26" }
        }
    },
    {
        "Machopeur", new Dictionary<string, string>()
        {
            { "Poing de Feu", "1" },
            { "Poingeclair", "1" },
            { "Frappe Atlas", "1" },
            { "MitraPoing", "1" },
            { "MitraPoing", "1" },
            { "MitraPoing", "32" },
            { "Seisme", "37" }
        }
    },
    {
        "Mackogneur", new Dictionary<string, string>()
        {
            { "Poing de Feu", "1" },
            { "Poingeclair", "1" },
            { "Frappe Atlas", "1" },
            { "MitraPoing", "1" },
            { "MitraPoing", "1" },
            { "MitraPoing", "1" },
            { "MitraPoing", "1" },
            { "MitraPoing", "1" },
            { "Seisme", "1" },
            { "Seisme", "32" },
            { "Balayage", "37" },
            { "PoingGlace", "52" }
        }
    },
    {
        "Chetiflor", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "7" },
            { "TranchHerbe", "14" }
        }
    },
    {
        "Boustiflor", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "21" },
            { "MegaSangsue", "26" }
        }
    },
    {
        "Empiflor", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "TranchHerbe", "1" },
            { "Toxik", "1" },
            { "Toxik", "1" },
            { "GigaSangsue", "1" },
            { "GigaSangsue", "45" },
            { "Explosion", "50" }
        }
    },
    {
        "Tadmorv", new Dictionary<string, string>()
        {
            { "Acide", "1" },
            { "BombBeurk", "1" },
            { "DardVenin", "30" },
            { "Detritus", "39" }
        }
    },
    {
        "Grotadmorv", new Dictionary<string, string>()
        {
            { "Acide", "1" },
            { "BombBeurk", "1" },
            { "DardVenin", "1" },
            { "Detritus", "1" },
            { "Detritus", "1" },
            { "Detritus", "34" },
            { "Detritus", "44" },
            { "BombBeurk", "54" }
        }
    },
    {
        "Kokiyas", new Dictionary<string, string>()
        {
            { "Retour", "1" },
            { "Survinsecte", "1" },
            { "Protection", "17" },
            { "Surf", "27" }
        }
    },
    {
        "Crustabri", new Dictionary<string, string>()
        {
            { "Retour", "1" },
            { "Survinsecte", "1" },
            { "Protection", "1" },
            { "Surf", "1" },
            { "Surf", "1" },
            { "Surf", "34" },
            { "Plaquage", "44" },
            { "Onde Boreale", "54" }
        }
    },
    {
        "Fantominus", new Dictionary<string, string>()
        {
            { "Lechouille", "1" },
            { "Hypnose", "1" },
            { "Cauchemar", "27" },
            { "BallOmbre", "37" }
        }
    },
    {
        "Spectrum", new Dictionary<string, string>()
        {
            { "Lechouille", "1" },
            { "Hypnose", "1" },
            { "Cauchemar", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "34" },
            { "BallOmbre", "43" },
            { "Explosion", "53" }
        }
    },
    {
        "Ectoplasma", new Dictionary<string, string>()
        {
            { "Lechouille", "1" },
            { "Hypnose", "1" },
            { "Cauchemar", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "Explosion", "1" },
            { "Explosion", "34" },
            { "Griffe Ombre", "40" },
            { "Surchauffe", "47" }
        }
    },
    {
        "Onix", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "JetPierres", "13" },
            { "Damocles", "23" }
        }
    },
    {
        "Soporifik", new Dictionary<string, string>()
        {
            { "Cauchemar", "1" },
            { "Choc Mental", "1" },
            { "MegaSangsue", "17" },
            { "BallOmbre", "25" }
        }
    },
    {
        "Hypnomade", new Dictionary<string, string>()
        {
            { "Cauchemar", "1" },
            { "Choc Mental", "1" },
            { "MegaSangsue", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "BallOmbre", "1" },
            { "Explosion", "1" },
            { "Explosion", "34" },
            { "Griffe Ombre", "42" },
            { "Seisme", "49" }
        }
    },
    {
        "Krabby", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Levee de Boue", "1" },
            { "Pistolet a O", "12" },
            { "Surf", "20" }
        }
    },
    {
        "Krabboss", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Levee de Boue", "1" },
            { "Pistolet a O", "1" },
            { "Surf", "1" },
            { "Surf", "1" },
            { "Surf", "34" },
            { "Martobois", "44" },
            { "Hydrocanon", "52" }
        }
    },
    {
        "Voltorbe", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Sonicboom", "1" },
            { "Tonnerre", "17" },
            { "Explosion", "22" }
        }
    },
    {
        "electrode", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Sonicboom", "1" },
            { "Tonnerre", "1" },
            { "Explosion", "1" },
            { "Explosion", "1" },
            { "Explosion", "34" },
            { "Rayon Signal", "44" },
            { "Calinerie", "52" }
        }
    },
    {
        "Noeunoeuf", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Brouillard", "1" },
            { "Poudre Dodo", "13" },
            { "Psychocroc", "19" }
        }
    },
    {
        "Noadkoko", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Brouillard", "1" },
            { "Poudre Dodo", "1" },
            { "Psychocroc", "1" },
            { "Psychocroc", "1" },
            { "Psychocroc", "34" },
            { "Luminocanon", "44" },
            { "Deflagration", "52" }
        }
    },
    {
        "Osselait", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Osmerang", "13" },
            { "MassdOs", "23" }
        }
    },
    {
        "Ossatueur", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Osmerang", "1" },
            { "MassdOs", "1" },
            { "MassdOs", "1" },
            { "MassdOs", "34" },
            { "DanseLames", "44" },
            { "Seisme", "52" }
        }
    },
    {
        "Kicklee", new Dictionary<string, string>()
        {
            { "MegaSangsue", "1" },
            { "Mawashi Geri", "1" },
            { "Luminocanon", "20" },
            { "Balayage", "30" }
        }
    },
    {
        "Tygnon", new Dictionary<string, string>()
        {
            { "Poing de Feu", "1" },
            { "Poingeclair", "1" },
            { "PoingGlace", "20" },
            { "PoingKarate", "30" }
        }
    },
    {
        "Excelangue", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "ViveAttaque", "1" },
            { "Lechouille", "23" },
            { "Lechouille", "30" }
        }
    },
    {
        "Smogo", new Dictionary<string, string>()
        {
            { "Acide", "1" },
            { "DardVenin", "1" },
            { "DardVenin", "32" },
            { "Brouillard", "39" }
        }
    },
    {
        "Smogogo", new Dictionary<string, string>()
        {
            { "Acide", "1" },
            { "DardVenin", "1" },
            { "DardVenin", "1" },
            { "Brouillard", "1" },
            { "Brouillard", "1" },
            { "Brouillard", "32" },
            { "Brouillard", "1" },
            { "Brouillard", "1" },
            { "Explosion", "1" },
            { "Explosion", "39" },
            { "Detritus", "45" },
            { "Toxic", "49" }
        }
    },
    {
        "Rhinocorne", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Rugissement", "1" },
            { "Frappe Atlas", "30" },
            { "Tete de Fer", "40" }
        }
    },
    {
        "Rhinoferos", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Rugissement", "1" },
            { "Frappe Atlas", "1" },
            { "Tete de Fer", "1" },
            { "Tete de Fer", "1" },
            { "Tete de Fer", "34" },
            { "Tete de Roc", "44" },
            { "Seisme", "51" }
        }
    },
    {
        "Leveinard", new Dictionary<string, string>()
        {
            { "eclats Glace", "1" },
            { "Doux Parfum", "1" },
            { "ecoSphere", "18" },
            { "Vibra Soin", "36" }
        }
    },
    {
        "Saquedeneu", new Dictionary<string, string>()
        {
            { "Vampirisme", "1" },
            { "Poudre Toxik", "1" },
            { "Growth", "35" },
            { "Canon Graine", "44" }
        }
    },
    {
        "Kangourex", new Dictionary<string, string>()
        {
            { "Coupe", "1" },
            { "Repos", "1" },
            { "Griffe Ombre", "25" },
            { "Machouille", "35" }
        }
    },
    {
        "Hypotrempe", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Brouillard", "1" },
            { "Pistolet a O", "1" },
            { "Laser Glace", "17" },
            { "Hydrocanon", "26" }
        }
    },
    {
        "Hypocean", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Brouillard", "1" },
            { "Pistolet a O", "1" },
            { "Laser Glace", "1" },
            { "Laser Glace", "1" },
            { "Laser Glace", "34" },
            { "Laser Glace", "40" },
            { "Hydrocanon", "48" }
        }
    },
    {
        "Poissirene", new Dictionary<string, string>()
        {
            { "Ultrason", "1" },
            { "Pistolet a O", "1" },
            { "Laser Glace", "15" },
            { "Hydrocanon", "25" }
        }
    },
    {
        "Poissoroy", new Dictionary<string, string>()
        {
            { "Ultrason", "1" },
            { "Pistolet a O", "1" },
            { "Laser Glace", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "34" },
            { "Tornade", "40" },
            { "Surf", "48" }
        }
    },
    {
        "Stari", new Dictionary<string, string>()
        {
            { "Ultrason", "1" },
            { "Charge", "1" },
            { "GrozYeux", "12" },
            { "Pistolet a O", "18" }
        }
    },
    {
        "Staross", new Dictionary<string, string>()
        {
            { "Ultrason", "1" },
            { "Charge", "1" },
            { "GrozYeux", "1" },
            { "Pistolet a O", "1" },
            { "Pistolet a O", "1" },
            { "Pistolet a O", "34" },
            { "Rebondifeu", "40" },
            { "Hydrocanon", "47" }
        }
    },
    {
        "M. Mime", new Dictionary<string, string>()
        {
            { "Baillement", "1" },
            { "eclats Glace", "1" },
            { "Mur Lumiere", "23" },
            { "Psyko", "33" }
        }
    },
    {
        "Insecateur", new Dictionary<string, string>()
        {
            { "Tranche", "1" },
            { "Furie", "1" },
            { "LameFeuille", "17" },
            { "Vampirisme", "29" }
        }
    },
    {
        "Lippoutou", new Dictionary<string, string>()
        {
            { "Charme", "1" },
            { "eclats Glace", "1" },
            { "Poudreuse", "17" },
            { "Vibra Soin", "31" }
        }
    },
    {
        "elektek", new Dictionary<string, string>()
        {
            { "Poingeclair", "1" },
            { "Poing de Feu", "1" },
            { "PoingGlace", "1" },
            { "PoingKarate", "1" },
            { "Poingeclair", "1" },
            { "Poingeclair", "34" },
            { "Poing de Feu", "43" },
            { "Tonnerre", "53" }
        }
    },
    {
        "Magmar", new Dictionary<string, string>()
        {
            { "Embrasement", "1" },
            { "Poing de Feu", "1" },
            { "Danseflamme", "1" },
            { "Megacorne", "1" },
            { "Embrasement", "1" },
            { "Embrasement", "34" },
            { "Poing de Feu", "43" },
            { "LanceFlammes", "52" }
        }
    },
    {
        "Scarabrute", new Dictionary<string, string>()
        {
            { "Griffe", "1" },
            { "Charge", "1" },
            { "ViveAttaque", "17" },
            { "Pique", "28" }
        }
    },
    {
        "Tauros", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Cornebre", "23" },
            { "Megacorne", "33" }
        }
    },
    {
        "Magicarpe", new Dictionary<string, string>()
        {
            { "Trempette", "1" }
        }
    },
    {
        "Leviator", new Dictionary<string, string>()
        {
            { "Trempette", "1" },
            { "Trempette", "1" },
            { "Trempette", "20" },
            { "Danse Pluie", "25" }
        }
    },
    {
        "Lokhlass", new Dictionary<string, string>()
        {
            { "ecume", "1" },
            { "Vent Glace", "1" },
            { "Laser Glace", "1" },
            { "Blizzard", "1" },
            { "ecume", "1" },
            { "ecume", "34" },
            { "Vent Glace", "44" },
            { "Hydrocanon", "51" }
        }
    },
    {
        "Metamorph", new Dictionary<string, string>()
        {
            { "Morphing", "1" }
        }
    },
    {
        "evoli", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "ViveAttaque", "1" },
            { "Meteores", "1" },
            { "Choc Mental", "1" },
            { "Charge", "1" },
            { "Charge", "27" },
            { "ViveAttaque", "31" },
            { "Belier", "37" }
        }
    },
    {
        "Aquali", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "ViveAttaque", "1" },
            { "Meteores", "1" },
            { "Choc Mental", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "27" },
            { "Vibraqua", "31" }
        }
    },
    {
        "Voltali", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "ViveAttaque", "1" },
            { "Meteores", "1" },
            { "Choc Mental", "1" },
            { "Tonnerre", "1" },
            { "Tonnerre", "1" },
            { "Tonnerre", "27" },
            { "FatalFoudre", "31" }
        }
    },
    {
        "Pyroli", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "ViveAttaque", "1" },
            { "Meteores", "1" },
            { "Choc Mental", "1" },
            { "Deflagration", "1" },
            { "Deflagration", "1" },
            { "Deflagration", "27" },
            { "LanceFlammes", "31" }
        }
    },
    {
        "Porygon", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Conversion", "1" },
            { "Vitesse", "1" },
            { "Psyko", "23" },
            { "Triplattaque", "30" }
        }
    },
    {
        "Amonita", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Repos", "1" },
            { "Jet de Sable", "34" },
            { "Hydrocanon", "43" }
        }
    },
    {
        "Amonistar", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Repos", "1" },
            { "Jet de Sable", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "34" },
            { "Tornade", "43" },
            { "Surf", "52" }
        }
    },
    {
        "Kabuto", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Jet de Sable", "34" },
            { "Hydrocanon", "43" }
        }
    },
    {
        "Kabutops", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Jet de Sable", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "1" },
            { "Hydrocanon", "34" },
            { "LameFeuille", "43" },
            { "DanseLames", "52" }
        }
    },
    {
        "Ptera", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Jet de Sable", "1" },
            { "Morsure", "1" },
            { "Hurlement", "1" },
            { "Hurlement", "1" },
            { "Hurlement", "34" },
            { "Crocs eclair", "43" },
            { "Danse Draco", "52" }
        }
    },
    {
        "Ronflex", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Rugissement", "1" },
            { "Metronome", "1" },
            { "Baillement", "1" },
            { "Baillement", "1" },
            { "Baillement", "34" },
            { "Giga Impact", "43" },
            { "Apaisement", "52" }
        }
    },
    {
        "Artikodin", new Dictionary<string, string>()
        {
            { "ViveAttaque", "1" },
            { "Poudreuse", "1" },
            { "Vent Glace", "1" },
            { "Blizzard", "1" },
            { "ViveAttaque", "1" },
            { "ViveAttaque", "34" },
            { "Poudreuse", "43" },
            { "Laser Glace", "52" }
        }
    },
    {
        "electhor", new Dictionary<string, string>()
        {
            { "ViveAttaque", "1" },
            { "Cageeclair", "1" },
            { "Tonnerre", "1" },
            { "FatalFoudre", "1" },
            { "ViveAttaque", "1" },
            { "ViveAttaque", "34" },
            { "Cageeclair", "43" },
            { "eclair", "52" }
        }
    },
    {
        "Sulfura", new Dictionary<string, string>()
        {
            { "ViveAttaque", "1" },
            { "Danseflamme", "1" },
            { "Deflagration", "1" },
            { "LanceFlammes", "1" },
            { "ViveAttaque", "1" },
            { "ViveAttaque", "34" },
            { "Danseflamme", "43" },
            { "Deflagration", "52" }
        }
    },
    {
        "Minidraco", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Pistolet a O", "1" },
            { "ecume", "10" },
            { "Dracosouffle", "20" }
        }
    },
    {
        "Draco", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Pistolet a O", "1" },
            { "ecume", "1" },
            { "Dracosouffle", "1" },
            { "Dracosouffle", "1" },
            { "Dracosouffle", "20" },
            { "CruAile", "40" },
            { "Danse Draco", "50" }
        }
    },
    {
        "Dracolosse", new Dictionary<string, string>()
        {
            { "Charge", "1" },
            { "Pistolet a O", "1" },
            { "ecume", "1" },
            { "Dracosouffle", "1" },
            { "Dracosouffle", "1" },
            { "Dracosouffle", "20" },
            { "CruAile", "40" },
            { "Colere", "50" }
        }
    },
    {
        "Mewtwo", new Dictionary<string, string>()
        {
            { "ViveAttaque", "1" },
            { "Baillement", "1" },
            { "Rugissement", "1" },
            { "Psyko", "1" },
            { "Psyko", "1" },
            { "Psyko", "11" },
            { "Laser Glace", "22" },
            { "Psyko", "33" }
        }
    },
    {
        "Mew", new Dictionary<string, string>()
        {
            { "ViveAttaque", "1" },
            { "Baillement", "1" },
            { "Rugissement", "1" },
            { "Psyko", "1" },
            { "Psyko", "1" },
            { "Psyko", "11" },
            { "Laser Glace", "22" },
            { "Psyko", "33" }
        }
    }
}