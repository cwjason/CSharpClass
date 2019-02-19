using UnityEngine;
using System.Collections;

public class logDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("1111");

        Debug.Log("1111");
        Debug.LogWarning("1111");
        Debug.LogError("1111");

        //快捷注释ctl+k,ctl+c ,解开注释ctl+k, ctl + us

        //变量
        int hp = 100;
        int sp = 200;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
