// 
//
// Im nachfolgenden Code ist ein Problem enthalten, welches zu einem Programmabsturz
// führt. 
// 
// a) Erkläre warum die Applikation abstürzt und wie das Problem direkt und einfach behoben werden kann
// b) Welche weiteren Probleme verursacht die Funktion, in der die Exception geworfen wird
//    und warum sollte man diese Art Funktionen vermeiden 
// c) Korrigiere die Funktion, welche die Exception wirft, sodass 
//    die Exception abgefangen und ausgewertet werden kann
// 


AsyncExceptionHandling handling = new AsyncExceptionHandling();

Console.WriteLine("Run");

await handling.Run();
await Task.Delay(1000);	

Console.WriteLine("Completed");


public class AsyncException : SystemException
{
}


public class AsyncExceptionHandling
{
	public AsyncExceptionHandling()
	{

	}

	public Task Run()
	{
		try
		{
			ExecuteWithException();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);	
		}
		return Task.CompletedTask;
	}

	private async void ExecuteWithException()
	{
		for (int i = 0; i < 10; ++i)
		{
			if (i > 5) 
				throw new AsyncException();
		}
		await Task.Delay(1000);
	}
}