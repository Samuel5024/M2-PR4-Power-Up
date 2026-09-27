using UnityEngine;

namespace DecoratorPattern
{
    public class PistolController : MonoBehaviour
    {
        [SerializeField] private PistolUpgrader pistolUpgrader;

        private IWeapon weapon;
        private void Start()
        {
            weapon = pistolUpgrader.weapon;
        }

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                weapon.Shoot();
            }
        }
    }
}