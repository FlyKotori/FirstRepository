using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class TimeSpeed : MonoBehaviour
{
    public UnityEvent myEvent = new UnityEvent();

    void Start() {
        myEvent.AddListener(new UnityAction(Change));
    }

    public void Change() {
        Time.timeScale = 1 - Time.timeScale;
    }

    void Pause() {
        Time.timeScale = 0;
    }

    void Resume() {
        Time.timeScale = 1;
    }
}