using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_1_OOP_201902.Card;

namespace Laboratorio_1_OOP_201902.Card
{
    public class CombatCard : Card
    {
        //Atributes

        private int attackPoints;
        private bool hero;



        //Properties

        public int AttackPoints { get { return this.attackPoints; } set { this.attackPoints = value; } }
        public bool Hero { get { return this.hero; } set { this.hero = value; } }


        //Constructor

        public CombatCard(string name, int attackPoints, bool hero, string type, string effect) : base(name, type, effect)
        {
            this.attackPoints = attackPoints;
            this.hero = hero;
        }


    }
}
