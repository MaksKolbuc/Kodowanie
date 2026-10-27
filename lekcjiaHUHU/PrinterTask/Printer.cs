using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterTask
{
    internal class Printer
    {
        private string name { get; set; }
        private int paperCount;
        public int PaperCount { get; set; }

        public Printer(string name, int paperCount)
        {
            this.name = name;
            PaperCount = this.paperCount;
        }
    }
}
