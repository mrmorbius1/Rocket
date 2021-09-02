using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    //TODO: После разработки фабрики и баззы данных, посмотреть соблюдается ли принцип инверсии зависимостей.
    public class ObjectFactoryForLevelOne : ObjectFactoryForLevels
    {
        //Придумать типы названий для препятсвий каждого уровня.

        [SerializeField] private Coin _coinPrefab;
        [SerializeField] private Krystal _krystalPrefab;
        [SerializeField] private Obstacle _obstacle_1_prefab;   //
        [SerializeField] private Obstacle _obstacle_2_prefab;   //
        [SerializeField] private Obstacle _obstacle_3_prefab;   //
        [SerializeField] private Obstacle _obstacle_4_prefab;   //
        [SerializeField] private Obstacle _obstacle_5_prefab;   //
        [SerializeField] private Obstacle _obstacle_6_prefab;   //
        [SerializeField] private Obstacle _obstacle_7_prefab;   //
        [SerializeField] private Obstacle _obstacle_8_prefab;   //
        [SerializeField] private Effect _immunityPrefab;
        [SerializeField] private Effect _magnitePrefab;
        [SerializeField] private Effect _endllesTeleportPrefab;

        public override Coin GetCoin()
        {
            throw new System.NotImplementedException();
        }  

        public override Krystal GetKrystal()
        {
            throw new System.NotImplementedException();
        }

        public override Obstacle GetObstacle(ObstaclesType obstaclesType)
        {
            throw new System.NotImplementedException();
        }

        public override Effect GetEffect(AdditionalEffectType additionalEffectType)
        {
            throw new System.NotImplementedException();
        }


    }
}
