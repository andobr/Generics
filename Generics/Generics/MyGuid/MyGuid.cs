using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    public class MyGuid
    {
        static Dictionary<Type, Dictionary<Guid, object>> typeDictionary = new Dictionary<Type, Dictionary<Guid, object>>();
         
        static public T CreateObjectWithGuid<T>() where T : new()
        {
            var obj = new T();
            var guid = Guid.NewGuid();
            var type = typeof(T);

            if (!typeDictionary.ContainsKey(type))
            {
                var guidDictionary = new Dictionary<Guid, object>();
                guidDictionary[guid] = obj;
                typeDictionary[type] = guidDictionary;
            }
            else
                typeDictionary[type][guid] = obj;
            return obj;
        }

        static public List<KeyValuePair<Guid, T>> GetAllPairsOfType<T>()
        {
            if (typeDictionary.ContainsKey(typeof(T)))
                return typeDictionary[typeof(T)].Select(x => new KeyValuePair<Guid, T>(x.Key, (T)x.Value)).ToList();
            return new List<KeyValuePair<Guid, T>>();
        }

        static public object GetObjectByGuid<T>(Guid guid)
        {
            return (typeDictionary.ContainsKey(typeof(T)) && typeDictionary[typeof(T)].ContainsKey(guid)) ? typeDictionary[typeof(T)][guid] : null;
        }
    }
}

