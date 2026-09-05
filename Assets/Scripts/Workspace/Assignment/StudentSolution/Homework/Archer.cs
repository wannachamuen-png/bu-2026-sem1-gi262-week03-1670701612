using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Archer : RangeEnemy
    {
        public int accuracy;

        public override void Attack(Entity target)
        {
            // Implement the logic for the Archer's attack, which could involve shooting arrows at the target.
        }

        public void AimAndShoot(Entity target)
        {
            // Implement the logic for aiming, which could improve the accuracy of the Archer's attacks.
        }
    }
}