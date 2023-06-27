using Pokemon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models {
    public class Attacks {

        private string? Name { get; set; }
        private int Strength { get; set; }
        public Types Type { get; set; }
        private Status Status { get; set; }
        private int Pp { get; set; }
        public int CurrentPp { get; set; }
        private string? Description { get; set; }

        public Attacks() { }

        public Attacks( string? name, int strength, Types types, Status status, int pp, string? description ) {
            Name = name;
            Strength = strength;
            Type = types;
            Status = status;
            Pp = pp;
            CurrentPp = Pp;
            Description = description;
        }

        public void GetDescription() {

            Console.WriteLine(Description);
        }


        public override string ToString() {

            StringBuilder sb = new();

            sb.AppendLine( $"{Name} | {Strength}" );
            sb.AppendLine( $"{CurrentPp} / {Pp}" );
            sb.AppendLine( $"Type : {Type} | Effect : {Status}" );

            return sb.ToString();
        }

        public string GetAttackName() {
            return Name;
        }

        public static List<Attacks> GenerateAttack(Pokemons p) {

            Random r = new();

            List<Attacks> validAttacks = new();
            List<Attacks> chosenAttacks = new();

            foreach( KeyValuePair<string, List<string>> move in AttackTable.movesDictionary ) {

                foreach(Types type in p.Types ) {

                    if( move.Value[2] == Enum.GetName( typeof( Types ), type ) ) {

                        validAttacks.Add( new Attacks( move.Key, ( move.Value[0] == "--" ) ? 0 : int.Parse( move.Value[0] ),
                            Enum.Parse<Types>(move.Value[2]), Enum.Parse<Status>( move.Value[1]),
                            int.Parse( move.Value[3] ), move.Value[4] ) );
                    }
                }
            }

            for(int i = 0; i < 4; i++ ) {

                int index = r.Next(validAttacks.Count - 1);
                chosenAttacks.Add( validAttacks[ index ]);
                validAttacks.Remove( validAttacks[ index] );
            }

            return chosenAttacks;
        }
        
    }
}
