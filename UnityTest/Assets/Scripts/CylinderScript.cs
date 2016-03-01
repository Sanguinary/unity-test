using UnityEngine;
using System.Collections;

public class CylinderScript : MonoBehaviour {

    [SerializeField]
    public int aValue;
    public bool aBool;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    transform.position = new Vector3 (
            Mathf.PingPong(Time.time*2, 3), Mathf.PingPong(Time.time, 3), transform.position.z);
    }
}
