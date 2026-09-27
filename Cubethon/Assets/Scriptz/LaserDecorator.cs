using UnityEngine;

namespace DecoratorPattern
{
    public class LaserDecorator : WeaponDecorator
    {
        public LaserDecorator(IWeapon weapon) : base(weapon) { }

        public override void Shoot()
        {
            base.Shoot();
        }
    }
}

