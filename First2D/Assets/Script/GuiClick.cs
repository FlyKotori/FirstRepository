using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GuiClick : MonoBehaviour
{
    public UnityAction action;
    public UnityEvent myEvent = new UnityEvent();

    // Start is called before the first frame update
    void Start() {
        action = new UnityAction(MyFunction);
        action += MyFunction2;
        myEvent.AddListener(action);
    }

    // Update is called once per frame
    void Update() {

    }

    void OnGUI() {
        //GUI.Label(new Rect(new Vector2(100,100),new Vector2(700,700)), "Game Over");
        GUI.Button(new Rect(200, 200, 100, 50), "第一个Button");
    }

    void OnMouseDown() {
        GUI.Label(new Rect(new Vector2(200, 200), new Vector2(700, 700)), "Game Over");
    }

    public void MyFunction() {
        Debug.Log("Hello: ");
    }

    public void MyFunction2() {
        Debug.Log("Hello2: ");
    }

}