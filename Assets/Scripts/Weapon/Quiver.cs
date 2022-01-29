using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Object
{
    public class Quiver : MonoBehaviour

    {
        private List<Dictionary<Arrow, int>> _Arrow = new List<Dictionary<Arrow, int>>();

        public List<string> GetArrowType()
        {
            List<string> arrowType = new List<string>();
            foreach (var dictionary in _Arrow)
            {
                if (dictionary != null)
                {
                    foreach (var arrow in dictionary)
                    {
                       arrowType.Add(dictionary.Keys.ToString());
                    }
                }
            }

            return arrowType;
        }
        public void SetArrowCount(string arrowType, int newCount)
        {
            foreach (var dictionary in _Arrow)
            {
                if (dictionary != null)
                {
                    foreach (var arrow in dictionary)
                    {
                        if (arrow.Key == arrowType)
                        {
                            dictionary[arrow.Key] = newCount;
                        }
                    }
                }
            }
        }
        public int GetArrowCount(string arrowType)
        { 
            int arrowCount = 0;
            foreach (var dictionary in _Arrow)
            {
                if (dictionary != null)
                {
                    foreach (var arrow in dictionary)
                    {
                        if (arrow.Key == arrowType)
                        {
                           arrowCount = dictionary[arrow.Key];
                        }
                    }
                }
            }

            return arrowCount;
        }
    }

}