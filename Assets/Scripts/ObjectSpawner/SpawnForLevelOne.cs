using Scripts.ObjectSpawner.Algorithms;
using Scripts.ObjectSpawner.Algorithms.LevelOne;
using UnityEngine;

namespace Scripts.ObjectSpawner
{
    public class SpawnForLevelOne : Spawner
    {
        public override ISpawnAlgorithm SpawnAlgorithm { get; set; }

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            SpawnAlgorithm = new AlgorithmSpawnObjectsForLevelOne();
        }
    }
}
