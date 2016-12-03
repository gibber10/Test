using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

    public float Speed;
	
	void Update () {
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * Speed, Space.Self);
	}
}
