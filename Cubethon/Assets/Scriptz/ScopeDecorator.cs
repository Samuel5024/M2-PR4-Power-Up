using UnityEngine;

namespace DecoratorPattern
{
    public class ScopeDecorator : WeaponDecorator
    {
        public ScopeDecorator(IWeapon weapon) : base(weapon) 
        {
            weaponData.effectiveRange += 200;
            weaponData.zoomFOV -= 10;
        }

        public override void Shoot()
        {
            base.Shoot();
        }
    }

}