﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int HealingAmmount { get; set; }
        public HealingPotion(int id, string name, string namePlural, int healingAmount) : base(id, name, namePlural)
        {
            HealingAmmount = healingAmount;
        }
    }
}
