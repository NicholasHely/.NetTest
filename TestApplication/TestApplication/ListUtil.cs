using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    static class ListUtil
    {
        // This static util class is providing an extension method
        // quite useful that you can do this
        // in theory I can now use this method within LINQ
        // (not with other providers though)

        /// <summary>
        /// Replaces an object in the list with the new object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="index"></param>
        /// <param name="item">The item to replace the old item</param>
        /// <returns>The old contact that has been replaced</returns>
        public static T Replace<T>(this IList<T> list, int index, T item)
        {
            T oldItem = list[index];

            if (list == null)
            {
                throw new ArgumentNullException("List cannot be null");
            }

            if (item == null)
            {
                throw new ArgumentNullException("Item cannot be null");
            }

            if (index < 0 || index >= list.Count)
            {
                throw new IndexOutOfRangeException(
                    string.Format("The index {0} is out of range of the list", 
                    index)
                    );
            }

            list[index] = item;

            return oldItem;
            // it now occurs to me, that this method is kind of rendundant
            // java there was no simple way to replace something
            // in a list
            // ah well, good practice for extension methods
        }
    }
}
