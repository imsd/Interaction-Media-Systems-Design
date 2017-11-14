using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twitter;

public class TweetSearch : MonoBehaviour {

	public string SearchQuery;
	 

	void Start() {

		// store authentication data up here
		Twitter.Oauth.consumerKey       = "9Ykl8xgQ64gleqLbHk701mH3e";
		Twitter.Oauth.consumerSecret    = "j5anOFiTTTOfdamxW4maMrx0FcpmJoDg4I1isVbO5Gxbi5aGb2";
		Twitter.Oauth.accessToken       = "928674799790051329-tyMqDdwjCGZEoIyEGquS1CsJYCEUz5Z";
		Twitter.Oauth.accessTokenSecret = "YOzzedSg40VlIuJNwUyM7AmPWgY4nR44s5kiIpxGC6vvj";

		Dictionary<string, string> parameters = new Dictionary<string, string>();

		// define your search query
		parameters ["q"] = SearchQuery;

		parameters ["count"] = 30.ToString();

		// sort of arbitrary code that initiates the twitter search,
		// and runs the Callback function when complete
		StartCoroutine (Client.Get ("search/tweets", parameters, Callback));
	}


	void Callback(bool success, string response) {
		if (success) {
			// if you successfully receive the twitter info,
			// execute this area
			SearchTweetsResponse Response = JsonUtility.FromJson<SearchTweetsResponse> (response);

			// statuses[0] returns the most recent tweet

			// anatomy of the JSON object that it returns
			Debug.Log(Response.statuses[0].text);
			Debug.Log(Response.statuses[0].user);
			Debug.Log(Response.statuses[0].created_at);

		} else {
			// if you dont successfully retrieve the info, execute this
			Debug.Log (response);
		}
	}
}
