using Scripts.ObjectSpawner.Algorithms;
using UnityEngine;

namespace Scripts.ObjectSpawner
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private SpawnAlgorithm _spawnAlgorithm;

        private void Start()
        {
            StartAlgorithm();
        }

        private void StartAlgorithm()
        {
            _spawnAlgorithm.Algorithm();
        }
    }
}
