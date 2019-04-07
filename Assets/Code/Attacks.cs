/*
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

public class Attack
{
    public string Name { get; set; }
    public int Power { get; set; }
    public int Acc { get; set; }
    public int PP { get; set; }
    public int Type { get; set; }
    public int Range = 20;
    public int category { get; set; } //phycial = 0    special = 1 status = 2

    public Attack(string n, int p, int a, int pp, int type, int r, int cat)
    {
        Name = n;
        Power = p;
        Acc = a;
        PP = pp;
        Type = type;
        category = cat;
    }

    public static Attack KarateChop() { return new Attack("Karate Chop", 50, 100, 25, 3, 5, 0); }
    public static Attack DoubleSlap() { return new Attack("Double Slap", 15, 85, 10, 10, 5, 0); }
    public static Attack CometPunch() { return new Attack("Comet Punch", 18, 85, 15, 10, 5, 0); }
    public static Attack MegaPunch() { return new Attack("Mega Punch", 80, 85, 20, 10, 5, 0); }
    public static Attack PayDay() { return new Attack("Pay Day", 40, 100, 20, 10, 5, 0); }
    public static Attack FirePunch() { return new Attack("4 Punch", 75, 100, 15, 4, 5, 0); }
    public static Attack IcePunch() { return new Attack("9 Punch", 75, 100, 15, 9, 5, 0); }
    public static Attack ThunderPunch() { return new Attack("Thunder Punch", 75, 100, 15, 2, 5, 0); }
    public static Attack Scratch() { return new Attack("Scratch", 40, 100, 35, 10, 5, 0); }
    public static Attack ViceGrip() { return new Attack("Vice Grip", 55, 100, 30, 10, 5, 0); }
    public static Attack Guillotine() { return new Attack("Guillotine", 99, 99, 5, 10, 5, 0); }
    public static Attack RazorWind() { return new Attack("Razor Wind", 80, 100, 10, 10, 5, 1); }
    public static Attack SwordsDance() { return new Attack("Swords Dance", 99, 99, 20, 10, 5, 2); }
    public static Attack Cut() { return new Attack("Cut", 50, 95, 30, 10, 5, 0); }
    public static Attack Gust() { return new Attack("Gust", 40, 100, 35, 5, 5, 1); }
    public static Attack WingAttack() { return new Attack("Wing Attack", 60, 100, 35, 5, 5, 0); }
    public static Attack Whirlwind() { return new Attack("Whirlwind", 99, 99, 20, 10, 5, 2); }
    public static Attack Fly() { return new Attack("Fly", 90, 95, 15, 5, 5, 0); }
    public static Attack Bind() { return new Attack("Bind", 15, 85, 20, 10, 5, 0); }
    public static Attack Slam() { return new Attack("Slam", 80, 75, 20, 10, 5, 0); }
    public static Attack VineWhip() { return new Attack("Vine Whip", 45, 100, 25, 7, 5, 0); }
    public static Attack Stomp() { return new Attack("Stomp", 65, 100, 20, 10, 5, 0); }
    public static Attack DoubleKick() { return new Attack("Double Kick", 30, 100, 30, 3, 5, 0); }
    public static Attack MegaKick() { return new Attack("Mega Kick", 120, 75, 5, 10, 5, 0); }
    public static Attack JumpKick() { return new Attack("Jump Kick", 100, 95, 10, 3, 5, 0); }
    public static Attack RollingKick() { return new Attack("Rolling Kick", 60, 85, 15, 3, 5, 0); }
    public static Attack SandAttack() { return new Attack("Sand Attack", 99, 100, 15, 8, 5, 2); }
    public static Attack Headbutt() { return new Attack("Headbutt", 70, 100, 15, 10, 5, 0); }
    public static Attack HornAttack() { return new Attack("Horn Attack", 65, 100, 25, 10, 5, 0); }
    public static Attack FuryAttack() { return new Attack("Fury Attack", 15, 85, 20, 10, 5, 0); }
    public static Attack HornDrill() { return new Attack("Horn Drill", 99, 99, 5, 10, 5, 0); }
    public static Attack Tackle() { return new Attack("Tackle", 40, 100, 35, 10, 5, 0); }
    public static Attack BodySlam() { return new Attack("Body Slam", 85, 100, 15, 10, 5, 0); }
    public static Attack Wrap() { return new Attack("Wrap", 15, 90, 20, 10, 5, 0); }
    public static Attack TakeDown() { return new Attack("Take Down", 90, 85, 20, 10, 5, 0); }
    public static Attack Thrash() { return new Attack("Thrash", 120, 100, 10, 10, 5, 0); }
    public static Attack DoubleEdge() { return new Attack("DoubleEdge", 120, 100, 15, 10, 5, 0); }
    public static Attack TailWhip() { return new Attack("Tail Whip", 99, 100, 30, 10, 5, 2); }
    public static Attack PoisonSting() { return new Attack("11 Sting", 15, 100, 35, 11, 5, 0); }
    public static Attack Twineedle() { return new Attack("Twineedle", 25, 100, 20, 0, 5, 0); }
    public static Attack PinMissile() { return new Attack("Pin Missile", 25, 95, 20, 0, 5, 0); }
    public static Attack Leer() { return new Attack("Leer", 99, 100, 30, 10, 5, 2); }
    public static Attack Bite() { return new Attack("Bite", 60, 100, 25, 16, 5, 0); }
    public static Attack Growl() { return new Attack("Growl", 99, 100, 40, 10, 5, 2); }
    public static Attack Roar() { return new Attack("Roar", 99, 99, 20, 10, 5, 2); }
    public static Attack Sing() { return new Attack("Sing", 99, 55, 15, 10, 5, 2); }
    public static Attack Supersonic() { return new Attack("Supersonic", 99, 55, 20, 10, 5, 2); }
    public static Attack SonicBoom() { return new Attack("Sonic Boom", 99, 90, 20, 10, 5, 1); }
    public static Attack Disable() { return new Attack("Disable", 99, 100, 20, 10, 5, 2); }
    public static Attack Acid() { return new Attack("Acid", 40, 100, 30, 11, 5, 1); }
    public static Attack Ember() { return new Attack("Ember", 40, 100, 25, 4, 5, 1); }
    public static Attack Flamethrower() { return new Attack("Flamethrower", 90, 100, 15, 4, 5, 1); }
    public static Attack Mist() { return new Attack("Mist", 99, 99, 30, 9, 5, 2); }
    public static Attack WaterGun() { return new Attack("14 Gun", 40, 100, 25, 14, 5, 1); }
    public static Attack HydroPump() { return new Attack("Hydro Pump", 110, 80, 5, 14, 5, 1); }
    public static Attack Surf() { return new Attack("Surf", 90, 100, 15, 14, 5, 1); }
    public static Attack IceBeam() { return new Attack("9 Beam", 90, 100, 10, 9, 5, 1); }
    public static Attack Blizzard() { return new Attack("Blizzard", 110, 70, 5, 9, 5, 1); }
    public static Attack Psybeam() { return new Attack("Psybeam", 65, 100, 20, 12, 5, 1); }
    public static Attack BubbleBeam() { return new Attack("Bubble Beam", 65, 100, 20, 14, 5, 1); }
    public static Attack AuroraBeam() { return new Attack("Aurora Beam", 65, 100, 20, 9, 5, 1); }
    public static Attack HyperBeam() { return new Attack("Hyper Beam", 150, 90, 5, 10, 5, 1); }
    public static Attack Peck() { return new Attack("Peck", 35, 100, 35, 5, 5, 0); }
    public static Attack DrillPeck() { return new Attack("Drill Peck", 80, 100, 20, 5, 5, 0); }
    public static Attack Submission() { return new Attack("Submission", 80, 80, 20, 3, 5, 0); }
    public static Attack LowKick() { return new Attack("Low Kick", 99, 100, 20, 3, 5, 0); }
    public static Attack Counter() { return new Attack("Counter", 99, 100, 20, 3, 5, 0); }
    public static Attack SeismicToss() { return new Attack("Seismic Toss", 99, 100, 20, 3, 5, 0); }
    public static Attack Strength() { return new Attack("Strength", 80, 100, 15, 10, 5, 0); }
    public static Attack Absorb() { return new Attack("Absorb", 40, 100, 15, 7, 5, 1); }
    public static Attack MegaDrain() { return new Attack("Mega Drain", 75, 100, 10, 7, 5, 1); }
    public static Attack LeechSeed() { return new Attack("Leech Seed", 99, 90, 10, 7, 5, 2); }
    public static Attack Growth() { return new Attack("Growth", 99, 99, 20, 10, 5, 2); }
    public static Attack RazorLeaf() { return new Attack("Razor Leaf", 55, 95, 25, 7, 5, 0); }
    public static Attack SolarBeam() { return new Attack("Solar Beam", 200, 100, 10, 7, 5, 1); }
    public static Attack PoisonPowder() { return new Attack("11 Powder", 99, 75, 35, 11, 5, 2); }
    public static Attack StunSpore() { return new Attack("Stun Spore", 99, 75, 30, 7, 5, 2); }
    public static Attack SleepPowder() { return new Attack("Sleep Powder", 99, 75, 15, 7, 5, 2); }
    public static Attack PetalDance() { return new Attack("Petal Dance", 120, 100, 10, 7, 5, 1); }
    public static Attack StringShot() { return new Attack("String Shot", 99, 95, 40, 0, 5, 2); }
    public static Attack DragonRage() { return new Attack("1 Rage", 99, 100, 10, 1, 5, 1); }
    public static Attack FireSpin() { return new Attack("4 Spin", 35, 85, 15, 4, 5, 1); }
    public static Attack ThunderShock() { return new Attack("Thunder Shock", 40, 100, 30, 2, 5, 1); }
    public static Attack Thunderbolt() { return new Attack("Thunderbolt", 90, 100, 15, 2, 5, 1); }
    public static Attack ThunderWave() { return new Attack("Thunder Wave", 99, 90, 20, 2, 5, 2); }
    public static Attack Thunder() { return new Attack("Thunder", 110, 70, 10, 2, 5, 1); }
    public static Attack RockThrow() { return new Attack("13 Throw", 50, 90, 15, 13, 5, 0); }
    public static Attack Earthquake() { return new Attack("Earthquake", 100, 100, 10, 8, 5, 0); }
    public static Attack Fissure() { return new Attack("Fissure", 99, 99, 5, 8, 5, 0); }
    public static Attack Dig() { return new Attack("Dig", 80, 100, 10, 8, 5, 0); }
    public static Attack Toxic() { return new Attack("Toxic", 99, 90, 10, 11, 5, 2); }
    public static Attack Confusion() { return new Attack("Confusion", 50, 100, 25, 12, 5, 1); }
    public static Attack Phychic() { return new Attack("Phychic", 90, 100, 10, 12, 5, 1); }
    public static Attack Hypnosis() { return new Attack("Hypnosis", 99, 60, 20, 12, 5, 2); }
    public static Attack Meditate() { return new Attack("Meditate", 99, 99, 40, 12, 5, 2); }
    public static Attack Agility() { return new Attack("Agility", 99, 99, 30, 12, 5, 2); }
    public static Attack QuickAttack() { return new Attack("Quick Attack", 40, 100, 30, 10, 5, 0); }
    public static Attack Rage() { return new Attack("Rage", 20, 100, 20, 10, 5, 0); }
    public static Attack Teleport() { return new Attack("Teleport", 99, 99, 20, 12, 5, 2); }
    public static Attack NightShade() { return new Attack("Night Shade", 99, 100, 15, 6, 5, 1); }
    public static Attack Mimic() { return new Attack("Mimic", 99, 99, 10, 10, 5, 2); }
    public static Attack Screech() { return new Attack("Screech", 99, 85, 40, 10, 5, 2); }
    public static Attack DoubleTeam() { return new Attack("Double Team", 99, 99, 15, 10, 5, 2); }
    public static Attack Recover() { return new Attack("Recover", 99, 99, 10, 10, 5, 2); }
    public static Attack Harden() { return new Attack("Harden", 99, 99, 30, 10, 5, 2); }
    public static Attack Minimize() { return new Attack("Minimize", 99, 99, 10, 10, 5, 2); }
    public static Attack Smokescreen() { return new Attack("Smokescreen", 99, 100, 20, 10, 5, 2); }
    public static Attack ConfuseRay() { return new Attack("Confuse Ray", 99, 100, 10, 6, 5, 2); }
    public static Attack Withdraw() { return new Attack("Withdraw", 99, 99, 40, 14, 5, 2); }
    public static Attack DefenseCurl() { return new Attack("Defense Curl", 99, 99, 40, 10, 5, 2); }
    public static Attack Barrier() { return new Attack("Barrier", 99, 99, 20, 12, 5, 2); }
    public static Attack LightScreen() { return new Attack("Light Screen", 99, 99, 30, 12, 5, 2); }
    public static Attack Haze() { return new Attack("Haze", 99, 99, 30, 9, 5, 2); }
    public static Attack Reflect() { return new Attack("Reflect", 99, 99, 20, 12, 5, 2); }
    public static Attack FocusEnergy() { return new Attack("Focus Energy", 99, 99, 30, 10, 5, 2); }
    public static Attack Bide() { return new Attack("Bide", 99, 99, 10, 10, 5, 0); }
    public static Attack Metronome() { return new Attack("Metronome", 99, 99, 10, 10, 5, 2); }
    public static Attack MirrorMove() { return new Attack("Mirror Move", 99, 99, 20, 5, 5, 2); }
    public static Attack SelfDestruct() { return new Attack("SelfDestruct", 200, 100, 5, 10, 5, 0); }
    public static Attack EggBomb() { return new Attack("Egg Bomb", 100, 75, 10, 10, 5, 0); }
    public static Attack Lick() { return new Attack("Lick", 30, 100, 30, 6, 5, 0); }
    public static Attack Smog() { return new Attack("Smog", 30, 70, 20, 11, 5, 1); }
    public static Attack Sludge() { return new Attack("Sludge", 65, 100, 20, 11, 5, 1); }
    public static Attack BoneClub() { return new Attack("Bone Club", 65, 85, 20, 8, 5, 0); }
    public static Attack FireBlast() { return new Attack("4 Blast", 110, 85, 5, 4, 5, 1); }
    public static Attack Waterfall() { return new Attack("Waterfall", 80, 100, 15, 14, 5, 0); }
    public static Attack Clamp() { return new Attack("Clamp", 35, 85, 15, 14, 5, 0); }
    public static Attack Swift() { return new Attack("Swift", 60, 99, 20, 10, 5, 1); }
    public static Attack SkullBash() { return new Attack("Skull Bash", 130, 100, 10, 10, 5, 0); }
    public static Attack SpikeCannon() { return new Attack("Spike Cannon", 20, 100, 15, 10, 5, 0); }
    public static Attack Constrict() { return new Attack("Constrict", 10, 100, 35, 10, 5, 0); }
    public static Attack Amnesia() { return new Attack("Amnesia", 99, 99, 20, 12, 5, 2); }
    public static Attack Kinesis() { return new Attack("Kinesis", 99, 80, 15, 12, 5, 2); }
    public static Attack SoftBoiled() { return new Attack("SoftBoiled", 99, 99, 10, 10, 5, 2); }
    public static Attack HighJumpKick() { return new Attack("High Jump Kick", 130, 90, 10, 3, 5, 0); }
    public static Attack Glare() { return new Attack("Glare", 99, 100, 30, 10, 5, 2); }
    public static Attack DreamEater() { return new Attack("Dream Eater", 100, 100, 15, 12, 5, 1); }
    public static Attack PoisonGas() { return new Attack("11 Gas", 99, 90, 40, 11, 5, 2); }
    public static Attack Barrage() { return new Attack("Barrage", 15, 85, 20, 10, 5, 0); }
    public static Attack LeechLife() { return new Attack("Leech Life", 80, 100, 10, 0, 5, 0); }
    public static Attack LovelyKiss() { return new Attack("Lovely Kiss", 99, 75, 10, 10, 5, 2); }
    public static Attack SkyAttack() { return new Attack("Sky Attack", 200, 90, 5, 5, 5, 0); }
    public static Attack Transform() { return new Attack("Transform", 99, 99, 10, 10, 5, 2); }
    public static Attack Bubble() { return new Attack("Bubble", 40, 100, 30, 14, 5, 1); }
    public static Attack DizzyPunch() { return new Attack("Dizzy Punch", 70, 100, 10, 10, 5, 0); }
    public static Attack Spore() { return new Attack("Spore", 99, 100, 15, 7, 5, 2); }
    public static Attack Flash() { return new Attack("Flash", 99, 100, 20, 10, 5, 2); }
    public static Attack Psywave() { return new Attack("Psywave", 99, 100, 15, 12, 5, 1); }
    public static Attack Splash() { return new Attack("Splash", 99, 99, 40, 10, 5, 2); }
    public static Attack AcidArmor() { return new Attack("Acid Armor", 99, 99, 20, 11, 5, 2); }
    public static Attack Crabhammer() { return new Attack("Crabhammer", 100, 90, 10, 14, 5, 0); }
    public static Attack Explosion() { return new Attack("Explosion", 250, 100, 5, 10, 5, 0); }
    public static Attack FurySwipes() { return new Attack("Fury Swipes", 18, 80, 15, 10, 5, 0); }
    public static Attack Bonemerang() { return new Attack("Bonemerang", 50, 90, 10, 8, 5, 0); }
    public static Attack Rest() { return new Attack("Rest", 99, 99, 10, 12, 5, 2); }
    public static Attack RockSlide() { return new Attack("13 Slide", 75, 90, 10, 13, 5, 0); }
    public static Attack HyperFang() { return new Attack("Hyper Fang", 80, 90, 15, 10, 5, 0); }
    public static Attack Sharpen() { return new Attack("Sharpen", 99, 99, 30, 10, 5, 2); }
    public static Attack Conversion() { return new Attack("Conversion", 99, 99, 30, 10, 5, 2); }
    public static Attack TriAttack() { return new Attack("Tri Attack", 80, 100, 10, 10, 5, 1); }
    public static Attack SuperFang() { return new Attack("Super Fang", 99, 90, 10, 10, 5, 0); }
    public static Attack Slash() { return new Attack("Slash", 70, 100, 20, 10, 5, 0); }
    public static Attack Substitute() { return new Attack("Substitute", 99, 99, 10, 10, 5, 2); }
    public static Attack Struggle() { return new Attack("Struggle", 50, 99, 1, 10, 5, 0); }
    public static Attack Sketch() { return new Attack("Sketch", 99, 99, 1, 10, 5, 2); }
    public static Attack TripleKick() { return new Attack("Triple Kick", 10, 90, 10, 3, 5, 0); }
    public static Attack Thief() { return new Attack("Thief", 60, 100, 25, 16, 5, 0); }
    public static Attack SpiderWeb() { return new Attack("Spider Web", 99, 99, 10, 0, 5, 2); }
    public static Attack MindReader() { return new Attack("Mind Reader", 99, 99, 5, 10, 5, 2); }
    public static Attack Nightmare() { return new Attack("Nightmare", 99, 100, 15, 6, 5, 2); }
    public static Attack FlameWheel() { return new Attack("Flame Wheel", 60, 100, 25, 4, 5, 0); }
    public static Attack Snore() { return new Attack("Snore", 50, 100, 15, 10, 5, 1); }
    public static Attack Curse() { return new Attack("Curse", 99, 99, 10, 6, 5, 2); }
    public static Attack Flail() { return new Attack("Flail", 99, 100, 15, 10, 5, 0); }
    public static Attack Conversion2() { return new Attack("Conversion 2", 99, 99, 30, 10, 5, 2); }
    public static Attack Aeroblast() { return new Attack("Aeroblast", 100, 95, 5, 5, 5, 1); }
    public static Attack CottonSpore() { return new Attack("Cotton Spore", 99, 100, 40, 7, 5, 2); }
    public static Attack Reversal() { return new Attack("Reversal", 99, 100, 15, 3, 5, 0); }
    public static Attack Spite() { return new Attack("Spite", 99, 100, 10, 6, 5, 2); }
    public static Attack PowderSnow() { return new Attack("Powder Snow", 40, 100, 25, 9, 5, 1); }
    public static Attack Protect() { return new Attack("Protect", 99, 99, 10, 10, 5, 2); }
    public static Attack MachPunch() { return new Attack("Mach Punch", 40, 100, 30, 3, 5, 0); }
    public static Attack ScaryFace() { return new Attack("Scary Face", 99, 100, 10, 10, 5, 2); }
    public static Attack FeintAttack() { return new Attack("Feint Attack", 60, 99, 20, 16, 5, 0); }
    public static Attack SweetKiss() { return new Attack("Sweet Kiss", 99, 75, 10, 10, 5, 2); }
    public static Attack BellyDrum() { return new Attack("Belly Drum", 99, 99, 10, 10, 5, 2); }
    public static Attack SludgeBomb() { return new Attack("Sludge Bomb", 90, 100, 10, 11, 5, 1); }
    public static Attack MudSlap() { return new Attack("MudSlap", 20, 100, 10, 8, 5, 1); }
    public static Attack Octazooka() { return new Attack("Octazooka", 65, 85, 10, 14, 5, 1); }
    public static Attack Spikes() { return new Attack("Spikes", 99, 99, 20, 8, 5, 2); }
    public static Attack ZapCannon() { return new Attack("Zap Cannon", 120, 50, 5, 2, 5, 1); }
    public static Attack Foresight() { return new Attack("Foresight", 99, 99, 40, 10, 5, 2); }
    public static Attack DestinyBond() { return new Attack("Destiny Bond", 99, 99, 5, 6, 5, 2); }
    public static Attack PerishSong() { return new Attack("Perish Song", 99, 99, 5, 10, 5, 2); }
    public static Attack IcyWind() { return new Attack("Icy Wind", 55, 95, 15, 9, 5, 1); }
    public static Attack Detect() { return new Attack("Detect", 99, 99, 5, 3, 5, 2); }
    public static Attack BoneRush() { return new Attack("Bone Rush", 25, 90, 10, 8, 5, 0); }
    public static Attack LockOn() { return new Attack("LockOn", 99, 99, 5, 10, 5, 2); }
    public static Attack Outrage() { return new Attack("Outrage", 120, 100, 10, 1, 5, 0); }
    public static Attack Sandstorm() { return new Attack("Sandstorm", 99, 99, 10, 13, 5, 2); }
    public static Attack GigaDrain() { return new Attack("Giga Drain", 75, 100, 10, 7, 5, 1); }
    public static Attack Endure() { return new Attack("Endure", 99, 99, 10, 10, 5, 2); }
    public static Attack Charm() { return new Attack("Charm", 99, 100, 20, 10, 5, 2); }
    public static Attack Rollout() { return new Attack("Rollout", 30, 90, 20, 13, 5, 0); }
    public static Attack FalseSwipe() { return new Attack("False Swipe", 40, 100, 40, 10, 5, 0); }
    public static Attack Swagger() { return new Attack("Swagger", 99, 85, 15, 10, 5, 2); }
    public static Attack MilkDrink() { return new Attack("Milk Drink", 99, 99, 10, 10, 5, 2); }
    public static Attack Spark() { return new Attack("Spark", 65, 100, 20, 2, 5, 0); }
    public static Attack FuryCutter() { return new Attack("Fury Cutter", 40, 95, 20, 0, 5, 0); }
    public static Attack SteelWing() { return new Attack("15 Wing", 70, 90, 25, 15, 5, 0); }
    public static Attack MeanLook() { return new Attack("Mean Look", 99, 99, 5, 10, 5, 2); }
    public static Attack Attract() { return new Attack("Attract", 99, 100, 15, 10, 5, 2); }
    public static Attack SleepTalk() { return new Attack("Sleep Talk", 99, 99, 10, 10, 5, 2); }
    public static Attack HealBell() { return new Attack("Heal Bell", 99, 99, 5, 10, 5, 2); }
    public static Attack Return() { return new Attack("Return", 99, 100, 20, 10, 5, 0); }
    public static Attack Present() { return new Attack("Present", 99, 90, 15, 10, 5, 0); }
    public static Attack Frustration() { return new Attack("Frustration", 99, 100, 20, 10, 5, 0); }
    public static Attack Safeguard() { return new Attack("Safeguard", 99, 99, 25, 10, 5, 2); }
    public static Attack PainSplit() { return new Attack("Pain Split", 99, 99, 20, 10, 5, 2); }
    public static Attack SacredFire() { return new Attack("Sacred 4", 100, 95, 5, 4, 5, 0); }
    public static Attack Magnitude() { return new Attack("Magnitude", 99, 100, 30, 8, 5, 0); }
    public static Attack DynamicPunch() { return new Attack("Dynamic Punch", 100, 50, 5, 3, 5, 0); }
    public static Attack Megahorn() { return new Attack("Megahorn", 120, 85, 10, 0, 5, 0); }
    public static Attack DragonBreath() { return new Attack("1 Breath", 60, 100, 20, 1, 5, 1); }
    public static Attack BatonPass() { return new Attack("Baton Pass", 99, 99, 40, 10, 5, 2); }
    public static Attack Encore() { return new Attack("Encore", 99, 100, 5, 10, 5, 2); }
    public static Attack Pursuit() { return new Attack("Pursuit", 40, 100, 20, 16, 5, 0); }
    public static Attack RapidSpin() { return new Attack("Rapid Spin", 20, 100, 40, 10, 5, 0); }
    public static Attack SweetScent() { return new Attack("Sweet Scent", 99, 100, 20, 10, 5, 2); }
    public static Attack IronTail() { return new Attack("Iron Tail", 100, 75, 15, 15, 5, 0); }
    public static Attack MetalClaw() { return new Attack("Metal Claw", 50, 95, 35, 15, 5, 0); }
    public static Attack VitalThrow() { return new Attack("Vital Throw", 70, 99, 10, 3, 5, 0); }
    public static Attack MorningSun() { return new Attack("Morning Sun", 99, 99, 5, 10, 5, 2); }
    public static Attack Synthesis() { return new Attack("Synthesis", 99, 99, 5, 7, 5, 2); }
    public static Attack Moonlight() { return new Attack("Moonlight", 99, 99, 5, 10, 5, 2); }
    public static Attack HiddenPower() { return new Attack("Hidden Power", 60, 100, 15, 10, 5, 1); }
    public static Attack CrossChop() { return new Attack("Cross Chop", 100, 80, 5, 3, 5, 0); }
    public static Attack Twister() { return new Attack("Twister", 40, 100, 20, 1, 5, 1); }
    public static Attack RainDance() { return new Attack("Rain Dance", 99, 99, 5, 14, 5, 2); }
    public static Attack SunnyDay() { return new Attack("Sunny Day", 99, 99, 5, 4, 5, 2); }
    public static Attack Crunch() { return new Attack("Crunch", 80, 100, 15, 16, 5, 0); }
    public static Attack MirrorCoat() { return new Attack("Mirror Coat", 99, 100, 20, 12, 5, 1); }
    public static Attack PsychUp() { return new Attack("Psych Up", 99, 99, 10, 10, 5, 2); }
    public static Attack ExtremeSpeed() { return new Attack("Extreme Speed", 80, 100, 5, 10, 5, 0); }
    public static Attack AncientPower() { return new Attack("Ancient Power", 60, 100, 5, 13, 5, 1); }
    public static Attack ShadowBall() { return new Attack("Shadow Ball", 80, 100, 15, 6, 5, 1); }
    public static Attack FutureSight() { return new Attack("Future Sight", 120, 100, 10, 12, 5, 1); }
    public static Attack RockSmash() { return new Attack("13 Smash", 40, 100, 15, 3, 5, 0); }
    public static Attack Whirlpool() { return new Attack("Whirlpool", 35, 85, 15, 14, 5, 1); }
    public static Attack BeatUp() { return new Attack("Beat Up", 99, 100, 10, 16, 5, 0); }
    public static Attack FakeOut() { return new Attack("Fake Out", 40, 100, 10, 10, 5, 0); }
    public static Attack Uproar() { return new Attack("Uproar", 90, 100, 10, 10, 5, 1); }
    public static Attack Stockpile() { return new Attack("Stockpile", 99, 99, 20, 10, 5, 2); }
    public static Attack SpitUp() { return new Attack("Spit Up", 99, 100, 10, 10, 5, 1); }
    public static Attack Swallow() { return new Attack("Swallow", 99, 99, 10, 10, 5, 2); }
    public static Attack HeatWave() { return new Attack("Heat Wave", 95, 90, 10, 4, 5, 1); }
    public static Attack Hail() { return new Attack("Hail", 99, 99, 10, 9, 5, 2); }
    public static Attack Torment() { return new Attack("Torment", 99, 100, 15, 16, 5, 2); }
    public static Attack Flatter() { return new Attack("Flatter", 99, 100, 15, 16, 5, 2); }
    public static Attack WillOWisp() { return new Attack("WillOWisp", 99, 85, 15, 4, 5, 2); }
    public static Attack Memento() { return new Attack("Memento", 99, 100, 10, 16, 5, 2); }
    public static Attack Facade() { return new Attack("Facade", 70, 100, 20, 10, 5, 0); }
    public static Attack FocusPunch() { return new Attack("Focus Punch", 150, 100, 20, 3, 5, 0); }
    public static Attack SmellingSalts() { return new Attack("Smelling Salts", 70, 100, 10, 10, 5, 0); }
    public static Attack FollowMe() { return new Attack("Follow Me", 99, 99, 20, 10, 5, 2); }
    public static Attack NaturePower() { return new Attack("Nature Power", 99, 99, 20, 10, 5, 2); }
    public static Attack Charge() { return new Attack("Charge", 99, 99, 20, 2, 5, 2); }
    public static Attack Taunt() { return new Attack("Taunt", 99, 100, 20, 16, 5, 2); }
    public static Attack HelpingHand() { return new Attack("Helping Hand", 99, 99, 20, 10, 5, 2); }
    public static Attack Trick() { return new Attack("Trick", 99, 100, 10, 12, 5, 2); }
    public static Attack RolePlay() { return new Attack("Role Play", 99, 99, 10, 12, 5, 2); }
    public static Attack Wish() { return new Attack("Wish", 99, 99, 10, 10, 5, 2); }
    public static Attack Assist() { return new Attack("Assist", 99, 99, 20, 10, 5, 2); }
    public static Attack Ingrain() { return new Attack("Ingrain", 99, 99, 20, 7, 5, 2); }
    public static Attack Superpower() { return new Attack("Superpower", 120, 100, 5, 3, 5, 0); }
    public static Attack MagicCoat() { return new Attack("Magic Coat", 99, 99, 15, 12, 5, 2); }
    public static Attack Recycle() { return new Attack("Recycle", 99, 99, 10, 10, 5, 2); }
    public static Attack Revenge() { return new Attack("Revenge", 60, 100, 10, 3, 5, 0); }
    public static Attack BrickBreak() { return new Attack("Brick Break", 75, 100, 15, 3, 5, 0); }
    public static Attack Yawn() { return new Attack("Yawn", 99, 99, 10, 10, 5, 2); }
    public static Attack KnockOff() { return new Attack("Knock Off", 65, 100, 20, 16, 5, 0); }
    public static Attack Endeavor() { return new Attack("Endeavor", 99, 100, 5, 10, 5, 0); }
    public static Attack Eruption() { return new Attack("Eruption", 150, 100, 5, 4, 5, 1); }
    public static Attack SkillSwap() { return new Attack("Skill Swap", 99, 99, 10, 12, 5, 2); }
    public static Attack Imprison() { return new Attack("Imprison", 99, 99, 10, 12, 5, 2); }
    public static Attack Refresh() { return new Attack("Refresh", 99, 99, 20, 10, 5, 2); }
    public static Attack Grudge() { return new Attack("Grudge", 99, 99, 5, 6, 5, 2); }
    public static Attack Snatch() { return new Attack("Snatch", 99, 99, 10, 16, 5, 2); }
    public static Attack SecretPower() { return new Attack("Secret Power", 70, 100, 20, 10, 5, 0); }
    public static Attack Dive() { return new Attack("Dive", 80, 100, 10, 14, 5, 0); }
    public static Attack ArmThrust() { return new Attack("Arm Thrust", 15, 100, 20, 3, 5, 0); }
    public static Attack Camouflage() { return new Attack("Camouflage", 99, 99, 20, 10, 5, 2); }
    public static Attack TailGlow() { return new Attack("Tail Glow", 99, 99, 20, 0, 5, 2); }
    public static Attack LusterPurge() { return new Attack("Luster Purge", 70, 100, 5, 12, 5, 1); }
    public static Attack MistBall() { return new Attack("Mist Ball", 70, 100, 5, 12, 5, 1); }
    public static Attack FeatherDance() { return new Attack("Feather Dance", 99, 100, 15, 5, 5, 2); }
    public static Attack TeeterDance() { return new Attack("Teeter Dance", 99, 100, 20, 10, 5, 2); }
    public static Attack BlazeKick() { return new Attack("Blaze Kick", 85, 90, 10, 4, 5, 0); }
    public static Attack MudSport() { return new Attack("Mud Sport", 99, 99, 15, 8, 5, 2); }
    public static Attack IceBall() { return new Attack("9 Ball", 30, 90, 20, 9, 5, 0); }
    public static Attack NeedleArm() { return new Attack("Needle Arm", 60, 100, 15, 7, 5, 0); }
    public static Attack SlackOff() { return new Attack("Slack Off", 99, 99, 10, 10, 5, 2); }
    public static Attack HyperVoice() { return new Attack("Hyper Voice", 90, 100, 10, 10, 5, 1); }
    public static Attack PoisonFang() { return new Attack("11 Fang", 50, 100, 15, 11, 5, 0); }
    public static Attack CrushClaw() { return new Attack("Crush Claw", 75, 95, 10, 10, 5, 0); }
    public static Attack BlastBurn() { return new Attack("Blast Burn", 150, 90, 5, 4, 5, 1); }
    public static Attack HydroCannon() { return new Attack("Hydro Cannon", 150, 90, 5, 14, 5, 1); }
    public static Attack MeteorMash() { return new Attack("Meteor Mash", 90, 90, 10, 15, 5, 0); }
    public static Attack Astonish() { return new Attack("Astonish", 30, 100, 15, 6, 5, 0); }
    public static Attack WeatherBall() { return new Attack("Weather Ball", 50, 100, 10, 10, 5, 1); }
    public static Attack Aromatherapy() { return new Attack("Aromatherapy", 99, 99, 5, 7, 5, 2); }
    public static Attack FakeTears() { return new Attack("Fake Tears", 99, 100, 20, 16, 5, 2); }
    public static Attack AirCutter() { return new Attack("Air Cutter", 60, 95, 25, 5, 5, 1); }
    public static Attack Overheat() { return new Attack("Overheat", 130, 90, 5, 4, 5, 1); }
    public static Attack OdorSleuth() { return new Attack("Odor Sleuth", 99, 99, 40, 10, 5, 2); }
    public static Attack RockTomb() { return new Attack("13 Tomb", 60, 95, 15, 13, 5, 0); }
    public static Attack SilverWind() { return new Attack("Silver Wind", 60, 100, 5, 0, 5, 1); }
    public static Attack MetalSound() { return new Attack("Metal Sound", 99, 85, 40, 15, 5, 2); }
    public static Attack GrassWhistle() { return new Attack("7 Whistle", 99, 55, 15, 7, 5, 2); }
    public static Attack Tickle() { return new Attack("Tickle", 99, 100, 20, 10, 5, 2); }
    public static Attack CosmicPower() { return new Attack("Cosmic Power", 99, 99, 20, 12, 5, 2); }
    public static Attack WaterSpout() { return new Attack("14 Spout", 150, 100, 5, 14, 5, 1); }
    public static Attack SignalBeam() { return new Attack("Signal Beam", 75, 100, 15, 0, 5, 1); }
    public static Attack ShadowPunch() { return new Attack("Shadow Punch", 60, 99, 20, 6, 5, 0); }
    public static Attack Extrasensory() { return new Attack("Extrasensory", 80, 100, 20, 12, 5, 1); }
    public static Attack SkyUppercut() { return new Attack("Sky Uppercut", 85, 90, 15, 3, 5, 0); }
    public static Attack SandTomb() { return new Attack("Sand Tomb", 35, 85, 15, 8, 5, 0); }
    public static Attack SheerCold() { return new Attack("Sheer Cold", 99, 99, 5, 9, 5, 1); }
    public static Attack MuddyWater() { return new Attack("Muddy 14", 90, 85, 10, 14, 5, 1); }
    public static Attack BulletSeed() { return new Attack("Bullet Seed", 25, 100, 30, 7, 5, 0); }
    public static Attack AerialAce() { return new Attack("Aerial Ace", 60, 99, 20, 5, 5, 0); }
    public static Attack IcicleSpear() { return new Attack("Icicle Spear", 25, 100, 30, 9, 5, 0); }
    public static Attack IronDefense() { return new Attack("Iron Defense", 99, 99, 15, 15, 5, 2); }
    public static Attack Block() { return new Attack("Block", 99, 99, 5, 10, 5, 2); }
    public static Attack Howl() { return new Attack("Howl", 99, 99, 40, 10, 5, 2); }
    public static Attack DragonClaw() { return new Attack("1 Claw", 80, 100, 15, 1, 5, 0); }
    public static Attack FrenzyPlant() { return new Attack("Frenzy Plant", 150, 90, 5, 7, 5, 1); }
    public static Attack BulkUp() { return new Attack("Bulk Up", 99, 99, 20, 3, 5, 2); }
    public static Attack Bounce() { return new Attack("Bounce", 85, 85, 5, 5, 5, 0); }
    public static Attack MudShot() { return new Attack("Mud Shot", 55, 95, 15, 8, 5, 1); }
    public static Attack PoisonTail() { return new Attack("11 Tail", 50, 100, 25, 11, 5, 0); }
    public static Attack Covet() { return new Attack("Covet", 60, 100, 25, 10, 5, 0); }
    public static Attack VoltTackle() { return new Attack("Volt Tackle", 120, 100, 15, 2, 5, 0); }
    public static Attack MagicalLeaf() { return new Attack("Magical Leaf", 60, 99, 20, 7, 5, 1); }
    public static Attack WaterSport() { return new Attack("14 Sport", 99, 99, 15, 14, 5, 2); }
    public static Attack CalmMind() { return new Attack("Calm Mind", 99, 99, 20, 12, 5, 2); }
    public static Attack LeafBlade() { return new Attack("Leaf Blade", 90, 100, 15, 7, 5, 0); }
    public static Attack DragonDance() { return new Attack("1 Dance", 99, 99, 20, 1, 5, 2); }
    public static Attack RockBlast() { return new Attack("13 Blast", 25, 90, 10, 13, 5, 0); }
    public static Attack ShockWave() { return new Attack("Shock Wave", 60, 99, 20, 2, 5, 1); }
    public static Attack WaterPulse() { return new Attack("14 Pulse", 60, 100, 20, 14, 5, 1); }
    public static Attack DoomDesire() { return new Attack("Doom Desire", 140, 100, 5, 15, 5, 1); }
    public static Attack PsychoBoost() { return new Attack("Psycho Boost", 140, 90, 5, 12, 5, 1); }
    public static Attack Roost() { return new Attack("Roost", 99, 99, 10, 5, 5, 2); }
    public static Attack Gravity() { return new Attack("Gravity", 99, 99, 5, 12, 5, 2); }
    public static Attack MiracleEye() { return new Attack("Miracle Eye", 99, 99, 40, 12, 5, 2); }
    public static Attack WakeUpSlap() { return new Attack("WakeUp Slap", 70, 100, 10, 3, 5, 0); }
    public static Attack HammerArm() { return new Attack("Hammer Arm", 100, 90, 10, 3, 5, 0); }
    public static Attack GyroBall() { return new Attack("Gyro Ball", 99, 100, 5, 15, 5, 0); }
    public static Attack HealingWish() { return new Attack("Healing Wish", 99, 99, 10, 12, 5, 2); }
    public static Attack Brine() { return new Attack("Brine", 65, 100, 10, 14, 5, 1); }
    public static Attack NaturalGift() { return new Attack("Natural Gift", 99, 100, 15, 10, 5, 0); }
    public static Attack Feint() { return new Attack("Feint", 30, 100, 10, 10, 5, 0); }
    public static Attack Pluck() { return new Attack("Pluck", 60, 100, 20, 5, 5, 0); }
    public static Attack Tailwind() { return new Attack("Tailwind", 99, 99, 15, 5, 5, 2); }
    public static Attack Acupressure() { return new Attack("Acupressure", 99, 99, 30, 10, 5, 2); }
    public static Attack MetalBurst() { return new Attack("Metal Burst", 99, 100, 10, 15, 5, 0); }
    public static Attack Uturn() { return new Attack("Uturn", 70, 100, 20, 0, 5, 0); }
    public static Attack CloseCombat() { return new Attack("Close Combat", 120, 100, 5, 3, 5, 0); }
    public static Attack Payback() { return new Attack("Payback", 50, 100, 10, 16, 5, 0); }
    public static Attack Assurance() { return new Attack("Assurance", 60, 100, 10, 16, 5, 0); }
    public static Attack Embargo() { return new Attack("Embargo", 99, 100, 15, 16, 5, 2); }
    public static Attack Fling() { return new Attack("Fling", 99, 100, 10, 16, 5, 0); }
    public static Attack PsychoShift() { return new Attack("Psycho Shift", 99, 100, 10, 12, 5, 2); }
    public static Attack TrumpCard() { return new Attack("Trump Card", 99, 99, 5, 10, 5, 1); }
    public static Attack HealBlock() { return new Attack("Heal Block", 99, 100, 15, 12, 5, 2); }
    public static Attack WringOut() { return new Attack("Wring Out", 99, 100, 5, 10, 5, 1); }
    public static Attack PowerTrick() { return new Attack("Power Trick", 99, 99, 10, 12, 5, 2); }
    public static Attack GastroAcid() { return new Attack("Gastro Acid", 99, 100, 10, 11, 5, 2); }
    public static Attack LuckyChant() { return new Attack("Lucky Chant", 99, 99, 30, 10, 5, 2); }
    public static Attack MeFirst() { return new Attack("Me First", 99, 99, 20, 10, 5, 2); }
    public static Attack Copycat() { return new Attack("Copycat", 99, 99, 20, 10, 5, 2); }
    public static Attack PowerSwap() { return new Attack("Power Swap", 99, 99, 10, 12, 5, 2); }
    public static Attack GuardSwap() { return new Attack("Guard Swap", 99, 99, 10, 12, 5, 2); }
    public static Attack Punishment() { return new Attack("Punishment", 99, 100, 5, 16, 5, 0); }
    public static Attack LastResort() { return new Attack("Last Resort", 140, 100, 5, 10, 5, 0); }
    public static Attack WorrySeed() { return new Attack("Worry Seed", 99, 100, 10, 7, 5, 2); }
    public static Attack SuckerPunch() { return new Attack("Sucker Punch", 70, 100, 5, 16, 5, 0); }
    public static Attack ToxicSpikes() { return new Attack("Toxic Spikes", 99, 99, 20, 11, 5, 2); }
    public static Attack HeartSwap() { return new Attack("Heart Swap", 99, 99, 10, 12, 5, 2); }
    public static Attack AquaRing() { return new Attack("Aqua Ring", 99, 99, 20, 14, 5, 2); }
    public static Attack MagnetRise() { return new Attack("Magnet Rise", 99, 99, 10, 2, 5, 2); }
    public static Attack FlareBlitz() { return new Attack("Flare Blitz", 120, 100, 15, 4, 5, 0); }
    public static Attack ForcePalm() { return new Attack("Force Palm", 60, 100, 10, 3, 5, 0); }
    public static Attack AuraSphere() { return new Attack("Aura Sphere", 80, 99, 20, 3, 5, 1); }
    public static Attack RockPolish() { return new Attack("13 Polish", 99, 99, 20, 13, 5, 2); }
    public static Attack PoisonJab() { return new Attack("11 Jab", 80, 100, 20, 11, 5, 0); }
    public static Attack DarkPulse() { return new Attack("16 Pulse", 80, 100, 15, 16, 5, 1); }
    public static Attack NightSlash() { return new Attack("Night Slash", 70, 100, 15, 16, 5, 0); }
    public static Attack AquaTail() { return new Attack("Aqua Tail", 90, 90, 10, 14, 5, 0); }
    public static Attack SeedBomb() { return new Attack("Seed Bomb", 80, 100, 15, 7, 5, 0); }
    public static Attack AirSlash() { return new Attack("Air Slash", 75, 95, 15, 5, 5, 1); }
    public static Attack XScissor() { return new Attack("XScissor", 80, 100, 15, 0, 5, 0); }
    public static Attack BugBuzz() { return new Attack("0 Buzz", 90, 100, 10, 0, 5, 1); }
    public static Attack DragonPulse() { return new Attack("1 Pulse", 85, 100, 10, 1, 5, 1); }
    public static Attack DragonRush() { return new Attack("1 Rush", 100, 75, 10, 1, 5, 0); }
    public static Attack PowerGem() { return new Attack("Power Gem", 80, 100, 20, 13, 5, 1); }
    public static Attack DrainPunch() { return new Attack("Drain Punch", 75, 100, 10, 3, 5, 0); }
    public static Attack VacuumWave() { return new Attack("Vacuum Wave", 40, 100, 30, 3, 5, 1); }
    public static Attack FocusBlast() { return new Attack("Focus Blast", 120, 70, 5, 3, 5, 1); }
    public static Attack EnergyBall() { return new Attack("Energy Ball", 90, 100, 10, 7, 5, 1); }
    public static Attack BraveBird() { return new Attack("Brave Bird", 120, 100, 15, 5, 5, 0); }
    public static Attack EarthPower() { return new Attack("Earth Power", 90, 100, 10, 8, 5, 1); }
    public static Attack Switcheroo() { return new Attack("Switcheroo", 99, 100, 10, 16, 5, 2); }
    public static Attack GigaImpact() { return new Attack("Giga Impact", 150, 90, 5, 10, 5, 0); }
    public static Attack NastyPlot() { return new Attack("Nasty Plot", 99, 99, 20, 16, 5, 2); }
    public static Attack BulletPunch() { return new Attack("Bullet Punch", 40, 100, 30, 15, 5, 0); }
    public static Attack Avalanche() { return new Attack("Avalanche", 60, 100, 10, 9, 5, 0); }
    public static Attack IceShard() { return new Attack("9 Shard", 40, 100, 30, 9, 5, 0); }
    public static Attack ShadowClaw() { return new Attack("Shadow Claw", 70, 100, 15, 6, 5, 0); }
    public static Attack ThunderFang() { return new Attack("Thunder Fang", 65, 95, 15, 2, 5, 0); }
    public static Attack IceFang() { return new Attack("9 Fang", 65, 95, 15, 9, 5, 0); }
    public static Attack FireFang() { return new Attack("4 Fang", 65, 95, 15, 4, 5, 0); }
    public static Attack ShadowSneak() { return new Attack("Shadow Sneak", 40, 100, 30, 6, 5, 0); }
    public static Attack MudBomb() { return new Attack("Mud Bomb", 65, 85, 10, 8, 5, 1); }
    public static Attack PsychoCut() { return new Attack("Psycho Cut", 70, 100, 20, 12, 5, 0); }
    public static Attack ZenHeadbutt() { return new Attack("Zen Headbutt", 80, 90, 15, 12, 5, 0); }
    public static Attack MirrorShot() { return new Attack("Mirror Shot", 65, 85, 10, 15, 5, 1); }
    public static Attack FlashCannon() { return new Attack("Flash Cannon", 80, 100, 10, 15, 5, 1); }
    public static Attack RockClimb() { return new Attack("13 Climb", 90, 85, 20, 10, 5, 0); }
    public static Attack Defog() { return new Attack("Defog", 99, 99, 15, 5, 5, 2); }
    public static Attack TrickRoom() { return new Attack("Trick Room", 99, 99, 5, 12, 5, 2); }
    public static Attack DracoMeteor() { return new Attack("Draco Meteor", 130, 90, 5, 1, 5, 1); }
    public static Attack Discharge() { return new Attack("Discharge", 80, 100, 15, 2, 5, 1); }
    public static Attack LavaPlume() { return new Attack("Lava Plume", 80, 100, 15, 4, 5, 1); }
    public static Attack LeafStorm() { return new Attack("Leaf Storm", 130, 90, 5, 7, 5, 1); }
    public static Attack PowerWhip() { return new Attack("Power Whip", 120, 85, 10, 7, 5, 0); }
    public static Attack RockWrecker() { return new Attack("13 Wrecker", 150, 90, 5, 13, 5, 0); }
    public static Attack CrossPoison() { return new Attack("Cross 11", 70, 100, 20, 11, 5, 0); }
    public static Attack GunkShot() { return new Attack("Gunk Shot", 120, 80, 5, 11, 5, 0); }
    public static Attack IronHead() { return new Attack("Iron Head", 80, 100, 15, 15, 5, 0); }
    public static Attack MagnetBomb() { return new Attack("Magnet Bomb", 60, 99, 20, 15, 5, 0); }
    public static Attack StoneEdge() { return new Attack("Stone Edge", 100, 80, 5, 13, 5, 0); }
    public static Attack Captivate() { return new Attack("Captivate", 99, 100, 20, 10, 5, 2); }
    public static Attack StealthRock() { return new Attack("Stealth 13", 99, 99, 20, 13, 5, 2); }
    public static Attack GrassKnot() { return new Attack("7 Knot", 99, 100, 20, 7, 5, 1); }
    public static Attack Chatter() { return new Attack("Chatter", 65, 100, 20, 5, 5, 1); }
    public static Attack Judgment() { return new Attack("Judgment", 100, 100, 10, 10, 5, 1); }
    public static Attack BugBite() { return new Attack("0 Bite", 60, 100, 20, 0, 5, 0); }
    public static Attack ChargeBeam() { return new Attack("Charge Beam", 50, 90, 10, 2, 5, 1); }
    public static Attack WoodHammer() { return new Attack("Wood Hammer", 120, 100, 15, 7, 5, 0); }
    public static Attack AquaJet() { return new Attack("Aqua Jet", 40, 100, 20, 14, 5, 0); }
    public static Attack AttackOrder() { return new Attack("Attack Order", 90, 100, 15, 0, 5, 0); }
    public static Attack DefendOrder() { return new Attack("Defend Order", 99, 99, 10, 0, 5, 2); }
    public static Attack HealOrder() { return new Attack("Heal Order", 99, 99, 10, 0, 5, 2); }
    public static Attack HeadSmash() { return new Attack("Head Smash", 150, 80, 5, 13, 5, 0); }
    public static Attack DoubleHit() { return new Attack("Double Hit", 35, 90, 10, 10, 5, 0); }
    public static Attack RoarofTime() { return new Attack("Roar of Time", 150, 90, 5, 1, 5, 1); }
    public static Attack SpacialRend() { return new Attack("Spacial Rend", 100, 95, 5, 1, 5, 1); }
    public static Attack LunarDance() { return new Attack("Lunar Dance", 99, 99, 10, 12, 5, 2); }
    public static Attack CrushGrip() { return new Attack("Crush Grip", 99, 100, 5, 10, 5, 0); }
    public static Attack MagmaStorm() { return new Attack("Magma Storm", 100, 75, 5, 4, 5, 1); }
    public static Attack DarkVoid() { return new Attack("16 Void", 99, 50, 10, 16, 5, 2); }
    public static Attack SeedFlare() { return new Attack("Seed Flare", 120, 85, 5, 7, 5, 1); }
    public static Attack OminousWind() { return new Attack("Ominous Wind", 60, 100, 5, 6, 5, 1); }
    public static Attack ShadowForce() { return new Attack("Shadow Force", 120, 100, 5, 6, 5, 0); }
}