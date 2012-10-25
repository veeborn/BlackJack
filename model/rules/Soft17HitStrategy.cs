﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17HitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            return (a_dealer.GetHand().Any(w => w.GetValue() == Card.Value.Ace) && a_dealer.CalcScore() == g_hitLimit) || a_dealer.CalcScore() < g_hitLimit;
        }
    }
}
