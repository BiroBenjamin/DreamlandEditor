﻿using System.Collections.Generic;

namespace DreamlandEditor.ExtensionClasses
{
  public static class ICollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> collection, ICollection<T> collectionToAdd)
        {
            foreach(T item in collectionToAdd)
            {
                collection.Add(item);
            }
        }
    }
}
