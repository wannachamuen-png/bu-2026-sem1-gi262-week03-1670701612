using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana;

        public override void Attack(Entity target)
        {
            // Implement the logic for the Mage's attack, which could involve casting spells or using magical abilities.
        }

        public void CastSpell(Entity target)
            {
            // Implement the logic for casting a spell, which could consume mana and have various effects on the target.
        }
    }
}
