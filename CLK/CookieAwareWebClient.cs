using System;
using System.Net;

namespace KiwiLibrary {
	public class CookieAwareWebClient : WebClient {
		public CookieContainer CookieContainer {
			get; set;
		}
		public Uri Uri {
			get; set;
		}

		//기본 생성자
		public CookieAwareWebClient() : this(new CookieContainer()) { }

		//CookieContainer를 매개변수로 받는 생성자
		public CookieAwareWebClient(CookieContainer cookies) {
			this.CookieContainer = cookies;
		}

		//Uri, Cookie를 매개변수로 받는 생성자
		public CookieAwareWebClient(Uri uri, Cookie cookie) : this(new CookieContainer()) {
			this.CookieContainer.Add(uri, cookie);
		}

		protected override WebRequest GetWebRequest(Uri address) {
			//WebRequest 생성
			WebRequest request = base.GetWebRequest(address);

			//패킷 속성 설정
			if (request is HttpWebRequest) {
				//패킷 Cookie 쿠키 설정
				(request as HttpWebRequest).CookieContainer = this.CookieContainer;
				//Connect: Kepp-Alive 
				(request as HttpWebRequest).KeepAlive = true;
			}

			//HttpWebRequest.AutomaticDecompression 속성 설정 
			HttpWebRequest httpRequest = (HttpWebRequest)request;
			httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

			//https 인증서 설정
			//httpRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

			return httpRequest;
		}

		protected override WebResponse GetWebResponse(WebRequest request) {
			//WebResponse 생성
			WebResponse response = base.GetWebResponse(request);
			string setCookieHeader = response.Headers[HttpResponseHeader.SetCookie];

			if (setCookieHeader != null) {
				//'='을 기준으로 받아온 Cookie 정보 Split
				string[] cookieHeader = setCookieHeader.Split("=;".ToCharArray(), 3);

				//cookieHeader[0]: Cookie ID		cookieHeader[1]: Cookie Data
				Cookie cookie = new Cookie(cookieHeader[0], cookieHeader[1]);

				//받아온 Cookie 설정
				this.CookieContainer.Add(response.ResponseUri, cookie);
			}

			return response;
		}

		//CookieAwareWebClient Cookie 추가
		public void AddCookie(Uri uri, Cookie cookie) {
			this.CookieContainer.Add(uri, cookie);
		}
	}
}
