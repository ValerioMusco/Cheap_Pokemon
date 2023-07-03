﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Exceptions;

namespace Pokemon.Models {
    public static class AttackTable {

        public static List<string> getMove( string name ) {

            return name.ToLower() switch {
                "abime" => new List<string> { "--", "None", "Normal", "10", "Met K.O. l'adversaire d'un coup, mais a peu de chances de toucher." },
                "acidarmure" => new List<string> { "--", "DefUp", "Poison", "20", "Augmente la Défense du lanceur." },
                "acide" => new List<string> { "40", "DefSpeDown", "Poison", "30", "Inflige des dégâts. Baisse la Défense Spéciale de l'adversaire." },
                "affutage" => new List<string> { "--", "AtkUp", "Normal", "30", "Augmente l'Attaque du lanceur." },
                "amnesie" => new List<string> { "--", "DefSpeUp", "Psychic", "20", "Augmente la Défense Spéciale du lanceur." },
                "armure" => new List<string> { "--", "DefUp", "Normal", "30", "Augmente la Défense du lanceur." },
                "balayage" => new List<string> { "25", "None", "Fighting", "20", "Inflige des dégâts. Touche toujours l'adversaire." },
                "becvrille" => new List<string> { "80", "Confused", "Normal", "20", "Inflige des dégâts. Peut rendre confus l'adversaire." },
                "belier" => new List<string> { "90", "None", "Normal", "20", "Inflige des dégâts. Blesse aussi l'utilisateur." },
                "berceuse" => new List<string> { "--", "Asleep", "Normal", "15", "Endort l'adversaire." },
                "blizzard" => new List<string> { "110", "Frozen", "Ice", "5", "Inflige des dégâts. Peut geler l'adversaire." },
                "bombeoeuf" => new List<string> { "100", "None", "Normal", "10", "Inflige des dégâts." },
                "bouclier" => new List<string> { "--", "DefUp", "Normal", "30", "Augmente la Défense du lanceur." },
                "boularmure" => new List<string> { "--", "DefUp", "Bug", "20", "Augmente la Défense du lanceur." },
                "brouillard" => new List<string> { "--", "None", "Ice", "20", "Réduit la Précision de l'adversaire." },
                "brume" => new List<string> { "--", "None", "Ice", "30", "Supprime les changements de stats de tous les Pokémon en combat." },
                "bueenoire" => new List<string> { "--", "None", "Ghost", "20", "Protège de toutes les attaques sauf celles qui sont directes." },
                "bulledo" => new List<string> { "40", "SpeedDown", "Water", "30", "Inflige des dégâts. Baisse la Vitesse de l'adversaire." },
                "cageeclair" => new List<string> { "--", "None", "Electric", "20", "Empêche l'adversaire de fuir ou d'être remplacé." },
                "cascade" => new List<string> { "80", "None", "Water", "15", "Inflige des dégâts." },
                "charge" => new List<string> { "35", "None", "Normal", "35", "Inflige des dégâts." },
                "chocmental" => new List<string> { "50", "None", "Psychic", "25", "Inflige des dégâts." },
                "claquoir" => new List<string> { "85", "None", "Water", "10", "Inflige des dégâts." },
                "clonage" => new List<string> { "--", "None", "Normal", "10", "Crée une copie du lanceur pour augmenter son Esquive." },
                "combogriffe" => new List<string> { "18", "None", "Normal", "15", "Inflige des dégâts à 2-5 reprises." },
                "constriction" => new List<string> { "10", "SpeedDown", "Normal", "35", "Inflige des dégâts. Baisse la Vitesse de l'adversaire." },
                "conversion" => new List<string> { "--", "None", "Normal", "30", "Modifie le type du lanceur pour correspondre à sa première attaque." },
                "copie" => new List<string> { "--", "None", "Normal", "20", "Copie la dernière attaque utilisée par l'adversaire." },
                "coudkrane" => new List<string> { "80", "None", "Steel", "15", "Inflige des dégâts." },
                "coupdboule" => new List<string> { "70", "None", "Normal", "15", "Inflige des dégâts." },
                "coupe" => new List<string> { "50", "None", "Normal", "30", "Inflige des dégâts." },
                "coupevent" => new List<string> { "80", "None", "Flying", "10", "Inflige des dégâts." },
                "crocdemort" => new List<string> { "80", "None", "Normal", "15", "Inflige des dégâts." },
                "crocfatal" => new List<string> { "80", "None", "Normal", "15", "Inflige des dégâts." },
                "croissance" => new List<string> { "--", "AtkSpeUp", "Normal", "40", "Augmente l'Attaque Spéciale du lanceur." },
                "cruaile" => new List<string> { "60", "None", "Flying", "20", "Inflige des dégâts." },
                "cyclone" => new List<string> { "--", "None", "Flying", "20", "Fait fuir l'adversaire ou l'empêche d'utiliser une attaque prioritaire." },
                "damocles" => new List<string> { "120", "None", "Normal", "10", "Inflige des dégâts. Blesse aussi l'utilisateur." },
                "danseflamme" => new List<string> { "--", "Burn", "Fire", "15", "Brûle l'adversaire." },
                "dansefleurs" => new List<string> { "--", "AtkSpeUp", "Grass", "10", "Augmente l'Attaque Spéciale du lanceur." },
                "danselames" => new List<string> { "--", "AtkUp", "Normal", "20", "Augmente l'Attaque du lanceur." },
                "dardnuee" => new List<string> { "14", "None", "Bug", "20", "Inflige des dégâts à 2-5 reprises." },
                "dardvenin" => new List<string> { "15", "Poisonned", "Bug", "35", "Inflige des dégâts. Empoisonne l'adversaire." },
                "deflagration" => new List<string> { "110", "Burn", "Fire", "5", "Inflige des dégâts. Brûle l'adversaire." },
                "destruction" => new List<string> { "200", "None", "Normal", "5", "Inflige des dégâts. Blesse aussi l'utilisateur." },
                "detritus" => new List<string> { "60", "None", "Poison", "20", "Inflige des dégâts." },
                "devoreve" => new List<string> { "100", "None", "Psychic", "15", "Inflige des dégâts. Restaure les PV du lanceur à hauteur de la moitié des dégâts infligés." },
                "doubledard" => new List<string> { "25", "None", "Bug", "20", "Inflige des dégâts à 2-5 reprises." },
                "doublepied" => new List<string> { "60", "None", "Fighting", "30", "Inflige des dégâts." },
                "dracorage" => new List<string> { "--", "None", "Dragon", "10", "Inflige des dégâts égaux à la moitié des PV max de l'adversaire." },
                "ecoque" => new List<string> { "--", "DefUp", "Bug", "10", "Augmente la Défense du lanceur." },
                "eboulement" => new List<string> { "75", "None", "Rock", "10", "Inflige des dégâts. Peut faire tomber des rochers sur l'adversaire hors-combat." },
                "eclair" => new List<string> { "40", "Paralysed", "Electric", "30", "Inflige des dégâts. Peut paralyser l'adversaire." },
                "ecrasface" => new List<string> { "40", "None", "Normal", "35", "Inflige des dégâts." },
                "ecrasement" => new List<string> { "65", "None", "Normal", "20", "Inflige des dégâts." },
                "ecume" => new List<string> { "40", "None", "Water", "30", "Inflige des dégâts." },
                "empalkorne" => new List<string> { "100", "None", "Normal", "10", "Inflige des dégâts." },
                "entrave" => new List<string> { "--", "None", "Normal", "20", "Empêche l'adversaire d'utiliser une attaque déjà utilisée." },
                "etreinte" => new List<string> { "15", "None", "Normal", "20", "Inflige des dégâts. Peut empêcher l'adversaire d'attaquer pendant quelques tours." },
                "explosion" => new List<string> { "250", "None", "Normal", "5", "Inflige des dégâts. Blesse aussi l'utilisateur." },
                "fatalfoudre" => new List<string> { "110", "Paralysed", "Electric", "10", "Inflige des dégâts. Peut paralyser l'adversaire." },
                "flammeche" => new List<string> { "40", "Burn", "Fire", "25", "Inflige des dégâts. Brûle l'adversaire." },
                "flash" => new List<string> { "--", "AccuracyDown", "Normal", "20", "Réduit la Précision de l'adversaire." },
                "force" => new List<string> { "80", "None", "Normal", "15", "Inflige des dégâts." },
                "forcepoing" => new List<string> { "150", "None", "Fighting", "5", "Inflige des dégâts." },
                "fouetlianes" => new List<string> { "45", "None", "Grass", "25", "Inflige des dégâts." },
                "frappeatlas" => new List<string> { "40", "None", "Fighting", "20", "Inflige des dégâts." },
                "frenesie" => new List<string> { "20", "None", "Normal", "20", "Inflige des dégâts à 2-5 reprises." },
                "furie" => new List<string> { "15", "None", "Normal", "20", "Inflige des dégâts à 2-5 reprises." },
                "gaztoxik" => new List<string> { "--", "Poisonned", "Poison", "40", "Empoisonne l'adversaire." },
                "griffe" => new List<string> { "40", "None", "Normal", "35", "Inflige des dégâts." },
                "grincement" => new List<string> { "--", "DefDown", "Normal", "40", "Baisse la Défense de l'adversaire." },
                "grobisou" => new List<string> { "--", "Asleep", "Normal", "10", "Endort l'adversaire." },
                "grozyeux" => new List<string> { "--", "AccuracyDown", "Normal", "30", "Baisse la Précision de l'adversaire." },
                "guillotine" => new List<string> { "--", "None", "Normal", "5", "Met K.O. l'adversaire d'un coup, mais a peu de chances de toucher." },
                "hate" => new List<string> { "--", "None", "Normal", "20", "Augmente la Vitesse du lanceur." },
                "hurlement" => new List<string> { "--", "None", "Normal", "20", "Force l'adversaire à être remplacé par un autre Pokémon." },
                "hydrocanon" => new List<string> { "110", "None", "Water", "5", "Inflige des dégâts." },
                "hypnose" => new List<string> { "--", "Asleep", "Psychic", "20", "Endort l'adversaire." },
                "jackpot" => new List<string> { "--", "None", "Normal", "5", "Inflige des dégâts. Plus de dégâts si l'utilisateur a moins de PV." },
                "jetdesable" => new List<string> { "--", "None", "Ground", "15", "Baisse la Précision de l'adversaire." },
                "jetpierres" => new List<string> { "50", "None", "Rock", "10", "Inflige des dégâts." },
                "koudkorne" => new List<string> { "130", "None", "Ice", "5", "Inflige des dégâts." },
                "lanceflammes" => new List<string> { "90", "Burn", "Fire", "15", "Inflige des dégâts. Brûle l'adversaire." },
                "lancesoleil" => new List<string> { "120", "None", "Grass", "10", "Inflige des dégâts. Le lanceur doit recharger au tour suivant." },
                "laserglace" => new List<string> { "90", "None", "Ice", "10", "Inflige des dégâts." },
                "lechouille" => new List<string> { "80", "Paralysed", "Ghost", "10", "Inflige des dégâts. Peut paralyser l'adversaire." },
                "ligotage" => new List<string> { "15", "None", "Normal", "20", "Inflige des dégâts. Peut empêcher l'adversaire d'attaquer pendant quelques tours." },
                "lilliput" => new List<string> { "--", "None", "Normal", "20", "Augmente l'Esquive du lanceur." },
                "lutte" => new List<string> { "50", "None", "Normal", "30", "Inflige des dégâts." },
                "mania" => new List<string> { "120", "None", "Grass", "10", "Inflige des dégâts. Le lanceur doit recharger au tour suivant." },
                "massdos" => new List<string> { "65", "None", "Ground", "20", "Inflige des dégâts." },
                "mawashigeri" => new List<string> { "60", "None", "Fighting", "15", "Inflige des dégâts." },
                "megasangsue" => new List<string> { "40", "None", "Grass", "15", "Inflige des dégâts. Restaure les PV du lanceur à hauteur de la moitié des dégâts infligés." },
                "meteores" => new List<string> { "60", "None", "Psychic", "20", "Inflige des dégâts." },
                "metronome" => new List<string> { "--", "None", "Normal", "10", "Utilise une attaque au hasard parmi toutes les attaques connues." },
                "mimiqueue" => new List<string> { "--", "AccuracyDown", "Normal", "30", "Baisse la Précision de l'adversaire." },
                "mimique" => new List<string> { "--", "None", "Normal", "10", "Copie la dernière attaque utilisée par l'adversaire." },
                "morphing" => new List<string> { "--", "None", "Normal", "10", "Modifie le type du lanceur pour correspondre à la première attaque de l'adversaire." },
                "morsure" => new List<string> { "60", "Flinch", "Normal", "25", "Inflige des dégâts. Peut faire flancher l'adversaire." },
                "murlumiere" => new List<string> { "--", "None", "Psychic", "30", "Réduit les dégâts des attaques spéciales pendant 5 tours." },
                "ombrenocturne" => new List<string> { "95", "None", "Ghost", "15", "Inflige des dégâts." },
                "ondeboreale" => new List<string> { "65", "None", "Ice", "20", "Inflige des dégâts." },
                "ondefolie" => new List<string> { "--", "Confused", "Psychic", "10", "Confuse l'adversaire." },
                "osmerang" => new List<string> { "50", "None", "Ground", "10", "Inflige des dégâts à 2 reprises." },
                "paraspore" => new List<string> { "--", "Paralysed", "Grass", "30", "Paralyse l'adversaire." },
                "patience" => new List<string> { "--", "None", "Normal", "10", "Augmente la Puissance de l'attaque du lanceur à chaque fois qu'il subit des dégâts." },
                "picanon" => new List<string> { "120", "None", "Water", "5", "Inflige des dégâts. Le lanceur doit recharger au tour suivant." },
                "picpic" => new List<string> { "35", "None", "Flying", "35", "Inflige des dégâts." },
                "piedsaute" => new List<string> { "70", "None", "Fighting", "25", "Inflige des dégâts." },
                "piedvoltige" => new List<string> { "85", "None", "Flying", "20", "Inflige des dégâts." },
                "pilonnage" => new List<string> { "15", "None", "Normal", "20", "Inflige des dégâts à 2-5 reprises." },
                "pincemasse" => new List<string> { "90", "None", "Water", "10", "Inflige des dégâts." },
                "pique" => new List<string> { "140", "None", "Normal", "5", "Inflige des dégâts." },
                "pistoletao" => new List<string> { "40", "None", "Water", "25", "Inflige des dégâts." },
                "plaquage" => new List<string> { "85", "None", "Normal", "15", "Inflige des dégâts. Blesse aussi l'utilisateur." },
                "poingcomete" => new List<string> { "100", "None", "Normal", "5", "Inflige des dégâts." },
                "poingeclair" => new List<string> { "75", "Paralysed", "Electric", "15", "Inflige des dégâts. Peut paralyser l'adversaire." },
                "poingdefeu" => new List<string> { "75", "Burn", "Fire", "15", "Inflige des dégâts. Brûle l'adversaire." },
                "poingglace" => new List<string> { "75", "None", "Ice", "15", "Inflige des dégâts." },
                "poingkarate" => new List<string> { "50", "None", "Fighting", "25", "Inflige des dégâts." },
                "poudredodo" => new List<string> { "--", "Asleep", "Bug", "15", "Endort l'adversaire." },
                "poudretoxik" => new List<string> { "--", "Poisonned", "Bug", "20", "Empoisonne l'adversaire." },
                "protection" => new List<string> { "--", "None", "Normal", "20", "Empêche toutes les attaques de toucher le lanceur pendant un tour." },
                "psyko" => new List<string> { "90", "None", "Psychic", "10", "Inflige des dégâts." },
                "puissance" => new List<string> { "60", "None", "Normal", "20", "Inflige des dégâts." },
                "puredpois" => new List<string> { "--", "Poisonned", "Poison", "20", "Empoisonne l'adversaire." },
                "rafalepsy" => new List<string> { "65", "None", "Psychic", "20", "Inflige des dégâts." },
                "reflet" => new List<string> { "--", "None", "Normal", "15", "Augmente l'Esquive du lanceur." },
                "regardmedusant" => new List<string> { "--", "Paralysed", "Normal", "30", "Peut paralyser l'adversaire." },
                "repli" => new List<string> { "--", "None", "Normal", "40", "Augmente la Défense du lanceur." },
                "repos" => new List<string> { "--", "Asleep", "Psychic", "10", "Le lanceur récupère tous ses PV et s'endort pendant 2 tours." },
                "riposte" => new List<string> { "--", "None", "Fighting", "20", "Inflige des dégâts. Si le lanceur est attaqué par une attaque physique, inflige le double des dégâts subis." },
                "rugissement" => new List<string> { "--", "None", "Normal", "40", "Baisse l'Attaque de l'adversaire." },
                "sacrifice" => new List<string> { "--", "None", "Normal", "25", "Blesse l'utilisateur d'un montant égal aux PV max de l'adversaire." },
                "secretion" => new List<string> { "--", "None", "Bug", "40", "Baisse la Vitesse de l'adversaire." },
                "seisme" => new List<string> { "100", "None", "Ground", "10", "Inflige des dégâts. Touche tous les Pokémon en combat sauf le lanceur." },
                "soin" => new List<string> { "--", "None", "Psychic", "10", "Restaure les PV du lanceur." },
                "sonicboom" => new List<string> { "--", "None", "Normal", "20", "Inflige toujours 20 points de dégâts." },
                "souplesse" => new List<string> { "80", "None", "Normal", "20", "Inflige des dégâts." },
                "spore" => new List<string> { "--", "Asleep", "Grass", "15", "Endort l'adversaire." },
                "surf" => new List<string> { "90", "None", "Water", "15", "Inflige des dégâts. Attaque tous les Pokémon en combat sauf le lanceur." },
                "telekinesie" => new List<string> { "--", "None", "Psychic", "15", "Permet d'attaquer les Pokémon de type Sol ou les Pokémon en vol." },
                "teleport" => new List<string> { "--", "None", "Psychic", "20", "Permet de s'échapper d'un combat sauvage." },
                "tonnerre" => new List<string> { "90", "Paralysed", "Electric", "15", "Inflige des dégâts. Peut paralyser l'adversaire." },
                "torgnoles" => new List<string> { "15", "None", "Normal", "10", "Inflige des dégâts à 2-5 reprises." },
                "tornade" => new List<string> { "110", "None", "Flying", "10", "Inflige des dégâts. Peut faire partir l'adversaire en vol." },
                "toxik" => new List<string> { "--", "Poisonned", "Poison", "10", "Empoisonne l'adversaire." },
                "tranchherbe" => new List<string> { "55", "None", "Grass", "25", "Inflige des dégâts." },
                "tranche" => new List<string> { "70", "None", "Normal", "20", "Inflige des dégâts." },
                "trempette" => new List<string> { "--", "None", "Water", "40", "Le lanceur est trempé. Ne fait rien si le terrain est un autre type que l'Eau." },
                "triplattaque" => new List<string> { "80", "None", "Normal", "10", "Inflige des dégâts. Peut brûler, paralyser ou geler l'adversaire." },
                "tunnel" => new List<string> { "80", "None", "Ground", "10", "Inflige des dégâts. Peut augmenter la Défense du lanceur." },
                "ultimapoing" => new List<string> { "80", "None", "Normal", "5", "Inflige des dégâts." },
                "utlimawashi" => new List<string> { "85", "None", "Fighting", "5", "Inflige des dégâts." },
                "ultralaser" => new List<string> { "150", "None", "Normal", "5", "Inflige des dégâts. Le lanceur doit recharger au tour suivant." },
                "ultrason" => new List<string> { "20", "None", "Normal", "20", "Inflige des dégâts. Peut empêcher l'adversaire d'attaquer pendant quelques tours." },
                "uppercut" => new List<string> { "70", "None", "Fighting", "20", "Inflige des dégâts." },
                "vaguepsy" => new List<string> { "90", "None", "Psychic", "10", "Inflige des dégâts." },
                "vampigraine" => new List<string> { "--", "None", "Grass", "10", "Plante des graines sur l'adversaire. Le lanceur récupère des PV à chaque tour." },
                "vampirisme" => new List<string> { "20", "None", "Normal", "15", "Inflige des dégâts. Le lanceur récupère des PV à hauteur de la moitié des dégâts infligés." },
                "viveattaque" => new List<string> { "70", "None", "Normal", "20", "Inflige des dégâts." },
                "vol" => new List<string> { "90", "None", "Flying", "15", "Inflige des dégâts. Le lanceur s'envole et attaque au tour suivant." },
                "volevie" => new List<string> { "20", "None", "Grass", "25", "Inflige des dégâts. Le lanceur récupère des PV à hauteur de la moitié des dégâts infligés." },
                "yoga" => new List<string> { "0", "None", "Psychic", "40", "Augmente l'Attaque Spéciale du lanceur." },
                "crocsgivre" => new List<string> { "65", "Frozen", "Dragon", "15", "Peut geler l'adversaire." },
                "dracometeore" => new List<string> { "130", "DefSpeDown", "Dragon", "5", "Inflige des dégâts et réduit la statistique de Défense Spéciale de l'utilisateur." },
                "dansedraco" => new List<string> { "--", "AtkUp", "Dragon", "20", "Augmente l'Attaque et la Vitesse de l'utilisateur." },
                "dracocharge" => new List<string> { "85", "Paralysed", "Dragon", "10", "Peut paralyser l'adversaire." },
                _ => throw new AttackNotFoundException( $"Erreur recherche attaque {name}" ),
            };
        }
    }
}
