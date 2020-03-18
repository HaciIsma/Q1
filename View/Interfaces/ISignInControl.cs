using Q1.Model;
using System;

namespace Q1.View.Interfaces
{
    public interface ISignInControl
    {
        event EventHandler<EventArgs> SignIn;
        event EventHandler<EventArgs> ClearClick;
        User User { get; set; }
    }
}
