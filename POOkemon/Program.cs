using POOkemon;
using POOkemon.ClasesHijas;
using POOkemon.parte2;

static void inicio()
{
    Pokemon pokemon = new Pokemon();
    pokemon.Nombre = "Squirtle";
    pokemon.Nivel = 23;
    pokemon.Region = "Kanto";
}

static void legendario()
{
    PokemonFuego pokemonfuego = new PokemonFuego(105);
    pokemonfuego.Nombre = "HO-OH";
    pokemonfuego.Nivel=10;
    pokemonfuego.Region = "Johto";
    pokemonfuego.MostrarInformacion();
}

static void electrico()
{
    PokemonElectrico pokemonelectrico = new PokemonElectrico(true,true);
    pokemonelectrico.Nombre = "Pikachu";
    pokemonelectrico.Nivel = 15;
    pokemonelectrico.Region = "Kanto";
    pokemonelectrico.MostrarInformacion();
    pokemonelectrico.MostrarGrito();
}

//-----------------------------------------EJEMPLO INDEXADORES-------------------------------------------------
static void EquipoPkmn()
{
    EquipoPokemon equipoPokemon = new EquipoPokemon();
    //listado();

    Pkmn otropoke = new Pkmn("Greninja", "Kalos");
    equipoPokemon[1] = otropoke;
    listado();

    void listado()
    {
        for (int i = 0; i < 5; i++)
        {
           equipoPokemon[i].MostrarEquipo();
        }
    }
}

static void AtaqueLegendario()
{
    PokemonFuego pokemonFuego = new PokemonFuego(86);
    pokemonFuego.Ataque += pokemonFuego.AtacarEvento;
    pokemonFuego.ComprobarAtaque();
    pokemonFuego.Ataque -= pokemonFuego.AtacarEvento;
    pokemonFuego.ComprobarAtaque();
}

legendario();
EquipoPkmn();
electrico();
AtaqueLegendario();
