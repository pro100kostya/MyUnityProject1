using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew
{
    public class JumpPotion : MonoBehaviour
    {
        [SerializeField] private float _jumpModifier;


        public void Apply(GameObject target)
        {
            var hero = target.GetComponent<Hero>();
            hero?.ModifyJumpSpeed(_jumpModifier);
        }
    }
}

