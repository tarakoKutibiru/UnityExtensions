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
    }
}
