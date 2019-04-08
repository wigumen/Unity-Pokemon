﻿/*
  "Bug" 0,
  "Dragon" 1,
  "Electric" 2,
  "Fighting" 3, 
  "Fire" 4,
  "Flying" 5,
  "Ghost" 6,
  "Grass" 7,
  "Ground" 8,
  "Ice" 9,
  "Normal" 10,
  "Poison" 11,
  "Phychic" 12,
  "Rock" 13,
  "Water 14"
  "Steel" 15
  "Dark" 16
*/

public static class Pokedex
{
    public static Pokemon[] list = {
        new Pokemon("Bulbasaur",new int[] {7,11},45,49,49,65,65,45),
        new Pokemon("Ivysaur",new int[] {7,11},60,62,63,80,80,60),
        new Pokemon("Venusaur",new int[] {7,11},80,82,83,100,100,80),
        new Pokemon("Charmander",new int[] {4},39,52,43,60,50,65),
        new Pokemon("Charmeleon",new int[] {4},58,64,58,80,65,80),
        new Pokemon("Charizard",new int[] {4,5},78,84,78,109,85,100),
        new Pokemon("Squirtle",new int[] {14},44,48,65,50,64,43),
        new Pokemon("Wartortle",new int[] {14},59,63,80,65,80,58),
        new Pokemon("Blastoise",new int[] {14},79,83,100,85,105,78),
        new Pokemon("Caterpie",new int[] {0},45,30,35,20,20,45),
        new Pokemon("Metapod",new int[] {0},50,20,55,25,25,30),
        new Pokemon("Butterfree",new int[] {0,5},60,45,50,80,80,70),
        new Pokemon("Weedle",new int[] {0,11},40,35,30,20,20,50),
        new Pokemon("Kakuna",new int[] {0,11},45,25,50,25,25,35),
        new Pokemon("Beedrill",new int[] {0,11},65,80,40,45,80,75),
        new Pokemon("Pidgey",new int[] {10,5},40,45,40,35,35,56),
        new Pokemon("Pidgeotto",new int[] {10,5},63,60,55,50,50,71),
        new Pokemon("Pidgeot",new int[] {10,5},83,80,75,70,70,91),
        new Pokemon("Rattata",new int[] {10},30,56,35,25,35,72),
        new Pokemon("Raticate",new int[] {10},55,81,60,50,70,97),
        new Pokemon("Spearow",new int[] {10,5},40,60,30,31,31,70),
        new Pokemon("Fearow",new int[] {10,5},65,90,65,61,61,100),
        new Pokemon("Ekans",new int[] {11},35,60,44,40,54,55),
        new Pokemon("Arbok",new int[] {11},60,85,69,65,79,80),
        new Pokemon("Pikachu",new int[] {2},35,55,30,50,40,90),
        new Pokemon("Raichu",new int[] {2},60,90,55,90,80,100),
        new Pokemon("Sandshrew",new int[] {8},50,75,85,20,30,40),
        new Pokemon("Sandslash",new int[] {8},75,100,110,45,55,65),
        new Pokemon("Nidoranâ™€",new int[] {11},55,47,52,40,40,41),
        new Pokemon("Nidorina",new int[] {11},70,62,67,55,55,56),
        new Pokemon("Nidoqueen",new int[] {11,8},90,82,87,75,85,76),
        new Pokemon("Nidoranâ™‚",new int[] {11},46,57,40,40,40,50),
        new Pokemon("Nidorino",new int[] {11},61,72,57,55,55,65),
        new Pokemon("Nidoking",new int[] {11,8},81,92,77,85,75,85),
        new Pokemon("Clefairy",new int[] {10},70,45,48,60,65,35),
        new Pokemon("Clefable",new int[] {10},95,70,73,85,90,60),
        new Pokemon("Vulpix",new int[] {4},38,41,40,50,65,65),
        new Pokemon("Ninetales",new int[] {4},73,76,75,81,100,100),
        new Pokemon("Jigglypuff",new int[] {10},115,45,20,45,25,20),
        new Pokemon("Wigglytuff",new int[] {10},140,70,45,75,50,45),
        new Pokemon("Zubat",new int[] {11,5},40,45,35,30,40,55),
        new Pokemon("Golbat",new int[] {11,5},75,80,70,65,75,90),
        new Pokemon("Oddish",new int[] {7,11},45,50,55,75,65,30),
        new Pokemon("Gloom",new int[] {7,11},60,65,70,85,75,40),
        new Pokemon("Vileplume",new int[] {7,11},75,80,85,100,90,50),
        new Pokemon("Paras",new int[] {0,7},35,70,55,45,55,25),
        new Pokemon("Parasect",new int[] {0,7},60,95,80,60,80,30),
        new Pokemon("Venonat",new int[] {0,11},60,55,50,40,55,45),
        new Pokemon("Venomoth",new int[] {0,11},70,65,60,90,75,90),
        new Pokemon("Diglett",new int[] {8},10,55,25,35,45,95),
        new Pokemon("Dugtrio",new int[] {8},35,80,50,50,70,120),
        new Pokemon("Meowth",new int[] {10},40,45,35,40,40,90),
        new Pokemon("Persian",new int[] {10},65,70,60,65,65,115),
        new Pokemon("Psyduck",new int[] {14},50,52,48,65,50,55),
        new Pokemon("Golduck",new int[] {14},80,82,78,95,80,85),
        new Pokemon("Mankey",new int[] {3},40,80,35,35,45,70),
        new Pokemon("Primeape",new int[] {3},65,105,60,60,70,95),
        new Pokemon("Growlithe",new int[] {4},55,70,45,70,50,60),
        new Pokemon("Arcanine",new int[] {4},90,110,80,100,80,95),
        new Pokemon("Poliwag",new int[] {14},40,50,40,40,40,90),
        new Pokemon("Poliwhirl",new int[] {14},65,65,65,50,50,90),
        new Pokemon("Poliwrath",new int[] {14,3},90,85,95,70,90,70),
        new Pokemon("Abra",new int[] {12},25,20,15,105,55,90),
        new Pokemon("Kadabra",new int[] {12},40,35,30,120,70,105),
        new Pokemon("Alakazam",new int[] {12},55,50,45,135,85,120),
        new Pokemon("Machop",new int[] {3},70,80,50,35,35,35),
        new Pokemon("Machoke",new int[] {3},80,100,70,50,60,45),
        new Pokemon("Machamp",new int[] {3},90,130,80,65,85,55),
        new Pokemon("Bellsprout",new int[] {7,11},50,75,35,70,30,40),
        new Pokemon("Weepinbell",new int[] {7,11},65,90,50,85,45,55),
        new Pokemon("Victreebel",new int[] {7,11},80,105,65,100,60,70),
        new Pokemon("Tentacool",new int[] {14,11},40,40,35,50,100,70),
        new Pokemon("Tentacruel",new int[] {14,11},80,70,65,80,120,100),
        new Pokemon("Geodude",new int[] {13,8},40,80,100,30,30,20),
        new Pokemon("Graveler",new int[] {13,8},55,95,115,45,45,35),
        new Pokemon("Golem",new int[] {13,8},80,110,130,55,65,45),
        new Pokemon("Ponyta",new int[] {4},50,85,55,65,65,90),
        new Pokemon("Rapidash",new int[] {4},65,100,70,80,80,105),
        new Pokemon("Slowpoke",new int[] {14,12},90,65,65,40,40,15),
        new Pokemon("Slowbro",new int[] {14,12},95,75,110,100,80,30),
        new Pokemon("Magnemite",new int[] {2,15},25,35,70,95,55,45),
        new Pokemon("Magneton",new int[] {2,15},50,60,95,120,70,70),
        new Pokemon("Farfetchd",new int[] {10,5},52,65,55,58,62,60),
        new Pokemon("Doduo",new int[] {10,5},35,85,45,35,35,75),
        new Pokemon("Dodrio",new int[] {10,5},60,110,70,60,60,100),
        new Pokemon("Seel",new int[] {14},65,45,55,45,70,45),
        new Pokemon("Dewgong",new int[] {14,9},90,70,80,70,95,70),
        new Pokemon("Grimer",new int[] {11},80,80,50,40,50,25),
        new Pokemon("Muk",new int[] {11},105,105,75,65,100,50),
        new Pokemon("Shellder",new int[] {14},30,65,100,45,25,40),
        new Pokemon("Cloyster",new int[] {14,9},50,95,180,85,45,70),
        new Pokemon("Gastly",new int[] {6,11},30,35,30,100,35,80),
        new Pokemon("Haunter",new int[] {6,11},45,50,45,115,55,95),
        new Pokemon("Gengar",new int[] {6,11},60,65,60,130,75,110),
        new Pokemon("Onix",new int[] {13,8},35,45,160,30,45,70),
        new Pokemon("Drowzee",new int[] {12},60,48,45,43,90,42),
        new Pokemon("Hypno",new int[] {12},85,73,70,73,115,67),
        new Pokemon("Krabby",new int[] {14},30,105,90,25,25,50),
        new Pokemon("Kingler",new int[] {14},55,130,115,50,50,75),
        new Pokemon("Voltorb",new int[] {2},40,30,50,55,55,100),
        new Pokemon("Electrode",new int[] {2},60,50,70,80,80,140),
        new Pokemon("Exeggcute",new int[] {7,12},60,40,80,60,45,40),
        new Pokemon("Exeggutor",new int[] {7,12},95,95,85,125,65,55),
        new Pokemon("Cubone",new int[] {8},50,50,95,40,50,35),
        new Pokemon("Marowak",new int[] {8},60,80,110,50,80,45),
        new Pokemon("Hitmonlee",new int[] {3},50,120,53,35,110,87),
        new Pokemon("Hitmonchan",new int[] {3},50,105,79,35,110,76),
        new Pokemon("Lickitung",new int[] {10},90,55,75,60,75,30),
        new Pokemon("Koffing",new int[] {11},40,65,95,60,45,35),
        new Pokemon("Weezing",new int[] {11},65,90,120,85,70,60),
        new Pokemon("Rhyhorn",new int[] {8,13},80,85,95,30,30,25),
        new Pokemon("Rhydon",new int[] {8,13},105,130,120,45,45,40),
        new Pokemon("Chansey",new int[] {10},250,5,5,35,105,50),
        new Pokemon("Tangela",new int[] {7},65,55,115,100,40,60),
        new Pokemon("Kangaskhan",new int[] {10},105,95,80,40,80,90),
        new Pokemon("Horsea",new int[] {14},30,40,70,70,25,60),
        new Pokemon("Seadra",new int[] {14},55,65,95,95,45,85),
        new Pokemon("Goldeen",new int[] {14},45,67,60,35,50,63),
        new Pokemon("Seaking",new int[] {14},80,92,65,65,80,68),
        new Pokemon("Staryu",new int[] {14},30,45,55,70,55,85),
        new Pokemon("Starmie",new int[] {14,12},60,75,85,100,85,115),
        new Pokemon("Mr.Mime",new int[] {12},40,45,65,100,120,90),
        new Pokemon("Scyther",new int[] {0,5},70,110,80,55,80,105),
        new Pokemon("Jynx",new int[] {9,12},65,50,35,115,95,95),
        new Pokemon("Electabuzz",new int[] {2},65,83,57,95,85,105),
        new Pokemon("Magmar",new int[] {4},65,95,57,100,85,93),
        new Pokemon("Pinsir",new int[] {0},65,125,100,55,70,85),
        new Pokemon("Tauros",new int[] {10},75,100,95,40,70,110),
        new Pokemon("Magikarp",new int[] {14},20,10,55,15,20,80),
        new Pokemon("Gyarados",new int[] {14,5},95,125,79,60,100,81),
        new Pokemon("Lapras",new int[] {14,9},130,85,80,85,95,60),
        new Pokemon("Ditto",new int[] {10},48,48,48,48,48,48),
        new Pokemon("Eevee",new int[] {10},55,55,50,45,65,55),
        new Pokemon("Vaporeon",new int[] {14},130,65,60,110,95,65),
        new Pokemon("Jolteon",new int[] {2},65,65,60,110,95,130),
        new Pokemon("Flareon",new int[] {4},65,130,60,95,110,65),
        new Pokemon("Porygon",new int[] {10},65,60,70,85,75,40),
        new Pokemon("Omanyte",new int[] {13,14},35,40,100,90,55,35),
        new Pokemon("Omastar",new int[] {13,14},70,60,125,115,70,55),
        new Pokemon("Kabuto",new int[] {13,14},30,80,90,55,45,55),
        new Pokemon("Kabutops",new int[] {13,14},60,115,105,65,70,80),
        new Pokemon("Aerodactyl",new int[] {13,5},80,105,65,60,75,130),
        new Pokemon("Snorlax",new int[] {10},160,110,65,65,110,30),
        new Pokemon("Articuno",new int[] {9,5},90,85,100,95,125,85),
        new Pokemon("Zapdos",new int[] {2,5},90,90,85,125,90,100),
        new Pokemon("Moltres",new int[] {4,5},90,100,90,125,85,90),
        new Pokemon("Dratini",new int[] {1},41,64,45,50,50,50),
        new Pokemon("Dragonair",new int[] {1},61,84,65,70,70,70),
        new Pokemon("Dragonite",new int[] {1,5},91,134,95,100,100,80),
        new Pokemon("Mewtwo",new int[] {12},106,110,90,154,90,130),
        new Pokemon("Mew",new int[] {12},100,100,100,100,100,100),
        new Pokemon("Chikorita",new int[] {7},45,49,65,49,65,45),
        new Pokemon("Bayleef",new int[] {7},60,62,80,63,80,60),
        new Pokemon("Meganium",new int[] {7},80,82,100,83,100,80),
        new Pokemon("Cyndaquil",new int[] {4},39,52,43,60,50,65),
        new Pokemon("Quilava",new int[] {4},58,64,58,80,65,80),
        new Pokemon("Typhlosion",new int[] {4},78,84,78,109,85,100),
        new Pokemon("Totodile",new int[] {14},50,65,64,44,48,43),
        new Pokemon("Croconaw",new int[] {14},65,80,80,59,63,58),
        new Pokemon("Feraligatr",new int[] {14},85,105,100,79,83,78),
        new Pokemon("Sentret",new int[] {10},35,46,34,35,45,20),
        new Pokemon("Furret",new int[] {10},85,76,64,45,55,90),
        new Pokemon("Hoothoot",new int[] {10,5},60,30,30,36,56,50),
        new Pokemon("Noctowl",new int[] {10,5},100,50,50,76,96,70),
        new Pokemon("Ledyba",new int[] {0,5},40,20,30,40,80,55),
        new Pokemon("Ledian",new int[] {0,5},55,35,50,55,110,85),
        new Pokemon("Spinarak",new int[] {0,11},40,60,40,40,40,30),
        new Pokemon("Ariados",new int[] {0,11},70,90,70,60,60,40),
        new Pokemon("Crobat",new int[] {11,5},85,90,80,70,80,130),
        new Pokemon("Chinchou",new int[] {14,2},75,38,38,56,56,67),
        new Pokemon("Lanturn",new int[] {14,2},125,58,58,76,76,67),
        new Pokemon("Pichu",new int[] {2},20,40,15,35,35,60),
        new Pokemon("Cleffa",new int[] {10},50,25,28,45,55,15),
        new Pokemon("Igglybuff",new int[] {10},90,30,15,40,20,15),
        new Pokemon("Togepi",new int[] {10},35,20,65,40,65,20),
        new Pokemon("Togetic",new int[] {10,5},55,40,85,80,105,40),
        new Pokemon("Natu",new int[] {12,5},40,50,45,70,45,70),
        new Pokemon("Xatu",new int[] {12,5},65,75,70,95,70,95),
        new Pokemon("Mareep",new int[] {2},55,40,40,65,45,35),
        new Pokemon("Flaaffy",new int[] {2},70,55,55,80,60,45),
        new Pokemon("Ampharos",new int[] {2},90,75,75,115,90,55),
        new Pokemon("Bellossom",new int[] {7},75,80,85,90,100,50),
        new Pokemon("Marill",new int[] {14},70,20,50,20,50,40),
        new Pokemon("Azumarill",new int[] {14},100,50,80,50,80,50),
        new Pokemon("Sudowoodo",new int[] {13},70,100,115,30,65,30),
        new Pokemon("Politoed",new int[] {14},90,75,75,90,100,70),
        new Pokemon("Hoppip",new int[] {7,5},35,35,40,35,55,50),
        new Pokemon("Skiploom",new int[] {7,5},55,45,50,45,65,80),
        new Pokemon("Jumpluff",new int[] {7,5},75,55,70,55,85,110),
        new Pokemon("Aipom",new int[] {10},55,70,55,40,55,85),
        new Pokemon("Sunkern",new int[] {7},30,30,30,30,30,30),
        new Pokemon("Sunflora",new int[] {7},75,75,55,105,85,30),
        new Pokemon("Yanma",new int[] {0,5},65,65,45,75,45,95),
        new Pokemon("Wooper",new int[] {14,8},55,45,45,25,25,15),
        new Pokemon("Quagsire",new int[] {14,8},95,85,85,65,65,35),
        new Pokemon("Espeon",new int[] {12},65,65,60,130,95,110),
        new Pokemon("Umbreon",new int[] {16},95,65,110,60,130,65),
        new Pokemon("Murkrow",new int[] {16,5},60,85,42,85,42,91),
        new Pokemon("Slowking",new int[] {14,12},95,75,80,100,110,30),
        new Pokemon("Misdreavus",new int[] {6},60,60,60,85,85,85),
        new Pokemon("Unown",new int[] {12},48,72,48,72,48,48),
        new Pokemon("Wobbuffet",new int[] {12},190,33,58,33,58,33),
        new Pokemon("Girafarig",new int[] {10,12},70,80,65,90,65,85),
        new Pokemon("Pineco",new int[] {0},50,65,90,35,35,15),
        new Pokemon("Forretress",new int[] {0,15},75,90,140,60,60,40),
        new Pokemon("Dunsparce",new int[] {10},100,70,70,65,65,45),
        new Pokemon("Gligar",new int[] {8,5},65,75,105,35,65,85),
        new Pokemon("Steelix",new int[] {15,8},75,85,200,55,65,30),
        new Pokemon("Snubbull",new int[] {10},60,80,50,40,40,30),
        new Pokemon("Granbull",new int[] {10},90,120,75,60,60,45),
        new Pokemon("Qwilfish",new int[] {14,11},65,95,75,55,55,85),
        new Pokemon("Scizor",new int[] {0,15},70,130,100,55,80,65),
        new Pokemon("Shuckle",new int[] {0,13},20,10,230,10,230,5),
        new Pokemon("Heracross",new int[] {0,3},80,125,75,40,95,85),
        new Pokemon("Sneasel",new int[] {16,9},55,95,55,35,75,115),
        new Pokemon("Teddiursa",new int[] {10},60,80,50,50,50,40),
        new Pokemon("Ursaring",new int[] {10},90,130,75,75,75,55),
        new Pokemon("Slugma",new int[] {4},40,40,40,70,40,20),
        new Pokemon("Magcargo",new int[] {4,13},50,50,120,80,80,30),
        new Pokemon("Swinub",new int[] {9,8},50,50,40,30,30,50),
        new Pokemon("Piloswine",new int[] {9,8},100,100,80,60,60,50),
        new Pokemon("Corsola",new int[] {14,13},55,55,85,65,85,35),
        new Pokemon("Remoraid",new int[] {14},35,65,35,65,35,65),
        new Pokemon("Octillery",new int[] {14},75,105,75,105,75,45),
        new Pokemon("Delibird",new int[] {9,5},45,55,45,65,45,75),
        new Pokemon("Mantine",new int[] {14,5},65,40,70,80,140,70),
        new Pokemon("Skarmory",new int[] {15,5},65,80,140,40,70,70),
        new Pokemon("Houndour",new int[] {16,4},45,60,30,80,50,65),
        new Pokemon("Houndoom",new int[] {16,4},75,90,50,110,80,95),
        new Pokemon("Kingdra",new int[] {14,1},75,95,95,95,95,85),
        new Pokemon("Phanpy",new int[] {8},90,60,60,40,40,40),
        new Pokemon("Donphan",new int[] {8},90,120,120,60,60,50),
        new Pokemon("Porygon2",new int[] {10},85,80,90,105,95,60),
        new Pokemon("Stantler",new int[] {10},73,95,62,85,65,85),
        new Pokemon("Smeargle",new int[] {10},55,20,35,20,45,75),
        new Pokemon("Tyrogue",new int[] {3},35,35,35,35,35,35),
        new Pokemon("Hitmontop",new int[] {3},50,95,95,35,110,70),
        new Pokemon("Smoochum",new int[] {9,12},45,30,15,85,65,65),
        new Pokemon("Elekid",new int[] {2},45,63,37,65,55,95),
        new Pokemon("Magby",new int[] {4},45,75,37,70,55,83),
        new Pokemon("Miltank",new int[] {10},95,80,105,40,70,100),
        new Pokemon("Blissey",new int[] {10},255,10,10,75,135,55),
        new Pokemon("Raikou",new int[] {2},90,85,75,115,100,115),
        new Pokemon("Entei",new int[] {4},115,115,85,90,75,100),
        new Pokemon("Suicune",new int[] {14},100,75,115,90,115,85),
        new Pokemon("Larvitar",new int[] {13,8},50,64,50,45,50,41),
        new Pokemon("Pupitar",new int[] {13,8},70,84,70,65,70,51),
        new Pokemon("Tyranitar",new int[] {13,16},100,134,110,95,100,61),
        new Pokemon("Lugia",new int[] {12,5},106,90,130,90,154,110),
        new Pokemon("Ho-Oh",new int[] {4,5},106,130,90,110,154,90),
        new Pokemon("Celebi",new int[] {12,7},100,100,100,100,100,100)
    };

}
