using Scripts.ObjectSpawner.ObjectFactories;
using UnityEngine;

namespace Scripts.ObjectSpawner.Algorithms.LevelOne
{
    public class AlgorithmSpawnObjectsForLevelOne : MonoBehaviour, ISpawnAlgorithm
    {
        private ObjectFactoryForLevels _objectFactoryForLevels;     //Добавить поле в интерфейс ISpawnAlgorithm ? 

        private void Awake()
        {
            Initialize();
        }

        public void SpawnAlgorithm()
        {
            //ФАБРИКА.
        }    

        private void Initialize()
        {
            
        }
    }
}
