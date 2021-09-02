using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    public abstract class ObjectFactoryForLevels : MonoBehaviour
    {
        public abstract Coin GetCoin();
        public abstract Krystal GetKrystal();
        public abstract Obstacle GetObstacle(ObstaclesType obstaclesType);
        public abstract Effect GetEffect(AdditionalEffectType additionalEffectType);

        //public abstract Boss GetBoss();
    }
}
