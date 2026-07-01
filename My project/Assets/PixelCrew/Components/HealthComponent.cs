using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew.Components
{
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private int _maxHealth;
        [SerializeField] private UnityEvent _onDamage;
        [SerializeField] private UnityEvent _onDie;

        private int _currentHealth;

        public void Awake()
        {
            _currentHealth = _maxHealth;
        }

        public void ModifyHealth(int modifier)
        {
            _currentHealth += modifier;
            if (modifier < 0)
            {
                _onDamage?.Invoke();
                if (_currentHealth <= 0)
                {
                    _onDie?.Invoke();
                }
            }
            else if (_currentHealth > _maxHealth) _currentHealth = _maxHealth;

            Debug.Log($"Current health = {_currentHealth}");
        }
    }
}
