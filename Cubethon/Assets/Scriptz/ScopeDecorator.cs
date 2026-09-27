using UnityEngine;

namespace DecoratorPattern
{
    public class ScopeDecorator : WeaponDecorator
    {
        public ScopeDecorator(IWeapon weapon) : base(weapon) { }

        public override void Shoot()
        {
            base.Shoot();
            Debug.Log("The weaopn has a scope.");
        }
    }

}