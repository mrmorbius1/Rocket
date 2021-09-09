using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    //TODO: Возможно лучше хранить в GameObject.
    //TODO: Событие которое подпишется на метод создания объекта в фабрике (паттерн наблюдатель).
    class DatabaseOfCreatedGameObjects : MonoBehaviour
    {
        private List<Coin> _activeCoins;
        private List<Krystal> _activeKrystals;
        private List<Obstacle> _activeObstacles;
        private List<Effect> _activeEffects;

        private List<Coin> _notActiveCoins;
        private List<Krystal> _notActiveKrystals;
        private List<Obstacle> _notActiveObstacles;
        private List<Effect> _notActiveEffects;

        private const int DEFAULT_FIRST_INDEX = 0;    

        public Coin GetNotActiveCoin_CanReturnNull()    //Метод выполняет несколько задач, метод обманывает своим названием.
        {
            if(_notActiveCoins.Count > 0)
            {
                Coin coin = _notActiveCoins[DEFAULT_FIRST_INDEX];
                _notActiveCoins.RemoveAt(DEFAULT_FIRST_INDEX);
                _activeCoins.Add(coin);
                return coin;
            }

            return null;
        }

        public Krystal GetNotActiveKrystal_CanReturnNull()
        {
            if(_notActiveKrystals.Count > 0)
            {
                return _notActiveKrystals[DEFAULT_FIRST_INDEX];
            }

            return null;
        }

        public Obstacle GetNotActiveObstacle_CanReturnNull(ObstaclesType obstaclesType)
        {
            if(_notActiveObstacles.Count > 0)
            {
                foreach (var item in _notActiveObstacles)
                {
                    if(item.obstaclesType == obstaclesType)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        public Effect GetNotActiveEffect_CanReturnNull(EffectType effectType)
        {
            if (_notActiveEffects.Count > 0)
            {
                foreach (var item in _notActiveEffects)
                {
                    if(item.effectType == effectType)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        public void AddNewGameObject<T>(T gameObject) where T: MonoBehaviour
        {
            switch (gameObject)
            {
                case Coin coin:
                    AddActiveGameObject(_activeCoins, coin);
                    break;

                case Krystal krystal:
                    AddActiveGameObject(_activeKrystals, krystal);
                    break;

                case Obstacle obstacle:
                    AddActiveGameObject(_activeObstacles, obstacle);
                    break;

                case Effect effect:
                    AddActiveGameObject(_activeEffects, effect);
                    break;
            }
        }

        private void ActivateGameObject()
        {

        }

        private void DeactivateGameObject()
        {

        }

        private void AddNotActiveGameObject<T>(List<T> gameObjects, T gameObject)
        {
            gameObjects.Add(gameObject);
        }

        private void RemoveNotActiveGameObject<T>(List<T> gameObjects)
        {
            gameObjects.RemoveAt(DEFAULT_FIRST_INDEX);
        }

        private void AddActiveGameObject<T>(List<T> gameObjects, T gameObject)
        {
            gameObjects.Add(gameObject);
        }

        private void RemoveActiveGameObject<T>(List<T> gameObjects)     //Возможно удаление конкретного объекта будет лучше.
        {
            gameObjects.RemoveAt(DEFAULT_FIRST_INDEX);
        }
    }
}
