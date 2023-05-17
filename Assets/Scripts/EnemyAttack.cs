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

        // ���䷽��
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
        // �Զ�����
        autofire();
    }
 
    void ballfire()
    {

        // ����һ���򲢷����ȥ
        GameObject v_ball = Instantiate(ball, bornPosition, Quaternion.identity);
    }
    void fireMethod1(GameObject v_ball, Vector3 fireDirection)
    {
        // ��ȡ�������
        Rigidbody v_rigidbody = v_ball.GetComponent<Rigidbody>();
        // ʩ��һ��Z�ᷴ�������
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



    // ������ķ���
    // ��ͨ��������
    void ballfiremethod1()
    {
        ballfire();
    }
    // һ�η���������
    void ballfiremethod2()
    {
        ballfire();
        ballfire();
        ballfire();
    }


}
