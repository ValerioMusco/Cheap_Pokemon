using Pokemon.Enums;
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
        private int MaxHp { get; set; }
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

            p.TakeDamage((Atk - p.Def) < 1 ? 1 : Atk - p.Def);
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
    }
}
