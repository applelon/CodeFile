using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.Framework.Entity;
using System.Reflection;

namespace Plugin.Framework.Utils
{
    public class InstanceLoader<T>
    {
        public static T GetInstance(Config cfg) {
            Assembly assembly = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory.ToString() + cfg.Dll);
            T instance = (T)assembly.CreateInstance(cfg.Class);
            return instance;
        }
    }
}
