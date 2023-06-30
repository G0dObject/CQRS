namespace CQRS.Command
{
	public interface ICommandHandler<in TRequest, TCommand> where TRequest : ICommand<TCommand>
	{
		public Task<TCommand> Handle(TRequest request);
	}
}