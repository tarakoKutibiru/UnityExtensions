using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions
{
    public static class Vector2Extensions
    {
        public static Vector2 SetX(this Vector2 vector2, float x)
        {
            vector2.x = x;
            return vector2;
        }

        public static Vector2 SetY(this Vector2 vector2, float y)
        {
            vector2.y = y;
            return vector2;
        }

        #region ToVector3
        public static Vector3 ToVector3(this Vector2 vector2)
        {
            return (Vector3)vector2;
        }
        #endregion
    }
}
