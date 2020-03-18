using Q1.View.Interfaces;
using System.Windows.Forms;

namespace Q1.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public ISignUpControl SignUpControl => signUpControl;
        public ISignInControl SignInControl => signInControl;
    }
}
