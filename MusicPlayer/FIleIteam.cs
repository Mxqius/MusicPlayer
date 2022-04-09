using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class FIleIteam
    {
        public string Fullname { get; set; }
        public FIleIteam(string file)
        {
            Fullname = file;
        }

        public override string ToString()
        {
            return Path.GetFileNameWithoutExtension(Fullname);
        }
    }
}
