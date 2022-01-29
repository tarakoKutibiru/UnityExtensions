using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarakoKutibiru.UnityExtensions
{
    public static class TransformExtensions
    {
        public static Transform AddChild(this Transform transform, Transform child)
        {
            child.transform.parent = transform;
            return transform;
        }

        public static Transform SetPosition(this Transform transform, Vector3 position)
        {
            transform.position = position;
            return transform;
        }

        public static Transform SetLocalPosition(this Transform transform, Vector3 localPosition)
        {
            transform.localPosition = localPosition;
            return transform;
        }

        public static Transform SetRotation(this Transform transform, Quaternion rotation)
        {
            transform.rotation = rotation;
            return transform;
        }

        public static Transform SetLocalRotation(this Transform transform, Quaternion localRotation)
        {
            transform.localRotation = localRotation;
            return transform;
        }

        public static Transform SetLocalScale(this Transform transform, Vector3 localScale)
        {
            transform.localScale = localScale;
            return transform;
        }
    }
}
