using Scripts.ObjectSpawner.Algorithms;
using UnityEngine;

namespace Scripts.ObjectSpawner
{
    public abstract class Spawner : MonoBehaviour
    {
        public abstract ISpawnAlgorithm SpawnAlgorithm { get; set; }    //Сделать protected, тк это не интерфейс взаимодействия?
    }
}
