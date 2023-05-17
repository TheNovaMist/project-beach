using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject ball;
    private Vector3 bornPosition;
    public float forcePower;
    private float m_timer;
    public Vector3 v_ballDirection;
    // Start is called before the first frame update
    void Start()
    {
        GameObject mouth = GameObject.Find("Mouth");
        float x_ball = mouth.transform.position.x;
        float y_ball = mouth.transform.position.y;
        float z_ball = mouth.transform.position.z - 1;
        bornPosition = new Vector3(x_ball, y_ball, z_ball);

        // 发射方向
        v_ballDirection = new Vector3(0, 0, -1);

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("MouseDown");
        //    ballfire();

        //}
        // 自动发射
        autofire();
    }
 
    void ballfire()
    {

        // 创造一个球并发射出去
        GameObject v_ball = Instantiate(ball, bornPosition, Quaternion.identity);
    }
    void fireMethod1(GameObject v_ball, Vector3 fireDirection)
    {
        // 获取刚体组件
        Rigidbody v_rigidbody = v_ball.GetComponent<Rigidbody>();
        // 施加一个Z轴反方向的力
        v_rigidbody.AddForce(fireDirection * forcePower);
        Debug.Log("ok");

    }
    void fireMethod2(GameObject v_ball, Vector3 fireDirection)
    {
        float steep = forcePower * Time.deltaTime;
        v_ball.transform.position = Vector3.MoveTowards(v_ball.transform.position, fireDirection * forcePower, steep);
    }

    void autofire()
    {
        m_timer += Time.deltaTime;
        if (m_timer > 2)
        {
            ballfiremethod1();
            m_timer = 0;
        }
    }



    // 发射球的方法
    // 普通单个慢球
    void ballfiremethod1()
    {
        ballfire();
    }
    // 一次发射多个慢球
    void ballfiremethod2()
    {
        ballfire();
        ballfire();
        ballfire();
    }


}
