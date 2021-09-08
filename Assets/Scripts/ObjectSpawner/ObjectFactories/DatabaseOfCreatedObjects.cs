using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    //TODO: Возможно лучше хранить в GameObject.
    //TODO: Событие которое подпишется на метод создания объекта в фабрике (паттерн наблюдатель).
    class DatabaseOfCreatedObjects : MonoBehaviour
    {
        private List<Coin> _notActiveCoins;
        private List<Krystal> _notActiveKrystals;
        private List<Obstacle> _notActiveObstacles;
        private List<Effect> _notActiveEffects;

        private const int DEFAULT_ELEMENT_INDEX = 0;    


        public Coin GetNotActiveCoin_CanReturnNull()
        {
            if(_notActiveCoins.Count > 0)
            {
                return _notActiveCoins[DEFAULT_ELEMENT_INDEX];
            }

            return null;
        }
        public Krystal GetNotActiveKrystal_CanReturnNull()
        {
            if(_notActiveKrystals.Count > 0)
            {
                return _notActiveKrystals[DEFAULT_ELEMENT_INDEX];
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
                    _notActiveCoins.Add(coin);
                    break;

                case Krystal krystal:
                    _notActiveKrystals.Add(krystal);
                    break;

                case Obstacle obstacle:
                    _notActiveObstacles.Add(obstacle);
                    break;

                case Effect effect:
                    _notActiveEffects.Add(effect);
                    break;
            }
        }
    }
}
