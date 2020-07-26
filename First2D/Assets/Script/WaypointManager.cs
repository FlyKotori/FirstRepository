using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    private Transform[] waypoints;

    // Start is called before the first frame update
    void Start() {
        waypoints = new Transform[transform.childCount];
        int i = 0;
        //Debug.Log("childCou:" + transform.childCount);

        foreach (Transform t in transform) {
            waypoints[i++] = t;
            //Debug.Log("child " + i + " :" + t.position);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
