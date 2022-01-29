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
        public static Vector3 ToVector3XY0(this Vector2 vector2)
        {
            return new Vector3(vector2.x, vector2.y, 0);
        }

        public static Vector3 ToVector3YX0(this Vector2 vector2)
        {
            return new Vector3(vector2.y, vector2.x, 0);
        }

        public static Vector3 ToVector30XY(this Vector2 vector2)
        {
            return new Vector3(0, vector2.x, vector2.y);
        }

        public static Vector3 ToVector30YX(this Vector2 vector2)
        {
            return new Vector3(0, vector2.y, vector2.x);
        }

        public static Vector3 ToVector3X0Y(this Vector2 vector2)
        {
            return new Vector3(vector2.x, 0, vector2.y);
        }

        public static Vector3 ToVector3Y0X(this Vector2 vector2)
        {
            return new Vector3(vector2.y, 0, vector2.x);
        }
        #endregion
    }
}
