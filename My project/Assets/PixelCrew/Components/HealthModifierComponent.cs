using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Components
{
    public class HealthModifierComponent : MonoBehaviour
    {
        [SerializeField] private int _modifier;

        public void Apply(GameObject target)
        {
            var healthComponent = target.GetComponent<HealthComponent>();
            if (healthComponent != null)
            {
                healthComponent.ModifyHealth(_modifier);
            }
        }
    }
}

