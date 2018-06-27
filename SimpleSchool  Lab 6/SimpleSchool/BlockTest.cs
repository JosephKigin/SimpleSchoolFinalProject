using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class BlockTest
    {
        public BlockTest()
        {
            string output = "";
            //Sample blocks 1-5
            Block[] block ={ new Block(1, new DateTime (1, 1, 1, 8, 30, 0), new DateTime(1, 1, 1, 10, 20, 0)),
                       new Block(2, new DateTime (1, 1, 1, 10, 30, 0), new DateTime(1, 1, 1, 12, 20, 0)),
                       new Block(3, new DateTime (1, 1, 1, 12, 30, 0), new DateTime(1, 1, 1, 14, 20, 0)),
                       new Block(4, new DateTime (1, 1, 1, 14, 30, 0), new DateTime(1, 1, 1, 16, 20, 0)),
                       new Block(5, new DateTime (1, 1, 1, 18, 00, 0), new DateTime(1, 1, 1, 22, 00, 0))};

            //Output format
            for (int i = 0; i < block.Length; ++i)
                output += " " + block[i] + "\r\n";

        frmResultsDisplay theForm =
                            new frmResultsDisplay(output, "Block PD Test");
        theForm.ShowDialog();
        }
        

    }
}
