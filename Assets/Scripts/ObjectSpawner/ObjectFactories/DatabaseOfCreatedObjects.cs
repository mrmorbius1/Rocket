using Scripts.GameObjects;
using Scripts.GameObjects.AdditionalEffects;
using Scripts.GameObjects.Obstacles;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.ObjectSpawner.ObjectFactories
{
    //TODO: Возможно лучше хранить в GameObject.
    //TODO: Событие которое подпишется на метод создания объекта в фабрике (паттерн наблюдатель).
    class DatabaseOfCreatedObjects : MonoBehaviour
    {
        //[SerializeField] private GameObject _activeGameObject;  //new name _parentForActiveObjects
        //[SerializeField] private GameObject _notActiveGameObject;  //new name _parentForNotActiveObjects

        private List<Coin> _activeСoins;
        private List<Krystal> _activeKrystals;
        private List<Obstacle> _activeObstacles;
        private List<Effect> _activeEffects;

        private List<Coin> _notActiveСoins;
        private List<Krystal> _notActiveKrystals;
        private List<Obstacle> _notActiveObstacles;
        private List<Effect> _notActiveEffects;


        private GameObject[] _activeGameObjects;
        private GameObject[] _notActiveGameObjects;

        public bool GetNotActiveObject<T>(/*out T gameObject*/) //Подумать над правильностью именования метода.
        {
            return false;
        }

        private T SearchNotActiveObject<T>(T gameObject) where T : class
        {
            foreach (var notActiveGameObject in _notActiveGameObjects)
            {
                //if (notActiveGameObject is T)
                //{
                //    T t = (T)notActiveGameObject;
                //    return t;
                //}
                if (notActiveGameObject is T t)
                {
                    return t;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
