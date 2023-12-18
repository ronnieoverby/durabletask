namespace TestProject1;

using DurableTask.Core;
using DurableTask.Nats;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        var taskService = new NatsOrchestrationService();

        using var worker = new TaskHubWorker(taskService);
        worker.AddTaskOrchestrations(typeof(MyOrchestration));
        worker.AddTaskActivities(typeof(IncrementActivity));	
	
        var client = new TaskHubClient(taskService);
        var instance = client.CreateOrchestrationInstanceAsync(typeof(MyOrchestration),1);
	
        await worker.StartAsync();

        await Task.Delay(3333);

        await worker.StopAsync();
    }
}


class MyOrchestration : TaskOrchestration<int, int>
{
	public override async Task<int> RunTask(OrchestrationContext context, int input)
	{
		return await context.ScheduleTask<int>(typeof(IncrementActivity), input);
	}
}


class IncrementActivity : TaskActivity<int, int>
{
	protected override int Execute(TaskContext context, int input) => input + 1;
}