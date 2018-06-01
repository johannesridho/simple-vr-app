using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private int SPEED = 20;
	
	void Start () {
		
	}
	
    void Update () {
        Vector2 touchAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad) * Time.deltaTime * SPEED;
        transform.position += new Vector3(touchAxis.x, 0, touchAxis.y);
	}
}
