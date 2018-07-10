using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSerializationV1._0
{
    [Serializable]
    class Box
    {
        public string Name;
        public Box(string name)
        {
            this.Name = name;
        }
    }
}
