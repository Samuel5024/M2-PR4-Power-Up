using UnityEngine;
namespace DecoratorPattern
{
    public class WeaponDecorator : IWeapon
    {
        protected IWeapon wrappedWeapon; // Store a reference to the weapon we are currently decorating

        public WeaponDecorator(IWeapon _wrappedWeapon)
        {
            wrappedWeapon = _wrappedWeapon; // Pass in an existing IWeapon whenever we create a new decorator
        }

        public virtual void Shoot()
        {
            wrappedWeapon.Shoot();
        }
    }
}

