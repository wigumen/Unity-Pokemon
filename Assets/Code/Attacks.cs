/*"Bug" 0,
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
*/
public class Attack
{
    public string Name { get; set; }
    public int Power { get; set; }
    public int Acc { get; set; }
    public int PP { get; set; }
    public int Type { get; set; }
    public int Range = 20;
    public bool category { get; set; } //phycial = false    special = true
}

public class Tackle : Attack
{
    public Tackle()
    {
        Name = "Tackle";
        Power = 40;
        Acc = 100;
        PP = 35;
        Type = 10;
        category = false;
    }
}

public class Pound : Attack
{
    public Pound()
    {
        Name = "Pound";
        Power = 40;
        Acc = 100;
        PP = 35;
        Type = 10;
        category = false;
    }
}
public class Karacte_Chop : Attack
{
    public Karacte_Chop()
    {
        Name = "Karate Chop";
        Power = 50;
        Acc = 100;
        PP = 25;
        Type = 3;
        category = false;
    }
}

public class Double_Slap : Attack
{
    public Double_Slap()
    {
        Name = "Double_Slap";
        Power = 10;
        Acc = 85;
        PP = 10;
        Type = 10;
        category = false;
    }
}

public class Comet_Punch : Attack
{
    public Comet_Punch()
    {
        Name = "Comet_Punch";
        Power = 18;
        Acc = 85;
        PP = 15;
        Type = 10;
        category = false;
    }
}

public class Mega_Punch : Attack
{
    public Mega_Punch()
    {
        Name = "Mega_Punch";
        Power = 80;
        Acc = 85;
        PP = 20;
        Type = 10;
        category = false;
    }
}

public class Pay_Day : Attack
{
    public Pay_Day()
    {
        Name = "Pay_Day";
        Power = 40;
        Acc = 100;
        PP = 20;
        Type = 10;
        category = false;
    }
}

public class Fire_Punch : Attack
{
    public Fire_Punch()
    {
        Name = "Fire_Punch";
        Power = 75;
        Acc = 100;
        PP = 15;
        Type = 4;
        category = false;
    }
}

public class Ice_Punch : Attack
{
    public Ice_Punch()
    {
        Name = "Ice_Punch";
        Power = 75;
        Acc = 100;
        PP = 15;
        Type = 9;
        category = false;
    }
}

public class Thunder_Punch : Attack
{
    public Thunder_Punch()
    {
        Name = "Thunder_Punch";
        Power = 75;
        Acc = 100;
        PP = 15;
        Type = 2;
        category = false;
    }
}

public class Scratch : Attack
{
    public Scratch()
    {
        Name = "Scratch";
        Power = 40;
        Acc = 100;
        PP = 35;
        Type = 10;
        category = false;
    }
}

public class Vice_Grip : Attack
{
    public Vice_Grip()
    {
        Name = "Vice_Grip";
        Power = 55;
        Acc = 100;
        PP = 30;
        Type = 10;
        category = false;
    }
}

public class Guillotine : Attack
{
    public Guillotine()
    {
        Name = "Guillotine";
        Power = 10000;
        Acc = 25;
        PP = 5;
        Type = 10;
        category = false;
    }
}

public class Razor_Wind : Attack
{
    public Razor_Wind()
    {
        Name = "Razor_Wind";
        Power = 80;
        Acc = 100;
        PP = 10;
        Type = 10;
        category = true;
    }
}
/*
public class Swords_Dance : Attack
{
    public Swords_Dance()
    {
        Name = "Swords_Dance";
        Power = 80;
        Acc = 85;
        PP = 20;
        Type = 10;
        category = false;
    }
}
*/
public class Cut : Attack
{
    public Cut()
    {
        Name = "Cut";
        Power = 50;
        Acc = 95;
        PP = 20;
        Type = 10;
        category = false;
    }
}