using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions
{
    public static class Vector3Extensions
    {
        #region Set
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

        public static Vector3 Set(this Vector3 vector3, float scalar)
        {
            vector3.x = scalar;
            vector3.y = scalar;
            vector3.z = scalar;
            return vector3;
        }

        public static Vector3 Set(this Vector3 vector3, Vector3 other)
        {
            vector3.x = other.x;
            vector3.y = other.y;
            vector3.z = other.z;
            return vector3;
        }
        #endregion

        #region Add
        public static Vector3 AddX(this Vector3 vector3, float x)
        {
            vector3.x += x;
            return vector3;
        }

        public static Vector3 AddY(this Vector3 vector3, float y)
        {
            vector3.y += y;
            return vector3;
        }

        public static Vector3 AddZ(this Vector3 vector3, float z)
        {
            vector3.z += z;
            return vector3;
        }

        public static Vector3 Add(this Vector3 vector3, float scalar)
        {
            vector3.x += scalar;
            vector3.y += scalar;
            vector3.z += scalar;
            return vector3;
        }

        public static Vector3 Add(this Vector3 vector3, Vector3 other)
        {
            vector3 += other;
            return vector3;
        }
        #endregion

        #region Sub
        public static Vector3 SubX(this Vector3 vector3, float x)
        {
            vector3.x -= x;
            return vector3;
        }

        public static Vector3 SubY(this Vector3 vector3, float y)
        {
            vector3.y -= y;
            return vector3;
        }

        public static Vector3 SubZ(this Vector3 vector3, float z)
        {
            vector3.z -= z;
            return vector3;
        }

        public static Vector3 Sub(this Vector3 vector3, float scalar)
        {
            vector3.x -= scalar;
            vector3.y -= scalar;
            vector3.z -= scalar;
            return vector3;
        }

        public static Vector3 Sub(this Vector3 vector3, Vector3 other)
        {
            vector3 -= other;
            return vector3;
        }
        #endregion

        #region Multiply
        public static Vector3 MultiplyX(this Vector3 vector3, float x)
        {
            vector3.x *= x;
            return vector3;
        }

        public static Vector3 MultiplyY(this Vector3 vector3, float y)
        {
            vector3.y *= y;
            return vector3;
        }

        public static Vector3 MultiplyZ(this Vector3 vector3, float z)
        {
            vector3.z *= z;
            return vector3;
        }

        public static Vector3 Multiply(this Vector3 vector3, float scalar)
        {
            vector3 *= scalar;
            return vector3;
        }

        public static Vector3 Multiply(this Vector3 vector3, Vector3 other)
        {
            vector3.x *= other.x;
            vector3.y *= other.y;
            vector3.z *= other.z;
            return vector3;
        }
        #endregion

        #region Division
        public static Vector3 DivisionX(this Vector3 vector3, float x)
        {
            vector3.x /= x;
            return vector3;
        }

        public static Vector3 DivisionY(this Vector3 vector3, float y)
        {
            vector3.y /= y;
            return vector3;
        }

        public static Vector3 DivisionZ(this Vector3 vector3, float z)
        {
            vector3.z /= z;
            return vector3;
        }

        public static Vector3 Division(this Vector3 vector3, float scalar)
        {
            vector3 /= scalar;
            return vector3;
        }

        public static Vector3 Division(this Vector3 vector3, Vector3 other)
        {
            vector3.x /= other.x;
            vector3.y /= other.y;
            vector3.z /= other.z;
            return vector3;
        }
        #endregion

        public static float DotLhs(this Vector3 vector3, Vector3 lhs)
        {
            return Vector3.Dot(lhs, vector3);
        }

        public static float DotRhs(this Vector3 vector3, Vector3 rhs)
        {
            return Vector3.Dot(vector3, rhs);
        }

        public static Vector3 CrossLhs(this Vector3 vector3, Vector3 lhs)
        {
            return Vector3.Cross(lhs, vector3);
        }

        public static Vector3 CrossRhs(this Vector3 vector3, Vector3 rhs)
        {
            return Vector3.Cross(vector3, rhs);
        }

        public static ref Vector3 Zero(ref this Vector3 vector3)
        {
            vector3 = Vector3.zero;
            return ref vector3;
        }

        public static ref Vector3 One(ref this Vector3 vector3)
        {
            vector3 = Vector3.one;
            return ref vector3;
        }
    }
}
