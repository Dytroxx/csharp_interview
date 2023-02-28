// 10 min
//
// Im nachfolgenden Code soll ein Service mit dem Namen PostMessage als Singleton
// registriert werden. Als Abstraktion soll eine Schnittstelle mit dem Namen IPostMessage 
// verwendet werden, deren Methoden von PostMessage implementiert werden.
// 
// Aufgabe: 
// 
// a) Schreibe eine Schnittstelle IPostMessage mit einer Methode 
//
//    public void Post(string message);
//
// b) Schreibe eine Klasse PostMessage welche IPostMessage implementiert
//    
// c) Registriere PostMessage mit der Schnittstelle IPostMessage als Singleton 
//    (ASP.Net Core IServiceCollection)
//
// d) Verwende die registrierte Schnittstelle IPostMessage per Dependency Injection 
//    im Controller: SampleController
// 
// e) Rufe die Methode PostMessage mit dem String "hello" auf, dies kann direkt im 
//    Konstruktor erfolgen
//
// ------------------------------------------------------------------------------
//
//  10 min
//
//  In the following code a service with the name PostMessage shall be registered as a singleton
//  As an abstraction an interface with the name IPostMessage shall be used
//  whose methods are implemented by PostMessage.
//  
//  Task: 
//  
//  a) Write an interface IPostMessage with one method 
// 
//     public void Post(string message);
// 
// b) Write a class PostMessage which implements IPostMessage
//     
//  c) Register PostMessage with the interface IPostMessage as a singleton
//     (ASP.Net Core IServiceCollection)
// 
//  d) Use the registered interface IPostMessage via Dependency Injection 
//     in the controller: SampleController
// 
//  e) Call the method PostMessage with the string "hello from inside SampleController
//     (e.g. constructor)
// 
// 
// 

 
var builder = WebApplication.CreateBuilder(args);

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
