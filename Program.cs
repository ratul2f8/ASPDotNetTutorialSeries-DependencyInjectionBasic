using dependency_injection_tutorial.Services;

var builder = WebApplication.CreateBuilder(args);


//add transient dependency
//if they are identicala the last one will take precendence
builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();
//identical - restart and comment out one strategy to see the changes
builder.Services.AddSingleton<IOperationSingletonInstance>(
	item => new Operation(Guid.Empty));
builder.Services.AddSingleton<IOperationSingletonInstance>(
	item => new Operation(Guid.NewGuid()));

//Use try add to change the precendence to take the first one only
//builder.Services.TryAddSingleton<IOperationSingletonInstance>(
//	item => new Operation(Guid.NewGuid()));
builder.Services.AddTransient<DependencyService1, DependencyService1>();
builder.Services.AddTransient<DependencyService2, DependencyService2>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
