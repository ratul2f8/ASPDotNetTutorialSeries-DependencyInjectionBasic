public interface IOperation
{
	Guid OperationId { get; }
}

public interface IOperationTransient : IOperation
{

}

public interface IOperationScoped : IOperation
{

}

public interface IOperationSingleton : IOperation
{

}
public interface IOperationSingletonInstance : IOperation
{

}

public class Operation : IOperationTransient,
	IOperationScoped,
	IOperationSingleton,
	IOperationSingletonInstance
{
	public static int SomeParam;
	public Guid OperationId { get; private set; }
	public Operation(Guid id)
	{
		OperationId = id;
	}
	public Operation(): this(Guid.NewGuid())
	{

	}
}