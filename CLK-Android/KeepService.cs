using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;
using System.Net;
using System.Text;
using System.Threading;
using KiwiLibrary;

namespace CLK {
	[Service]
	public class KeepSession : Service {
		// HTTP 통신에 사용 할 CookieAwareWebClient
		CookieAwareWebClient Web = new CookieAwareWebClient();

		// 주기적인 반복을 위해 사용할 Timer
		Timer timer;
		// Timer 간격 [20s]
		readonly int TimerWait = 20000;

		// CNSAnet Id를 저장할 변수
		string cnsaId;
		// CNSAnet Pw를 저장할 변수
		string cnsaPw;
		// Session 값을 저장할 변수
		string session;

		// 내부망 주소를 저장할 변수
		string intraNetUrl;
		// 외부망 주소를 저장할 변수
		string extraNetUrl;

		// Notification ID
		readonly int notificationId = 339;

		// Service 시작 요청이 있을 때 실행
		public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId) {
			// Activity에서 전달받은 값 저장
			if (intent.GetStringExtra("cnsaId") != null)
				cnsaId = intent.GetStringExtra("cnsaId");
			if (intent.GetStringExtra("cnsaPw") != null)
				cnsaPw = intent.GetStringExtra("cnsaPw");
			if (intent.GetStringExtra("intraNetUrl") != null)
				intraNetUrl = intent.GetStringExtra("intraNetUrl");
			if (intent.GetStringExtra("extraNetUrl") != null)
				extraNetUrl = intent.GetStringExtra("extraNetUrl");
			if (intent.GetStringExtra("session").Trim() != null)
				session = intent.GetStringExtra("session");

			// Timer가 존재 할 경우 제거
			if (timer != null)
				timer.Dispose();
			// Create Timer
			timer = new Timer(SessionUpdate, DateTime.UtcNow, 0, TimerWait);

			// Notification Setting
			Intent mainIntent = new Intent(this, typeof(MainActivity));
			mainIntent.AddFlags(ActivityFlags.ClearTop);
			var pendingIntent = PendingIntent.GetActivity(this, 0, mainIntent, PendingIntentFlags.CancelCurrent);

			Notification.Builder builder = new Notification.Builder(this)
				.SetContentTitle("CNSA Login Keeper")
				.SetContentText("CNSA Login Keeper is running")
				.SetSmallIcon(Resource.Drawable.CNSAIdentifire)
				.SetContentIntent(pendingIntent);
			// Build the notification
			Notification notification = builder.Build();
			
			// Get the notification manager
			var notificationManager = NotificationManager.FromContext(this);
			// Publish the notification
			notificationManager.Notify(notificationId, notification);

			// Toast 띄움
			Toast.MakeText(this, "Start CNSA Login Keeper", ToastLength.Long).Show();

			// App이 종료된 후 Service 실행 여부
			return StartCommandResult.RedeliverIntent;
		}

		// Service가 종료 될 때 실행
		public override void OnDestroy() {
			// timer 종료
			timer.Dispose();
			// timer 제거
			timer = null;

			// Notification Setting
			Intent mainIntent = new Intent(this, typeof(MainActivity));
			mainIntent.AddFlags(ActivityFlags.ClearTop);
			var pendingIntent = PendingIntent.GetActivity(this, 0, mainIntent, PendingIntentFlags.CancelCurrent);

			Notification.Builder builder = new Notification.Builder(this)
				.SetContentTitle("CNSA Login Keeper")
				.SetContentText("CNSA Login Keeper is stop")
				.SetSmallIcon(Resource.Drawable.CNSAIdentifire)
				.SetContentIntent(pendingIntent);
			// Build the notification
			Notification notification = builder.Build();

			// Get the notification manager
			var notificationManager = NotificationManager.FromContext(this);
			// Publish the notification
			notificationManager.Notify(notificationId, notification);

			// Toast 띄움
			Toast.MakeText(this, "Stop CNSA Login Keeper", ToastLength.Long).Show();

			// Background Service 종료
			base.OnDestroy();
		}

		// Session 유지를 위해 실행될 타이머 코드
		void SessionUpdate(object state) {
			try {
				// CNSA net에서 저장된 Session 받아오기
				string nowSession = Encoding.UTF8.GetString(Web.DownloadData(extraNetUrl + "/login/dupLoginCheck?loginId=" + cnsaId));

				// Session이 저장된 세션과 다르고 저장된 세션이 비어있지 않을 경우 -> 저장된 Session 교체
				if (!session.Equals(nowSession) && nowSession.Trim() != "") {
					// 저장된 Session 교체
					session = nowSession;

					// Session이 변경되었을 경우 알림
					new Handler(Looper.MainLooper).Post(new Java.Lang.Runnable(() => {
						Toast.MakeText(this, "Session이 변경되었습니다.", ToastLength.Long).Show();
					}));
				}

				// Session 초기화
				Web.CookieContainer = new CookieContainer();
				// Session 저장
				Web.AddCookie(new Uri(intraNetUrl), new Cookie("JSESSIONID", session));
				Web.AddCookie(new Uri(extraNetUrl), new Cookie("JSESSIONID", session));
				
				// 로그인을 통한 Session 갱신
				Web.UploadValues(extraNetUrl + "/login/userLogin", new System.Collections.Specialized.NameValueCollection() {
					{ "loginId", cnsaId },
					{ "loginPw", cnsaPw }
				});
			} catch (WebException webE) {	// WebException 발생 시 실행 [CNSAnet 연결 실패 포함]
				// Toast
				new Handler(Looper.MainLooper).Post(new Java.Lang.Runnable(() => {
					Toast.MakeText(this, "Session이 변경되었습니다.", ToastLength.Long).Show();
				}));
			}
		}

		// App과 통신을 하지 않기 때문에 Bind 함수는 사용 X (추상 메서드이기 때문에 사용하지 않아도 Override)
		public override IBinder OnBind(Intent intent) {
			return null;
		}
	}
}