using System;
using System.Collections.Generic;
using System.Configuration;
using Quartz.Impl.Matchers;
using Quartz.Spi;
using ServiceStack.Redis;

namespace Quartz.Impl.Redis
{
	public class RedisJobStore : IJobStore
	{
		private ITypeLoadHelper loadHelper;
		private PooledRedisClientManager redisClientManager;
		private ISchedulerSignaler signaler;
		private String instanceIdFilePath;

		public RedisJobStore()
		{
			var connectionString = ConfigurationManager.ConnectionStrings["quartznet-redis"] != null
				? ConfigurationManager.ConnectionStrings["quartznet-redis"].ConnectionString
				: DefaultConnectionString;

			if (string.IsNullOrWhiteSpace(connectionString))
			{
				throw new ApplicationException("Connection string is missing for the Redis job store.");
			}

			redisClientManager = new PooledRedisClientManager(connectionString);
		}

		public static string DefaultConnectionString { get; set; }

		public void Initialize(ITypeLoadHelper loadHelper, ISchedulerSignaler signaler)
		{
			this.loadHelper = loadHelper;
			this.signaler = signaler;
		}

		/// <summary>
		/// Called by the QuartzScheduler to inform the <see cref="IJobStore" /> that
		/// the scheduler has started.
		/// </summary>
		public void SchedulerStarted()
		{
			// nothing to do
		}

		/// <summary>
		/// Called by the QuartzScheduler to inform the JobStore that
		/// the scheduler has been paused.
		/// </summary>
		public void SchedulerPaused()
		{
			throw new NotImplementedException();
		}

		public void SchedulerResumed()
		{
			throw new NotImplementedException();
		}

		public void Shutdown()
		{
			throw new NotImplementedException();
		}

		public void StoreJobAndTrigger(IJobDetail newJob, IOperableTrigger newTrigger)
		{
			throw new NotImplementedException();
		}

		public bool IsJobGroupPaused(string groupName)
		{
			throw new NotImplementedException();
		}

		public bool IsTriggerGroupPaused(string groupName)
		{
			throw new NotImplementedException();
		}

		public void StoreJob(IJobDetail newJob, bool replaceExisting)
		{
			throw new NotImplementedException();
		}

		public void StoreJobsAndTriggers(IDictionary<IJobDetail, Collection.ISet<ITrigger>> triggersAndJobs, bool replace)
		{
			throw new NotImplementedException();
		}

		public bool RemoveJob(JobKey jobKey)
		{
			throw new NotImplementedException();
		}

		public bool RemoveJobs(IList<JobKey> jobKeys)
		{
			throw new NotImplementedException();
		}

		public IJobDetail RetrieveJob(JobKey jobKey)
		{
			throw new NotImplementedException();
		}

		public void StoreTrigger(IOperableTrigger newTrigger, bool replaceExisting)
		{
			throw new NotImplementedException();
		}

		public bool RemoveTrigger(TriggerKey triggerKey)
		{
			throw new NotImplementedException();
		}

		public bool RemoveTriggers(IList<TriggerKey> triggerKeys)
		{
			throw new NotImplementedException();
		}

		public bool ReplaceTrigger(TriggerKey triggerKey, IOperableTrigger newTrigger)
		{
			throw new NotImplementedException();
		}

		public IOperableTrigger RetrieveTrigger(TriggerKey triggerKey)
		{
			throw new NotImplementedException();
		}

		public bool CalendarExists(string calName)
		{
			throw new NotImplementedException();
		}

		public bool CheckExists(JobKey jobKey)
		{
			throw new NotImplementedException();
		}

		public bool CheckExists(TriggerKey triggerKey)
		{
			throw new NotImplementedException();
		}

		public void ClearAllSchedulingData()
		{
			throw new NotImplementedException();
		}

		public void StoreCalendar(string name, ICalendar calendar, bool replaceExisting, bool updateTriggers)
		{
			throw new NotImplementedException();
		}

		public bool RemoveCalendar(string calName)
		{
			throw new NotImplementedException();
		}

		public ICalendar RetrieveCalendar(string calName)
		{
			throw new NotImplementedException();
		}

		public int GetNumberOfJobs()
		{
			throw new NotImplementedException();
		}

		public int GetNumberOfTriggers()
		{
			throw new NotImplementedException();
		}

		public int GetNumberOfCalendars()
		{
			throw new NotImplementedException();
		}

		public Collection.ISet<JobKey> GetJobKeys(GroupMatcher<JobKey> matcher)
		{
			throw new NotImplementedException();
		}

		public Collection.ISet<TriggerKey> GetTriggerKeys(GroupMatcher<TriggerKey> matcher)
		{
			throw new NotImplementedException();
		}

		public IList<string> GetJobGroupNames()
		{
			throw new NotImplementedException();
		}

		public IList<string> GetTriggerGroupNames()
		{
			throw new NotImplementedException();
		}

		public IList<string> GetCalendarNames()
		{
			throw new NotImplementedException();
		}

		public IList<IOperableTrigger> GetTriggersForJob(JobKey jobKey)
		{
			throw new NotImplementedException();
		}

		public TriggerState GetTriggerState(TriggerKey triggerKey)
		{
			throw new NotImplementedException();
		}

		public void PauseTrigger(TriggerKey triggerKey)
		{
			throw new NotImplementedException();
		}

		public Collection.ISet<string> PauseTriggers(GroupMatcher<TriggerKey> matcher)
		{
			throw new NotImplementedException();
		}

		public void PauseJob(JobKey jobKey)
		{
			throw new NotImplementedException();
		}

		public IList<string> PauseJobs(GroupMatcher<JobKey> matcher)
		{
			throw new NotImplementedException();
		}

		public void ResumeTrigger(TriggerKey triggerKey)
		{
			throw new NotImplementedException();
		}

		public IList<string> ResumeTriggers(GroupMatcher<TriggerKey> matcher)
		{
			throw new NotImplementedException();
		}

		public Collection.ISet<string> GetPausedTriggerGroups()
		{
			throw new NotImplementedException();
		}

		public void ResumeJob(JobKey jobKey)
		{
			throw new NotImplementedException();
		}

		public Collection.ISet<string> ResumeJobs(GroupMatcher<JobKey> matcher)
		{
			throw new NotImplementedException();
		}

		public void PauseAll()
		{
			throw new NotImplementedException();
		}

		public void ResumeAll()
		{
			throw new NotImplementedException();
		}

		public IList<IOperableTrigger> AcquireNextTriggers(DateTimeOffset noLaterThan, int maxCount, TimeSpan timeWindow)
		{
			throw new NotImplementedException();
		}

		public void ReleaseAcquiredTrigger(IOperableTrigger trigger)
		{
			throw new NotImplementedException();
		}

		public IList<TriggerFiredResult> TriggersFired(IList<IOperableTrigger> triggers)
		{
			throw new NotImplementedException();
		}

		public void TriggeredJobComplete(IOperableTrigger trigger, IJobDetail jobDetail, SchedulerInstruction triggerInstCode)
		{
			throw new NotImplementedException();
		}

		public bool SupportsPersistence
		{
			get { throw new NotImplementedException(); }
		}

		public long EstimatedTimeToReleaseAndAcquireTrigger
		{
			get { throw new NotImplementedException(); }
		}

		public bool Clustered
		{
			get { throw new NotImplementedException(); }
		}

		public string InstanceId
		{
			set { throw new NotImplementedException(); }
		}

		public string InstanceName
		{
			set { throw new NotImplementedException(); }
		}

		public int ThreadPoolSize
		{
			set { throw new NotImplementedException(); }
		}
	}
}