using UnityEngine;

namespace DecoratorPattern
{
    public class SilencerDecorator : WeaponDecorator
    {
        public SilencerDecorator(IWeapon weapon) : base(weapon) { } // Constructor takes in the wrapped weapon & 
                                                                    // calls the constructor in the base class
        public override void Shoot()
        {
            base.Shoot();
            Debug.Log("The weapon has a silencer.");
        }
    }
}

