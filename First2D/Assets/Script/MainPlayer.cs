using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class MainPlayer : MonoBehaviour
    {
        [HideInInspector]   // 特性:在属性菜单中隐藏
        public float strength;

        public string myNName;
        private string notShowName;
        public float distancePerFrame;

        // Start is called before the first frame update
        void Start() {
            Debug.Log("I am alive and my name is " + myNName);

            Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

            if (rigidBody == null) {
                Debug.Log("rigidBody is null");
                return;
            }
            Debug.Log("rigidBody is not null");

            // 改变对象的刚体质量。
            rigidBody.mass = 1f;

            // 向刚体添加作用力。
            //rigidBody.AddForce(Vector2.up * 200f);
        }

        // Update is called once per frame
        void Update() { // 时间步长是变化的
                        //Time.deltaTime 获取当前帧时间,是的每个时间内帧率虽然不同,但移动距离相同
            transform.Translate(distancePerFrame * Time.deltaTime, 0, 0);
            //float distance = 10 * Time.deltaTime * Input.GetAxis("Horizontal");
            //transform.Translate(Vector2.right * distance);
        }

        void FixedUpdate() { // 时间步长是固定的,一般不需要修改
                             // Time.fixedDeltaTime 读取固定的时间步长
                             //Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

            //if (rigidBody == null) {
            //    return;
            //}

            //Vector2 force = transform.up * 100 * Input.GetAxis("Vertical");
            //rigidBody.AddForce(force);
        }

        void LateUpdate() {
            Camera.main.transform.position = transform.position;

            //相机不动,镜头转向,不适用于2D.
            //Camera.main.transform.LookAt(target.transform);
        }

        void OnCollisionEnter2D(Collision2D collision) {
            Debug.Log("Collision2D Start:" + collision.transform);
            StartCoroutine("Fade");
        }
        void OnCollisionStay2D(Collision2D collision) {
            //Debug.Log("Collision2D Stay:" + collision.transform);
        }
        void OnCollisionExit2D(Collision2D collision) {
            Debug.Log("Collision2D Exit:" + collision.transform);
        }

        // 触发器的情况下调用以下事件
        void OnTriggerEnter2D(UnityEngine.Collider2D other) {
            Debug.Log("other.transform:" + other.transform);
        }
        void OnTriggerStay2D(UnityEngine.Collider2D other) {
            Debug.Log("other.transform:" + other.transform);
        }
        void OnTriggerExit2D(UnityEngine.Collider2D other) {
            Debug.Log("other.transform:" + other.transform);
        }

        IEnumerator Fade() {
            Renderer renderer = GetComponent<Renderer>();
            for (float f = renderer.material.color.a; f >= 0; f -= 0.1f) {
                Color c = renderer.material.color;
                c.a = f;
                renderer.material.color = c;
                // 每次帧开始时恢复
                //yield return null;
                // 经过0.1秒后恢复 减少调用可减少系统资源开销.
                yield return new WaitForSeconds(.1f);
            }
        }
    }
}
