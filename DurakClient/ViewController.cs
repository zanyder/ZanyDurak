using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakLibrary;

namespace DurakClient
{
    public class ViewController
    {
        private static readonly Lazy<ViewController> settings =
            new Lazy<ViewController>(() => new ViewController());
        public static ViewController Instance
        {
            get
            { return settings.Value; }
        }

        private Form view;

        private ViewController() { }

        public void SetView(Form form)
        {
            this.view = form;
        }

        public void InitializeView(Form form) { }

        


    }
}
