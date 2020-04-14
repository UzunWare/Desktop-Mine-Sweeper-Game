using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeper
{
    class Cell : Button
    {
        public int ri,ci;
        public bool isOpen;
        public int val;
        public Cell(int r,int c,int W,int H,int dim)
        {
            this.ri = r;
            this.ci = c;
            isOpen = false;
            this.val = 0;
            this.Width = W / dim - 8;
            this.Height = H / dim - 8;
        }

    }
}
