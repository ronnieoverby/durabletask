namespace DurableTask.Nats;

using DurableTask.Core;

public class NatsOrchestrationService : IOrchestrationService, IOrchestrationServiceClient
{
	public int TaskOrchestrationDispatcherCount => 1;

	public int MaxConcurrentTaskOrchestrationWorkItems => Environment.ProcessorCount;

	public BehaviorOnContinueAsNew EventBehaviourForContinueAsNew => throw new NotImplementedException();

	public int TaskActivityDispatcherCount => 1;

	public int MaxConcurrentTaskActivityWorkItems => Environment.ProcessorCount;

	public Task AbandonTaskActivityWorkItemAsync(TaskActivityWorkItem workItem)
	{
		throw new NotImplementedException();
	}

	public Task AbandonTaskOrchestrationWorkItemAsync(TaskOrchestrationWorkItem workItem)
	{
		throw new NotImplementedException();
	}

	public Task CompleteTaskActivityWorkItemAsync(TaskActivityWorkItem workItem, TaskMessage responseMessage)
	{
		throw new NotImplementedException();
	}

	public Task CompleteTaskOrchestrationWorkItemAsync(TaskOrchestrationWorkItem workItem, OrchestrationRuntimeState newOrchestrationRuntimeState, IList<TaskMessage> outboundMessages, IList<TaskMessage> orchestratorMessages, IList<TaskMessage> timerMessages, TaskMessage continuedAsNewMessage, OrchestrationState orchestrationState)
	{
		throw new NotImplementedException();
	}

	public Task CreateAsync()
	{
		throw new NotImplementedException();
	}

	public Task CreateAsync(bool recreateInstanceStore)
	{
		throw new NotImplementedException();
	}

	public Task CreateIfNotExistsAsync()
	{
		throw new NotImplementedException();
	}

	public Task CreateTaskOrchestrationAsync(TaskMessage creationMessage)
	{
		throw new NotImplementedException();
	}

	public Task CreateTaskOrchestrationAsync(TaskMessage creationMessage, OrchestrationStatus[] dedupeStatuses)
	{
		
		return Task.CompletedTask;
	}

	public Task DeleteAsync()
	{
		throw new NotImplementedException();
	}

	public Task DeleteAsync(bool deleteInstanceStore)
	{
		throw new NotImplementedException();
	}

	public Task ForceTerminateTaskOrchestrationAsync(string instanceId, string reason)
	{
		throw new NotImplementedException();
	}

	public int GetDelayInSecondsAfterOnFetchException(Exception exception)
	{
		throw new NotImplementedException();
	}

	public int GetDelayInSecondsAfterOnProcessException(Exception exception)
	{
		throw new NotImplementedException();
	}

	public Task<string> GetOrchestrationHistoryAsync(string instanceId, string executionId)
	{
		throw new NotImplementedException();
	}

	public Task<IList<OrchestrationState>> GetOrchestrationStateAsync(string instanceId, bool allExecutions)
	{
		throw new NotImplementedException();
	}

	public Task<OrchestrationState> GetOrchestrationStateAsync(string instanceId, string executionId)
	{
		throw new NotImplementedException();
	}

	public bool IsMaxMessageCountExceeded(int currentMessageCount, OrchestrationRuntimeState runtimeState)
	{
		throw new NotImplementedException();
	}

	public Task<TaskActivityWorkItem> LockNextTaskActivityWorkItem(TimeSpan receiveTimeout, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task<TaskOrchestrationWorkItem> LockNextTaskOrchestrationWorkItemAsync(TimeSpan receiveTimeout, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task PurgeOrchestrationHistoryAsync(DateTime thresholdDateTimeUtc, OrchestrationStateTimeRangeFilterType timeRangeFilterType)
	{
		throw new NotImplementedException();
	}

	public Task ReleaseTaskOrchestrationWorkItemAsync(TaskOrchestrationWorkItem workItem)
	{
		throw new NotImplementedException();
	}

	public Task<TaskActivityWorkItem> RenewTaskActivityWorkItemLockAsync(TaskActivityWorkItem workItem)
	{
		throw new NotImplementedException();
	}

	public Task RenewTaskOrchestrationWorkItemLockAsync(TaskOrchestrationWorkItem workItem)
	{
		throw new NotImplementedException();
	}

	public Task SendTaskOrchestrationMessageAsync(TaskMessage message)
	{
		throw new NotImplementedException();
	}

	public Task SendTaskOrchestrationMessageBatchAsync(params TaskMessage[] messages)
	{
		throw new NotImplementedException();
	}

	public async Task StartAsync()
	{
	}

	public Task StopAsync()
	{
		throw new NotImplementedException();
	}

	public Task StopAsync(bool isForced)
	{
		throw new NotImplementedException();
	}

	public Task<OrchestrationState> WaitForOrchestrationAsync(string instanceId, string executionId, TimeSpan timeout, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}