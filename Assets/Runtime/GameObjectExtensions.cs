using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions
{
    public static class GameObjectExtensions
    {
        #region Instantiate
        public static GameObject Instantiate(this GameObject go)
        {
            return GameObject.Instantiate(go);
        }

        public static GameObject Instantiate(this GameObject go, Vector3 position)
        {
            return GameObject.Instantiate(go, position, Quaternion.identity);
        }

        public static GameObject Instantiate(this GameObject go, Vector3 position, Quaternion rotation)
        {
            return GameObject.Instantiate(go, position, rotation);
        }

        public static GameObject Instantiate(this GameObject go, Vector3 position, Quaternion rotation, Transform parent)
        {
            return GameObject.Instantiate(go, position, rotation);
        }

        public static T Instantiate<T>(this T original) where T : Object
        {
            return GameObject.Instantiate<T>(original);
        }

        public static T Instantiate<T>(this T original, Vector3 position) where T : Object
        {
            return GameObject.Instantiate<T>(original, position, Quaternion.identity);
        }

        public static T Instantiate<T>(this T original, Vector3 position, Quaternion rotation) where T : Object
        {
            return GameObject.Instantiate<T>(original, position, rotation);
        }

        public static T Instantiate<T>(this T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
        {
            return GameObject.Instantiate<T>(original, position, rotation, parent);
        }
        #endregion
    }
}
