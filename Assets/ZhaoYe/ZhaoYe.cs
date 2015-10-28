using UnityEngine;
using System.Collections;

public class ZhaoYe : MonoBehaviour {
	public Transform player;
	public  int x=1;
	public int y=2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = new Vector3 ();
		v -= player.forward * x;
		v +=  Vector3.up * y;
		Camera.main.transform.position = player.position + v;
		Vector3 eulerAngle = player.rotation.eulerAngles;
		eulerAngle.x = Mathf.Atan2 (y,x)*180f/Mathf.PI;
		Camera.main.transform.rotation = Quaternion.Euler (eulerAngle);
	}
}
