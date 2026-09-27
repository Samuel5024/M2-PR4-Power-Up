using UnityEngine;
namespace DecoratorPattern
{
    public class WeaponDecorator : IWeapon
    {
        protected IWeapon wrappedWeapon;

        public WeaponDecorator(IWeapon _wrappedWeapon)
        {
            wrappedWeapon = _wrappedWeapon;
        }

        public virtual void Shoot()
        {
            wrappedWeapon.Shoot();
        }
    }
}

