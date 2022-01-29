using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions
{
    public static class Vector3Extensions
    {
        public static Vector3 SetX(this Vector3 vector3, float x)
        {
            vector3.x = x;
            return vector3;
        }

        public static Vector3 SetY(this Vector3 vector3, float y)
        {
            vector3.y = y;
            return vector3;
        }

        public static Vector3 SetZ(this Vector3 vector3, float z)
        {
            vector3.z = z;
            return vector3;
        }
    }
}
