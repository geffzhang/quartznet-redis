using System;

namespace Quartz.Impl.Redis
{
	internal static class Constants
	{
		/*** Sets Keys ***/
		public static String JOBS_SET = "jobs";
		public static String JOB_GROUPS_SET = "job_groups";
		public static String BLOCKED_JOBS_SET = "blocked_jobs";
		public static String TRIGGERS_SET = "triggers";
		public static String TRIGGER_GROUPS_SET = "trigger_groups";
		public static String CALENDARS_SET = "calendars";
		public static String PAUSED_TRIGGER_GROUPS_SET = "paused__trigger_groups";
		public static String PAUSED_JOB_GROUPS_SET = "paused_job_groups";

		/*** Job Hash Fields ***/
		public static String JOB_CLASS = "job_class_name";
		public static String DESCRIPTION = "description";
		public static String IS_DURABLE = "is_durable";
		public static String BLOCKED_BY = "blocked_by";
		public static String BLOCK_TIME = "block_time";

		/*** Trigger Hash Fields ***/
		public static String JOB_HASH_KEY = "job_hash_key";
		public static String NEXT_FIRE_TIME = "next_fire_time";
		public static String PREV_FIRE_TIME = "prev_fire_time";
		public static String PRIORITY = "priority";
		public static String TRIGGER_TYPE = "trigger_type";
		public static String CALENDAR_NAME = "calendar_name";
		public static String START_TIME = "start_time";
		public static String END_TIME = "end_time";
		public static String _FIRE_TIME = "_fire_time";
		public static String FIRE_INSTANCE_ID = "fire_instance_id";
		public static String MISFIRE_INSTRUCTION = "misfire_instruction";
		public static String LOCKED_BY = "locked_by";
		public static String LOCK_TIME = "lock_time";

		/*** Simple Trigger Fields ***/
		public static String TRIGGER_TYPE_SIMPLE = "SIMPLE";
		public static String REPEAT_COUNT = "repeat_count";
		public static String REPEAT_INTERVAL = "repeat_interval";
		public static String TIMES_TRIGGERED = "times_triggered";

		/*** Cron Trigger Fields ***/
		public static String TRIGGER_TYPE_CRON = "CRON";
		public static String CRON_EXPRESSION = "cron_expression";
		public static String TIME_ZONE_ID = "time_zone_id";

		/*** Calendar Hash Fields ***/
		public static String CALENDAR_CLASS = "calendar_class";
		public static String CALENDAR_SERIALIZED = "calendar_serialized";

		/*** Misc Keys ***/
		public static String LAST_TRIGGERS_RELEASE_TIME = "last_triggers_release_time";
		public static String LOCK = "lock";

		/*** Channels ***/
		public static String UNLOCK_NOTIFICATIONS_CHANNEL = "unlock-notificactions";
	}
}