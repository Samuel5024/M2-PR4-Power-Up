using UnityEngine;

namespace DecoratorPattern
{
    public class LaserDecorator : WeaponDecorator
    {
        public LaserDecorator(IWeapon weapon) : base(weapon) 
        {
            weaponData.effectiveRange += 150;
            weaponData.zoomFOV -= 4;
        }

        public override void Shoot()
        {
            base.Shoot();
        }
    }
}

