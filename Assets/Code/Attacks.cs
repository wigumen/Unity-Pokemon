using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Attack
    {
        public string name { get; set; }
        public int Power { get; set; }
        public int Acc { get; set; }
        public int PP { get; set; }
        public int type { get; set; }
        public int range = 20;

    }

    public class Tackle : Attack
    {
        public Tackle()
        {
            name = "Tackle";
            Power = 40;
            Acc = 100;
            PP = 30;
            type = 10;
        }
    }
