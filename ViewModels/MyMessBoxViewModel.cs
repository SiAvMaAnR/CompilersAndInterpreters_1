using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilersAndInterpreters_1.ViewModels
{
    class MyMessBoxViewModel:BaseViewModel
    {
        private string message;

        public string Message
        {
            get { return message; }
            set 
            { 
                message = value;
                OnPropertyChanged(nameof(message));
            }
        }

    }
}
