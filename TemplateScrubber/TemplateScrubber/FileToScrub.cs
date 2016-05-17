using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateScrubber
{
    class FileToScrub
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public override string ToString()
        {
            return FileName;
        }
    }
}
