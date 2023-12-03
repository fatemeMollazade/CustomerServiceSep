namespace CustomerService.Framwork
{
    public interface ICommandhandler<TCommand> where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }
}
