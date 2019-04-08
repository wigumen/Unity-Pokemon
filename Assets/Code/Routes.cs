using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Routes
{
    static public List<PokemonActor> PokemonTable(string tile)
    {
        List<PokemonActor> table = new List<PokemonActor>();

        if(tile == "Tile_main_298")
        {
            table = new List<PokemonActor>{
                new PokemonActor(129, 6, true),
                new PokemonActor(250, 6, true),
                new PokemonActor(249, 6, true),
                new PokemonActor(150, 6, true)
            };
        }

        return table;
    }

}
