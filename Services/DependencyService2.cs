namespace dependency_injection_tutorial.Services
{
	public class DependencyService2
	{
		private readonly IOperationTransient _operationTransient;
		private readonly IOperationSingleton _operationSingleton;
		private readonly IOperationScoped _operationScoped;
		private readonly IOperationSingletonInstance _operationSingletonInstance;
		private readonly IEnumerable<IOperationSingletonInstance> _operationSingletonInstances;

		public DependencyService2(IOperationTransient operationTransient,
			IOperationSingleton operationSingleton,
			IOperationScoped operationScoped,
			IOperationSingletonInstance operationSingletonInstance,
			IEnumerable<IOperationSingletonInstance> operationSingletonInstances
			)
		{
			_operationTransient = operationTransient;
			_operationSingleton = operationSingleton;
			_operationScoped = operationScoped;
			_operationSingletonInstance = operationSingletonInstance;
			_operationSingletonInstances = operationSingletonInstances;
		}

		public void Write()
		{
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Form Dependency service 2");
			Console.WriteLine($"From transient: {_operationTransient.OperationId}");
			Console.WriteLine($"From scoped: {_operationScoped.OperationId}");
			Console.WriteLine($"From singleton: {_operationSingleton.OperationId}");
			Console.WriteLine($"From singleton instance: {_operationSingletonInstance.OperationId}");
			Console.WriteLine("When we have duplicates.....");
			foreach(var obj in _operationSingletonInstances)
			{
				Console.WriteLine($"{obj.OperationId}");
			}
		}
	}
}
