using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    public abstract class ObjectFactoryForLevels : MonoBehaviour
    {
        #region Test
        //public abstract Coin GetCoin();
        //public abstract Krystal GetKrystal();
        //public abstract Obstacle GetObstacle(ObstaclesType obstaclesType);
        //public abstract Effect GetEffect(EffectType additionalEffectType);

        //public abstract Boss GetBoss();

        //Ссылка на базу данных должна быть здесь.

        #endregion

        public abstract GameObject GetCoin();
        public abstract GameObject GetKrystal();
        public abstract GameObject GetObstacle(ObstaclesType obstaclesType);
        public abstract GameObject GetEffect(EffectType additionalEffectType);

        //Ссылка на базу данных должна быть здесь.
    }
}
