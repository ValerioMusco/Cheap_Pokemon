using Pokemon.Enums;
using Pokemon.Exceptions;
using System.Text;

namespace Pokemon.Models {
    public class Pokemons {

        private readonly Random random = new();
        public string Name { get; set; }
        private List<Types> Types { get; set; }
        private double Size { get; set; }
        private double Weight { get; set; }
        private Natures Nature { get; set; }
        private int Level { get; set; }


        #region Stat Attributes

        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        private int Atk { get; set; }
        private int Def { get; set; }
        private int AtkSpe { get; set; }
        private int DefSpe { get; set; }
        private int Speed { get; set; }
        private int Special { get; set; }

        #endregion

        #region IV Attributes

        private int HpIV { get; set; }
        private int AtkIV { get; set; }
        private int DefIV { get; set; }
        private int AtkSpeIV { get; set; }
        private int DefSpeIV { get; set; }
        private int SpeedIV { get; set; }
        private int SpecialIV { get; set; }

        #endregion

        public Pokemons(string name, int level, Dictionary<string, int> baseStats, List<Types> types, double size, double weight) {

            GenerateIVs();
            GenerateNature();
            Level = level;
            Name = name;
            Types = types;
            Size = size;
            Weight = weight;

            MaxHp = GenereateHP( baseStats["hp"], HpIV, Level );
            CurrentHp = MaxHp;
            Atk = GenereateStat( baseStats["atk"], AtkIV, Level );
            Def = GenereateStat( baseStats["def"], DefIV, Level );
            AtkSpe = GenereateStat( baseStats["atkspe"], AtkSpeIV, Level );
            DefSpe = GenereateStat( baseStats["defspe"], DefSpeIV, Level );
            Speed = GenereateStat( baseStats["speed"], SpeedIV, Level );
            Special = GenereateStat( baseStats["special"], SpecialIV, Level );
        }

        private void GenerateIVs() {

            HpIV = random.Next( 0, 32 );
            AtkIV = random.Next( 0, 32 );
            DefIV = random.Next( 0, 32 );
            AtkSpeIV = random.Next( 0, 32 );
            DefSpeIV = random.Next( 0, 32 );
            SpeedIV = random.Next( 0, 32 );
            SpecialIV = random.Next( 0, 32 );
        }

        private static int GenereateHP(int baseHp, int iv, int level) {

            return ( ( ( ( baseHp + iv ) * 2 ) * level ) / 100 ) + 5 + 10;
        }

        private static int GenereateStat(int baseStat, int iv, int level) {

            return ( ( ( baseStat + iv ) * 2 ) * level ) / 100 + level;
        }

        private void GenerateNature() {

            Nature = (Natures)random.Next( Enum.GetNames( typeof( Natures ) ).Length );
        }

        public void Attack(Pokemons p) {
            var modifier = GetRelation( Types, p.Types ) switch {
                Relation.Weakness => 2,
                Relation.Resistance => 0.5,
                Relation.Neutral => 1,
                _ => throw new CombatModifierException( "Problème lors du calcul de faiblesse" ),
            };
            Console.WriteLine( $"{Name} utilise Charge !" );
            if( modifier == 2 )
                Console.WriteLine( "C'est super efficace !" );
            if( modifier == 0.5 )
                Console.WriteLine( "Ce n'est pas très efficace..." );

            p.TakeDamage( (int)Math.Round( ( ( ( ( ( Level * 2d / 5d + 2d ) * 50d * ( (double)Atk / (double)p.Def ) ) / 50d ) + 2d ) * modifier ) ) );
        }

        private void TakeDamage(int damage) {

            CurrentHp -= damage;
        }

        public override string ToString() {

            StringBuilder sb = new();

            sb.AppendLine( $"Statistique de {Name} lvl {Level}: " );
            sb.AppendLine( $"Hp = {CurrentHp} / {MaxHp}" );
            sb.AppendLine( $"Atk = {Atk} | AtkSpe = {AtkSpe}" );
            sb.AppendLine( $"Def = {Def} | DefSpe = {DefSpe}" );
            sb.AppendLine( $"Speed = {Speed} | Special = {Special}" );
            sb.AppendLine( $"Nature : {Enum.GetName(typeof(Natures), Nature)}" );
            sb.Append( "Type : " );
            foreach(Types type in Types )
                sb.Append( $"{Enum.GetName(typeof(Types), type)} " );
            sb.AppendLine();
            sb.AppendLine($"Size : {Size} m | Weight = {Weight} kg");

            return sb.ToString();
        }
        public static Relation GetRelation(List<Types> attacker, List<Types> defender) {

            Dictionary<Types, List<Types>> weaknesses = new()
            {
                { Enums.Types.Normal, new List<Types> { Enums.Types.Fighting } },
                { Enums.Types.Fire, new List<Types> { Enums.Types.Water, Enums.Types.Rock, Enums.Types.Dragon } },
                { Enums.Types.Water, new List<Types> { Enums.Types.Grass, Enums.Types.Electric } },
                { Enums.Types.Grass, new List<Types> { Enums.Types.Fire, Enums.Types.Bug, Enums.Types.Poison } },
                { Enums.Types.Electric, new List<Types> { Enums.Types.Water, Enums.Types.Flying } },
                { Enums.Types.Ice, new List<Types> { Enums.Types.Grass, Enums.Types.Ground, Enums.Types.Flying, Enums.Types.Dragon } },
                { Enums.Types.Fighting, new List<Types> { Enums.Types.Normal, Enums.Types.Ice, Enums.Types.Rock, Enums.Types.Steel } },
                { Enums.Types.Flying, new List<Types> { Enums.Types.Grass, Enums.Types.Fighting, Enums.Types.Bug } },
                { Enums.Types.Poison, new List<Types> { Enums.Types.Grass } },
                { Enums.Types.Ground, new List<Types> { Enums.Types.Fire, Enums.Types.Electric, Enums.Types.Poison, Enums.Types.Rock } },
                { Enums.Types.Rock, new List<Types> { Enums.Types.Fire, Enums.Types.Ice, Enums.Types.Flying, Enums.Types.Bug } },
                { Enums.Types.Bug, new List<Types> { Enums.Types.Grass, Enums.Types.Psychic } },
                { Enums.Types.Ghost, new List<Types> { Enums.Types.Ghost, Enums.Types.Psychic } },
                { Enums.Types.Steel, new List<Types> { Enums.Types.Normal, Enums.Types.Grass, Enums.Types.Fighting, Enums.Types.Bug, Enums.Types.Psychic, Enums.Types.Rock, Enums.Types.Ice, Enums.Types.Dragon, Enums.Types.Fairy } },
                { Enums.Types.Psychic, new List<Types> { Enums.Types.Fighting, Enums.Types.Poison } },
                { Enums.Types.Dragon, new List<Types> { Enums.Types.Dragon } },
                { Enums.Types.Fairy, new List<Types> { Enums.Types.Fighting, Enums.Types.Dragon } }
            };

            Dictionary<Types, List<Types>> resistances = new()
            {
                { Enums.Types.Normal, new List<Types> { } },
                { Enums.Types.Fire, new List<Types> { Enums.Types.Fire, Enums.Types.Grass, Enums.Types.Ice, Enums.Types.Bug, Enums.Types.Steel, Enums.Types.Fairy } },
                { Enums.Types.Water, new List<Types> { Enums.Types.Water, Enums.Types.Dragon, Enums.Types.Grass } },
                { Enums.Types.Grass, new List<Types> { Enums.Types.Water, Enums.Types.Electric, Enums.Types.Grass, Enums.Types.Ground } },
                { Enums.Types.Electric, new List<Types> { Enums.Types.Flying, Enums.Types.Electric } },
                { Enums.Types.Ice, new List<Types> { Enums.Types.Ice } },
                { Enums.Types.Fighting, new List<Types> { Enums.Types.Bug, Enums.Types.Rock, Enums.Types.Normal, Enums.Types.Ice } },
                { Enums.Types.Flying, new List<Types> { Enums.Types.Grass, Enums.Types.Fighting, Enums.Types.Bug } },
                { Enums.Types.Poison, new List<Types> { Enums.Types.Poison, Enums.Types.Ground, Enums.Types.Rock, Enums.Types.Bug } },
                { Enums.Types.Ground, new List<Types> { Enums.Types.Poison, Enums.Types.Rock } },
                { Enums.Types.Rock, new List<Types> { Enums.Types.Normal, Enums.Types.Flying, Enums.Types.Fire, Enums.Types.Poison } },
                { Enums.Types.Bug, new List<Types> { Enums.Types.Steel, Enums.Types.Fighting, Enums.Types.Grass, Enums.Types.Poison, Enums.Types.Psychic, Enums.Types.Flying } },
                { Enums.Types.Ghost, new List<Types> { Enums.Types.Bug, Enums.Types.Steel, Enums.Types.Ghost, Enums.Types.Poison } },
                { Enums.Types.Steel, new List<Types> { Enums.Types.Psychic, Enums.Types.Bug, Enums.Types.Poison, Enums.Types.Rock, Enums.Types.Fighting, Enums.Types.Grass, Enums.Types.Normal, Enums.Types.Flying, Enums.Types.Ground, Enums.Types.Ice, Enums.Types.Fairy } },
                { Enums.Types.Psychic, new List<Types> { Enums.Types.Fighting, Enums.Types.Poison } },
                { Enums.Types.Dragon, new List<Types> { Enums.Types.Steel } },
                { Enums.Types.Fairy, new List<Types> { Enums.Types.Fighting, Enums.Types.Dragon } }
            };

            foreach( Types attackerType in attacker ) 
                foreach( Types defenderType in defender ) 
                    if( weaknesses.ContainsKey( defenderType ) && weaknesses[defenderType].Contains( attackerType ) )
                        return Relation.Weakness;
                    else if( resistances.ContainsKey( defenderType ) && resistances[defenderType].Contains( attackerType ) ) 
                        return Relation.Resistance;
                    
            return Relation.Neutral;
        }
    }
}
