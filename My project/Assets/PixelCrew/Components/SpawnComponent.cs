using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PixelCrew.Components
{
    public class SpawnComponent : MonoBehaviour
    {
        [SerializeField] Transform _target;
        [SerializeField] GameObject _prefab;

        [ContextMenu("Spawn")]
        public void Spawn()
        {
            var instanse = Instantiate(_prefab, _target.position, Quaternion.identity);
            instanse.transform.localScale = _target.transform.lossyScale;
        }
    }
}

