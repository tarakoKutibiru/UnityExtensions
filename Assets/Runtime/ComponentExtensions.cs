using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace TarakoKutibiru.UnityExtensions
{
    public static class ComponentExtensions
    {
        public static T[] GetComponentsInChildrenWithoutSelf<T>(this Component self) where T : Component
        {
            return self.GetComponentsInChildren<T>().Where(c => self.gameObject != c.gameObject).ToArray();
        }
    }
}
