using Pokemon.Enums;
using Pokemon.Models;

Pokemons poke1 = PokemonTable.GeneratePokemon( "Bulbizarre", 20 );
Pokemons poke2 = PokemonTable.GeneratePokemon( "Carapuce", 20 );

Console.WriteLine( poke1 );
Console.WriteLine( poke2 );

while( poke1.CurrentHp > 0 && poke2.CurrentHp > 0 ) {

    poke1.Attack( poke2 );
    poke2.Attack( poke1 );
}

if( poke1.CurrentHp > 0 )
    Console.WriteLine( $"{poke2.Name} est K.O" );
if( poke2.CurrentHp > 0 )
    Console.WriteLine( $"{poke1.Name} est K.O" );
