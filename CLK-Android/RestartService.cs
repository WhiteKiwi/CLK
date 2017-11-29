using Android.Content;

namespace CLK {
	// Service 재시작을 위한 Class
	public class RestartService : BroadcastReceiver {
		public override void OnReceive(Context context, Intent intent) {
			if (intent.Action.Equals("ACTION.RESTART.KeepService")) {
				Intent i = new Intent(context, typeof(KeepSession));
				context.StartService(i); 
			}

			if (intent.Action.Equals(Intent.ActionLockedBootCompleted)) {
			 Intent i = new Intent(context, typeof(KeepSession));
			 context.StartService(i);
			}
		}
	}
}