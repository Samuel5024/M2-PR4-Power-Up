using UnityEngine;

namespace DecoratorPattern
{
    public class PistolController : MonoBehaviour
    {
        private void Start()
        {
            IWeapon pistol = new Pistol();
            pistol = new SilencerDecorator(pistol);
            pistol = new ScopeDecorator(pistol);
            pistol = new LaserDecorator(pistol);
            pistol.Shoot();
        }

        void Update()
        {

        }
    }
}