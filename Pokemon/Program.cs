using Pokemon.Enums;
using Pokemon.Exceptions;
using Pokemon.Models;

Pokemons poke1 = PokemonTable.GeneratePokemon( "Dracolosse", 100 );
Pokemons poke2 = PokemonTable.GeneratePokemon( "Goupix", 100 );

Console.WriteLine( $"{poke1.Name} HP : {poke1.CurrentHp} / {poke1.MaxHp}" );
Console.WriteLine( $"{poke2.Name} HP : {poke2.CurrentHp} / {poke2.MaxHp}" );
Console.WriteLine();

while( poke1.CurrentHp > 0 && poke2.CurrentHp > 0 ) {

    try { poke1.Attack( poke2 ); }
    catch( CombatModifierException e ) { Console.WriteLine( e.Message ); }
    try { poke2.Attack( poke1 ); }
    catch( CombatModifierException e ) { Console.WriteLine( e.Message ); }
    Console.WriteLine();

    Console.WriteLine( $"{poke1.Name} HP : {poke1.CurrentHp} / {poke1.MaxHp}" );
    Console.WriteLine( $"{poke2.Name} HP : {poke2.CurrentHp} / {poke2.MaxHp}" );
}

if( poke1.CurrentHp > 0 )
    Console.WriteLine( $"{poke2.Name} est K.O" );
if( poke2.CurrentHp > 0 )
    Console.WriteLine( $"{poke1.Name} est K.O" );
