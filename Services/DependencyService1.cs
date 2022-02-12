namespace dependency_injection_tutorial.Services
{
    public class DependencyService1
    {
        private readonly IOperationTransient _operationTransient;
        private readonly IOperationSingleton _operationSingleton;
        private readonly IOperationScoped _operationScoped;
        private readonly IOperationSingletonInstance _operationSingletonInstance;

		public DependencyService1(IOperationTransient operationTransient,
			IOperationSingleton operationSingleton,
			IOperationScoped operationScoped,
			IOperationSingletonInstance operationSingletonInstance)
		{
			_operationTransient = operationTransient;
			_operationSingleton = operationSingleton;
			_operationScoped = operationScoped;
			_operationSingletonInstance = operationSingletonInstance;
		}

		public void Write()
		{
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Form Dependency service 1");
			Console.WriteLine($"From transient: {_operationTransient.OperationId}");
			Console.WriteLine($"From scoped: {_operationScoped.OperationId}");
			Console.WriteLine($"From singleton: {_operationSingleton.OperationId}");
			Console.WriteLine($"From singleton instance: {_operationSingletonInstance.OperationId}");
		}
	}
}
