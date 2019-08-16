using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_1_OOP_201902.Card;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard : Card
    {
        //Atributes

        private string buffType;

        //Properties

        public string BuffType { get { return this.buffType; } set { this.buffType = value; } }

        //Constructor

        public SpecialCard(string name, string type, string effect, string buffType) : base(name, type, effect)
        {
            this.buffType = buffType;
        }


    }
}
