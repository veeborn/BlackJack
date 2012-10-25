using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class BasicWinStrategy : IWinStrategy
    {
        public const int g_maxScore = 21;

        public bool IsDealerWinner(Player m_dealer, Player m_player)
        {
            if (m_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (m_dealer.CalcScore() > g_maxScore)
            {
                return false;
            }
            return m_dealer.CalcScore() >= m_player.CalcScore();
        }

    }
}
