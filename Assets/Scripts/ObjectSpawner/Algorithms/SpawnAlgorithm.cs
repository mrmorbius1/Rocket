using Scripts.ObjectSpawner.ObjectFactories;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.ObjectSpawner.Algorithms
{
    public abstract class SpawnAlgorithm : MonoBehaviour
    {
        [SerializeField]
        private ObjectFactoryForLevels _objectFactoryForLevels;
        public abstract void Algorithm();   
    }
}
