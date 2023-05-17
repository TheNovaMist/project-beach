using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFire : MonoBehaviour
{
    // Start is called before the first frame update
    public float forcePower;
    private Rigidbody v_rigidbody;
    public Vector3 v_ballDirection;
    // ������� ÿ���򴴽��͹̶�����
    private float y_rotation;

    void Start()
    {
        v_ballDirection = new Vector3(0, 0, -1);
        // ��ȡ�������
        v_rigidbody = GetComponent<Rigidbody>();
        // ����Ƕ�
        y_rotation = Random.Range(-60, 60);

    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(y_rotation);
        Quaternion rotation = Quaternion.Euler(0, y_rotation, 0);
        Vector3 fireDirection = rotation * v_ballDirection;
        // ����
        float steep = forcePower * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, fireDirection * forcePower, steep);
    }
    void FixedUpdate()
    {
        //if (Input.GetButton("Fire1"))
        //{
        //    // ʩ��һ��Z�ᷴ�������
        //    v_rigidbody.AddForce(v_ballDirection * forcePower);
        //    Debug.Log("ok");
        //}
    }
}
