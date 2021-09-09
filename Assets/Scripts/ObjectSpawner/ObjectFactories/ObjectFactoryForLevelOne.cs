using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    //TODO: После разработки фабрики и баззы данных, посмотреть соблюдается ли принцип инверсии зависимостей.
    public class ObjectFactoryForLevelOne : ObjectFactoryForLevels
    {
        [SerializeField]
        private Coin _coinPrefab;
        [SerializeField]
        private Krystal _krystalPrefab;

        [SerializeField]
        private Obstacle _obstacleOnePrefab;   
        [SerializeField]
        private Obstacle _obstacleTwoPrefab;   
        [SerializeField]
        private Obstacle _obstacleThreePrefab;   
        [SerializeField]
        private Obstacle _obstacleFourPrefab;   
        [SerializeField]
        private Obstacle _obstacleFivePrefab;   
        [SerializeField]
        private Obstacle _obstacleSixPrefab;   
        [SerializeField]
        private Obstacle _obstacleSevenPrefab;   
        [SerializeField]
        private Obstacle _obstacleEightPrefab; 
        
        [SerializeField]
        private Effect _immunityPrefab;
        [SerializeField]
        private Effect _magnitePrefab;
        [SerializeField]
        private Effect _endllesTeleportPrefab;

        [SerializeField]
        private DatabaseOfCreatedGameObjects _databaseOfCreatedGameObjects;

        public override Coin GetCoin()
        {
            Coin coin = _databaseOfCreatedGameObjects.GetNotActiveCoin_CanReturnNull();
            
            if(coin == null)
            {
                coin = InitializeNewGameObject(_coinPrefab);
                return coin;
            }

            return coin;
        }  

        public override Krystal GetKrystal()
        {
            Krystal krystal = _databaseOfCreatedGameObjects.GetNotActiveKrystal_CanReturnNull();    

            if (krystal == null)
            {
                krystal = InitializeNewGameObject(_krystalPrefab);
                return krystal;
            }

            return krystal;
        }

        public override Obstacle GetObstacle(ObstaclesType obstaclesType)
        {
            Obstacle obstacle = _databaseOfCreatedGameObjects.GetNotActiveObstacle_CanReturnNull(obstaclesType);

            if(obstacle == null)
            {
                switch (obstaclesType)
                {
                    case ObstaclesType.ObstacleOne:
                        return InitializeNewGameObject(_obstacleOnePrefab);

                    case ObstaclesType.ObstacleTwo:
                        return InitializeNewGameObject(_obstacleTwoPrefab);

                    case ObstaclesType.ObstacleThree:
                        return InitializeNewGameObject(_obstacleThreePrefab);

                    case ObstaclesType.ObstacleFour:
                        return InitializeNewGameObject(_obstacleFourPrefab);

                    case ObstaclesType.ObstacleFive:
                        return InitializeNewGameObject(_obstacleFivePrefab);

                    case ObstaclesType.ObstacleSix:
                        return InitializeNewGameObject(_obstacleSixPrefab);

                    case ObstaclesType.ObstacleSeven:
                        return InitializeNewGameObject(_obstacleSevenPrefab);

                    case ObstaclesType.ObstacleEight:
                        return InitializeNewGameObject(_obstacleEightPrefab);
                }
            }

            return obstacle;
        }

        public override Effect GetEffect(EffectType effectType)
        {
            Effect effect = _databaseOfCreatedGameObjects.GetNotActiveEffect_CanReturnNull(effectType);

            if(effect == null)
            {
                switch (effectType)
                {
                    case EffectType.Immunit:
                        return InitializeNewGameObject(_immunityPrefab);

                    case EffectType.Magnite:
                        return InitializeNewGameObject(_magnitePrefab);

                    case EffectType.EndllesTeleport:
                        return InitializeNewGameObject(_endllesTeleportPrefab);
                }
            }

            return effect;
        }

        private T InitializeNewGameObject<T>(T prefab) where T : MonoBehaviour
        {
            T instance = CreateNewGameObject(prefab);
            _databaseOfCreatedGameObjects.AddNewGameObject(instance);
            return instance;
        }

        private T CreateNewGameObject<T>(T prefab) where T : MonoBehaviour
        {
            T instance = Instantiate(prefab);
            return instance;
        }
    }
}
