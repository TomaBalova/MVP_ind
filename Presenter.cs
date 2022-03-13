using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_ind
{
    class Presenter
    {
        private Model _model = new Model();
        private IView _view;
        public Presenter(IView view)
        {
            _view = view;
            //RefreshView();
        }
        public void RefreshViewSumElA()
        {
            _model.matrixA = _view.inputMatrixA;
            _model.razmerMat = _view.razmer;
            _view.sumA = _model.SumElA();
        }

        public void RefreshViewSumElB()
        {
            _model.matrixB = _view.inputMatrixB;
            _model.razmerMat = _view.razmer;
            _view.sumB = _model.SumElB();
        }
    }
}
