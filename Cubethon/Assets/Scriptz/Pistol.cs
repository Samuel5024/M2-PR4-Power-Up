using UnityEngine;

namespace DecoratorPattern
{
    public class Pistol : IWeapon
    {
        public void Shoot()
        {
            Debug.Log("Shooting Weapon!");
        }
    }

}
