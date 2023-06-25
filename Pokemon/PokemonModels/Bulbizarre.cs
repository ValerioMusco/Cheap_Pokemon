﻿using Pastel;
using System.Drawing;

namespace Pokemon.PokemonModels {
    public class Bulbizarre {

        public static readonly string bulbizarreBody = @"
        
        
        
        
        
        
        
                                                                                             ░░░
                                                                                          ▒▒▒▒▒▒▒
                                                    ▓▒▒▒▒   ░░░░░░░▒                  ▓▒▒▒▒▒▒▒▒▒▒▓ 
                                                   ▓▒▒▒▒▒▒▒▒▒  ░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
                                                   ▒▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓   ▒▒▒▒▒▒▒▒▓
                                                  ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒▓▒
                                                 ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ▒▒▒▒▒▒▒▒▒▒
                                                 ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒          ▓▒▒▒▒▒▒▒▒▒▒▒
                                                ▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒       ▓▒▒▒▒▒▒▒▒▒▒▒▒▒
                                                ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓  ▒▒▒▒▒▓ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
                                                ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒   ▒▒▒▒▒▒▒▒▒▒▒▒▓▒▒▒▒ ▒▒   ▒▒
                                               ▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒ ▓▓  ▒▒▒▒  ▒▒▓   ▒▒▒▒▒▒▒▒▒    ▒▒▒▓▒   ▓▓▓▒
                                               ▓▓▓▓▓▒▒▒▒▒▒▒▒ ▓▓      ▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒     ░▒▒▒▓▓▓  ▓▓▓▒▒
                                            ▒▒ ▓▓▓▓▓▒▒▒▒▒▒▓ ▓▓   ▓▓▓  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒       ▒▒▒ ▓▓░  ▓ ▒
                                          ▒▒▒▒ ▓▓▓▓▒▒▒▒▒▒▒ ▓▓▓   ▓▓▓    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒       ▒▒▒ ▓▓   ▓▓ ▒
                                       ▓▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒ ▓▓▓▓   ▓▓▓    ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▓   ▓▓ ▒
                                            ▒▒▒▒▒▒▒▒▒▒▒▒▒ ▓▓▓▓   ▓▓▓     ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ▓▓ ▒
                                            ▒▒▒▒▒▒▒▒▒▒▒▒▒ ▓▓▓▓           ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ▓ ▒▒
                                           ▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▓▓▓▓           ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓  ▒▒▒▒▒▒
                             ▓            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓  ▓▓▒         ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒
                           ▒▒▒           ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓ ▒
                         ▒▒▒▒▒▒▒▒▓     ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▓▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒
                       ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒   ▒▒▒▒▓
                     ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒                ▒▓▒▒▒▒▒▒▓
                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓ ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒
                   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓  ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓  ▒▒▒▒
                  ▒▒▒        ▒▒▒▒▒▓  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓     ▒▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓    ▓▓▒▒▒▒▒▒▒▒
                 ▒▒          ▓▒▒▒▒▒ ░▒▒▒▒▒▒▒▒▓ ▓▒▒▒▒▒▒▒▒ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒
                 ▒▒          ▒▒▒▒▒▒ ▒▒▒▒▒▒      ▒▒▒▒▒▒▒▒▓░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒
                ▓▒▒▒░       ▒▒▒▒▒▒▓ ▒▒▒▒        ▒▒▒▒▒▒▒▒▒ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▓ ▓▒
                ▒▒▒▒▒▒▒   ▒▒▒▒▒▒▒▒▒ ▒▒▒         ▒▒▒▒▒▒▒▒▒ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒    ▒▒
                ▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒        ▒▒▒▒▒▒▒▒▒ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓▓▒▒▒▒▒▒▒     ▓▒
                ░▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░ ▓▒▒▒▒       ▒▒▒▒▒▒▒▒▓ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓▓▓▒▒▒▒▒▒      ▓▒▓
                 ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓ ▓▒▒▒▒▒▓    ▓▒▒▒▒▒▒▒▒ ▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      ▓▓▓▓▓▒▒▒▒▒▒▒     ▓▒▒      
                 ▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒ ▓▓▒▒▒▒▒▒   ▒▒▒▒▒▒▒▒▒  ▓▓▓▓▓▓▓▓▓▓▒             ▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▒▒▒      
                  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▓▓▒▒▒▒▒▒▒▒▒               ▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒      
                   ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▓▓▓▓▒▒▒▒▓▒▒                 ▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒       
                    ▓▓▓  ▒▓▓  ▓▓▒▓▓   ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒    ▓ ▓▓ ▓▓                     ▓▓▓▓▓▒▒▓▓▒▒ ▓
                       ▓▓ ▓ ▓▓▒  ▓     ▓▓▓  ▓▒░ ▓▒ ▓▒▒                                  ▓▓▓▓  ▓  ▓▓▓
                                          ▓▓  ▓▓  ▓▓                                                        
        ";

        public static readonly string bulbizarreBack = @"
                                ░░░
                              ░░░░░░░
                      ░░░░▒ ░ ░░░░░░░░░░░░░
                       ░░░░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░
                       ░░░░░░░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ░░░
                     ░░░░░░░░░░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░
                     ░ ░░░░░░░░░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ░░░░▒
                     ░ ░░░░░░░░░░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ░░░░░
                    ▒ ░░░░░░░░░░░░░░▒ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ░░░░
                    ░ ░░░░░░░░░░░░░░░ ░░░░░░░░░░░░░         ░░░░░░░▒
                   ░ ░░░░░░░░░░░░░░░░░ ░░░░░░░░░░░
                  ░ ░░░░░░░░░░░░░░░░░░ ░░░░░░░░░░
                 ░ ░░░░░░░░░░░░░░░░░░░░ ░░░░░░░░░
                ░ ░░░░░░░░░░░░░░░░░░░░░ ░░░░░░░░
               ░░ ░░░░░░░░░░░░░░░░░░░░░░ ░░░░░░░
             ░░░ ░░░░░░░░░░░░░░░░░░░░░░░░ ░░░░░
             ░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░
            ░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░
           ░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
           ░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░░░
          ░░░░░ ░░░░░░░░░░░░░░░░░░░░░░░░░░
          ░░░░░  ░░░░░░░░░░░░░░░░░░░░░░░
          ░░░░░░ ░░░░░░░░░░░░░░░░░░░░░
           ░░░░░░ ░░░░░░░░░░░░░░░░░
           ░░░░░░░ ░░░░░░░░░░░░░░
            ░░░░░░░  ░░░░░░░░░
             ░░░░░░░░  ░░░░░
               ░░░░░░░░░
                 ░░░░░░░
        ";


        public static void PrintSprite() {

            Console.SetCursorPosition( 0, 15 );
            Console.WriteLine( Bulbizarre.bulbizarreBody.Pastel( Color.Cyan ));
            Console.SetCursorPosition( 0, 15 );
            Console.WriteLine( Bulbizarre.bulbizarreBack.Pastel( Color.FromArgb( 90, 255, 0 ) ) );
        }

    }

}
