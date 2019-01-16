using System;
using System.Collections.Generic;
using Microsoft.SmallBasic.Library;

namespace LitDev
{
    
    /// <summary>
    /// The hashtable provides a fast and efficient way of storing key-value pairs.
    /// Dictionaries have a O(1) scaling and as data size increases the efficiency.
    /// </summary>
    [SmallBasicType]
    public static class LDHashTable
    {
        public static Dictionary<string, Dictionary<Primitive, Primitive>> map 
            = new Dictionary<string, Dictionary<Primitive, Primitive>>();

        /// <summary>
        /// Adds a key-value pair to a specified dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">The key to add</param>
        /// <param name="value">The value to add</param>
        /// <returns>The number of items in the dictionary or -1 on failure.</returns>
        public static Primitive Add(Primitive dictionary, Primitive key, Primitive value)
        {
            Dictionary<Primitive, Primitive> data;

            if (!map.TryGetValue(dictionary, out data))
            {
                data = new Dictionary<Primitive, Primitive>();
                map[dictionary] = data;
            }

            data.Add(key, value);
            return data.Count;
        }

        /// <summary>
        /// Removes a key-value pair from a specified dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">They key to remove</param>
        /// <returns>The number of items in the dictionary or -1 on failure.</returns>
        public static Primitive Remove(Primitive dictionary, Primitive key)
        {
            try
            {
                Dictionary<Primitive, Primitive> data;
                if (map.TryGetValue(dictionary, out data))
                {
                    if (data.ContainsKey(key)) data.Remove(key);
                    return data.Count;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            return -1;
        }

        /// <summary>
        /// Removes all key-value pairs from a dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <returns>The number of items in the dictionary or -1 on failure.</returns>
        public static Primitive Clear(Primitive dictionary)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                data.Clear();
                return data.Count;
            }

            return -1;
        }

        /// <summary>
        /// Tells you if the specified dictionary
        /// contains a given key.
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">They key to lookup</param>
        /// <returns>"True" or "False"</returns>
        public static Primitive ContainsKey(Primitive dictionary, Primitive key)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                return data.ContainsKey(key) ? "True" : "False";
            }

            return "False";
        }

        /// <summary>
        /// Tells you if the specified dictionary
        /// contains a given key.
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="value">They value to lookup</param>
        /// <returns>"True" or "False"</returns>
        public static Primitive ContainsValue(Primitive dictionary, Primitive value)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                return data.ContainsValue(value) ? "True" : "False";
            }

            return "False";
        }

        /// <summary>
        /// Retrieves a value given a specified key from the
        /// specified dictionary
        /// </summary>
        /// <param name="dictionary">The name of the dictionary</param>
        /// <param name="key">The key to lookup</param>
        /// <returns>The value in the key-value pair or "" on failure.</returns>
        public static Primitive GetValue(Primitive dictionary, Primitive key)
        {
            Dictionary<Primitive, Primitive> data;
            if (map.TryGetValue(dictionary, out data))
            {
                if (data.ContainsKey(key)) return data[key];
            }

            return "";
        }
    }
}
