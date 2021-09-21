using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    //TODO: Возможно лучше хранить в GameObject.
    //TODO: Событие которое подпишется на метод создания объекта в фабрике (паттерн наблюдатель).
    class DatabaseOfCreatedGameObjects : MonoBehaviour      //Универсальная или на один уровень?
    {
        #region Test
        private List<Coin> _activeCoins;
        private List<Krystal> _activeKrystals;
        private List<Obstacle> _activeObstacles;
        private List<Effect> _activeEffects;

        private List<Coin> _notActiveCoins;
        private List<Krystal> _notActiveKrystals;
        private List<Obstacle> _notActiveObstacles;
        private List<Effect> _notActiveEffects;

        private const int DEFAULT_FIRST_INDEX = 0;

        public Coin GetNotActiveCoin_CanReturnNull()
        {
            if (_notActiveCoins.Count > 0)
            {
                Coin coin = _notActiveCoins[DEFAULT_FIRST_INDEX];
                ActivateGameObject(_notActiveCoins, _activeCoins, coin);
                return coin;
            }

            return null;
        }

        public Krystal GetNotActiveKrystal_CanReturnNull()
        {
            if (_notActiveKrystals.Count > 0)
            {
                Krystal krystal = _notActiveKrystals[DEFAULT_FIRST_INDEX];
                ActivateGameObject(_notActiveKrystals, _activeKrystals, krystal);
                return krystal;
            }

            return null;
        }

        public Obstacle GetNotActiveObstacle_CanReturnNull(ObstaclesType obstaclesType)
        {
            if (_notActiveObstacles.Count > 0)
            {
                foreach (var obstacle in _notActiveObstacles)
                {
                    if (obstacle.obstaclesType == obstaclesType)
                    {
                        ActivateGameObject(_notActiveObstacles, _activeObstacles, obstacle);
                        return obstacle;
                    }
                }
            }

            return null;
        }

        public Effect GetNotActiveEffect_CanReturnNull(EffectType effectType)
        {
            if (_notActiveEffects.Count > 0)
            {
                foreach (var effect in _notActiveEffects)
                {
                    if (effect.effectType == effectType)
                    {
                        ActivateGameObject(_notActiveEffects, _activeEffects, effect);
                        return effect;
                    }
                }
            }

            return null;
        }

        public void AddNewGameObject<T>(T gameObject) where T : MonoBehaviour    //
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

        private void ActivateGameObject<T>(List<T> notActiveGameObjects, List<T> activeGameObjects, T gameObject)   //Названия параметров.
        {
            RemoveNotActiveGameObject(notActiveGameObjects, gameObject);
            AddActiveGameObject(activeGameObjects, gameObject);
        }
        private void DeactivateGameObject<T>(List<T> activeGameObjects, List<T> notActiveGameObjects, T gameObject)    //Названия параметров.
        {
            RemoveActiveGameObject(activeGameObjects, gameObject);
            AddNotActiveGameObject(notActiveGameObjects, gameObject);
        }


        private void AddNotActiveGameObject<T>(List<T> gameObjects, T gameObject)   //Названия параметров.
        {
            gameObjects.Add(gameObject);
        }
        private void RemoveNotActiveGameObject<T>(List<T> gameObjects, T gameObject)    //Названия параметров.
        {
            gameObjects.Remove(gameObject);
        }


        private void AddActiveGameObject<T>(List<T> gameObjects, T gameObject)  //Названия параметров.
        {
            gameObjects.Add(gameObject);
        }
        private void RemoveActiveGameObject<T>(List<T> gameObjects, T gameObject)   //Названия параметров.  
        {
            gameObjects.Remove(gameObject);
        }
        #endregion

        #region Test 2
        private List<GameObject> _activeGameObjects;
        private List<GameObject> _notActiveGameObjects;

        public void AddNewActiveGameObject(GameObject gameObject)   //
        {
            AddActiveGameObject(gameObject);
        }

        public T GetNotActiveGameObject_CanReturnNull<T>() where T : class
        {
            T gameObject = SearchNotActiveGameObject_CanReturnNull<T>();
            return gameObject;
        }

        private T SearchNotActiveGameObject_CanReturnNull<T>() where T : class
        {
            if (_notActiveGameObjects.Count > 0)
            {
                foreach (var item in _notActiveGameObjects)
                {
                    if (item is T gameObject)
                    {
                        return gameObject;
                    }
                }
            }
            return null;
        }

        private void ActivateGameObject(GameObject gameObject)
        {
            EnableGameObject(gameObject);
            RemoveNotActiveGameObject(gameObject);
            AddActiveGameObject(gameObject);
        }

        private void DeactivateGameObject(GameObject gameObject) 
        {
            DisableGameObject(gameObject);
            RemoveActiveGameObject(gameObject);
            AddNotActiveGameObject(gameObject);
        }

        //from, in.

        private void EnableGameObject(GameObject gameObject)
        {
            gameObject.SetActive(true);
        }   

        private void DisableGameObject(GameObject gameObjects)
        {
            gameObject.SetActive(false);
        }

        private void AddActiveGameObject(GameObject gameObject)
        {
            _activeGameObjects.Add(gameObject);
        }

        private void RemoveActiveGameObject(GameObject gameObject)
        {
            _activeGameObjects.Remove(gameObject);
        }

        private void AddNotActiveGameObject(GameObject gameObject)
        {
            _notActiveGameObjects.Add(gameObject);
        }

        private void RemoveNotActiveGameObject(GameObject gameObject)
        {
            _notActiveGameObjects.Remove(gameObject);
        }

        #endregion
    }
}
