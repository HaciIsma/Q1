using Q1.Service;
using Q1.View.Interfaces;
using System;
using System.Windows.Forms;

namespace Q1.Presenter
{
    class SignInSubPresenter
    {
        private readonly ISignInControl view;
        public SignInSubPresenter(ISignInControl view)
        {
            this.view = view;
            this.view.SignIn += View_SignIn;
            this.view.ClearClick += View_ClearClick;
        }

        private void View_ClearClick(object sender, EventArgs e)
        {
            view.User = new Model.User { };
        }

        private void View_SignIn(object sender, EventArgs e)
        {
            DBService dBService = new DBService();
            if (dBService.Search(x => x.Username == view.User.Username))
            {
                if (true)
                {
                    MessageBox.Show("Welcome");
                }
                else
                {
                    MessageBox.Show("Password Wrong");
                }
            }
            else
            {
                MessageBox.Show("Username Wrong");
            }
        }
    }
}
