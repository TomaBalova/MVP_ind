using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_ind
{
    public interface IView
    {
        int razmer { get; set; }
        double[,] inputMatrixA { get;}
        double[,] inputMatrixB { get;}
        /*double[,] inputMatrixRez { get; set; }
        double multA { get; set; }
        double multB { get; set; }*/
        double sumA { get; set; }
        double sumB { get; set; }
}
}
