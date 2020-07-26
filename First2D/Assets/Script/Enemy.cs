using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public Transform playerTransform;
    public GameObject enemy;
    private GameObject[] array;

    // Start is called before the first frame update
    void Start() {
        // 在玩家角色背后十个单位的位置生成敌人。
        transform.position = player.transform.position + UnityEngine.Vector3.right * 40f;
        transform.localScale = playerTransform.localScale;
        Debug.Log("I am Enemy and my position is " + transform.position);
        array = new GameObject[5];
        for (int i = 0; i < 5; i++) {
            array[i] = Instantiate(enemy);
            array[i].transform.position = new Vector3(0, -30 - 4 * i, 0);
            // 如果enemy是不可用不可见的,则复制体同样不可用不可见.
            Debug.Log("array[i]:" +  array[i].transform.position);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
