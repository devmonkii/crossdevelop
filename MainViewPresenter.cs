using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Android.Core
{
    public class MainViewPresenter
    {
        private IMainView _mainView;

        public MainViewPresenter(IMainView view)
        {
            _mainView = view;
        }


        public void HandleClick()
        {
            String value = _mainView.Temp;
            int ivalue = int.Parse(value);

            Reading reading = new Reading();
            reading.Temperature = ivalue;

            _mainView.Color = reading.Category;
        }
    }
}
