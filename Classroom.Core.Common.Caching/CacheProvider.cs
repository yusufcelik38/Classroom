using Classroom.Core.Common.Contracts;
using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Caching;

namespace Classroom.Core.Common.Caching
{
    public class CacheProvider : ICacheProvider
    {
        private readonly MemoryCache _cache = MemoryCache.Default;
        public T Get<T>(string key)
        {
            //format istenildiği gibi olmazsa exception fırlatır!
            Contract.Assert(!string.IsNullOrEmpty(key));
            return (T)_cache.Get(key);

        }

        public bool IsExist(string key)
        {
            //format istenildiği gibi olmazsa exception fırlatır!
            Contract.Assert(!string.IsNullOrEmpty(key));
            return _cache.Any(x=>x.Key==key);
        }

        public void Remove(string key)
        {
            //format istenildiği gibi olmazsa exception fırlatır!
            Contract.Assert(!string.IsNullOrEmpty(key));
            _cache.Remove(key);
        }

        public void Set(string key, object value, int expireAsMinute)
        {
            //format istenildiği gibi olmazsa exception fırlatır!
            Contract.Assert(!string.IsNullOrEmpty(key));
            Contract.Assert(value!=null);
            Contract.Assert(expireAsMinute>0);


            if (IsExist(key))
            {
                Remove(key);

            }
            _cache.Add(key, value, DateTimeOffset.Now.AddMinutes(expireAsMinute));
        }
    }
}
