using UnityEngine;
using UnityEngine.Networking;

public class WebRequestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string testurl = "https://example.com/test%2ffile";
		UnityWebRequest request = new UnityWebRequest();
		request.url = testurl;
		
		if (request.url == testurl)
			Debug.Log("request.url == testurl");
		else
		{
			Debug.LogError("request.url != testurl\nExpected \""+testurl+"\" but got \""+request.url+"\"");
		}
	}
}
