namespace Q1.View.Interfaces
{
    public interface IMainView
    {
        ISignUpControl SignUpControl { get; }
        ISignInControl SignInControl { get; }
    }
}
