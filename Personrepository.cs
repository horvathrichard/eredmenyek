using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace datagrid2
{
    class EredmenyRepository
    {
        public string Path { get; set; }
        public char Delimiter { get; set; }
        public bool SkipHeader { get; set; }

        public List<Eredmeny> FindAll()
        {
            StreamReader r = new StreamReader(this.Path, true);
            if (this.SkipHeader) { r.ReadLine(); }

            List<Eredmeny> eredmenyListOutput = new List<Eredmeny> { };

            while (!r.EndOfStream)
            {
                eredmenyListOutput.Add(new Eredmeny(r.ReadLine()));
            }
            return eredmenyListOutput;
        }
    }
}
