using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Singleton<T> where T : new()
    {
        private static object _Mutex = new object();
        private static T instance = default(T);
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_Mutex)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }

                }

                return instance;
            }

        }

        protected Singleton()
        {
            Init();
            if (instance != null)
            {
                // throw new SingletonException(GetType() + "This Singleton is already exist ! Please not new again !!!");
            }
        }

        protected virtual void Init() { }
    }
}
