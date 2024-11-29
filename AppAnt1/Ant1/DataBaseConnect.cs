using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAnt1.Ant1
{
    internal class DataBaseConnect
    {
        internal static object cone;

        public static AntiqueStoreEntities AntiqueStore { get; } = new AntiqueStoreEntities();
    }
}
