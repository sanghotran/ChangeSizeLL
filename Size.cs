using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeSizeLangLa
{
    public sealed class MySize : BinaryWriter
    {
        public MySize(FileStream fileStream) : base(fileStream) 
        { 
        }

        public void ChangeSize(short short_0)
        {
            byte value = (byte)(short_0 >> 8);
            byte value2 = (byte)(short_0 << 8 >> 8);
            base.Write(value);
            base.Write(value2);
        }
    }
}
