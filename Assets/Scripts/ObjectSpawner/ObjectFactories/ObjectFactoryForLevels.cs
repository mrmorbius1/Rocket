using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    public abstract class ObjectFactoryForLevels : MonoBehaviour
    {
        public abstract Coin GetCoin();
        public abstract Krystal GetKrystal();
        public abstract Obstacle GetObstacle(ObstaclesType obstaclesType);
        public abstract Effect GetEffect(EffectType additionalEffectType);

        //public abstract Boss GetBoss();
    }
}
