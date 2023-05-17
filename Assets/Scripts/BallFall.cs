using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFall : MonoBehaviour
{
    // Start is called before the first frame update
    private bool fallToGround;
    private GameObject ground;
    private GameObject player;
    // 反击力度
    public float forcePower;
    // 基地
    private GameObject enemy;
    
    void Start()
    {
        
        ground = GameObject.Find("Ground");
        player = GameObject.Find("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);

        // 碰到玩家反弹 碰到地面和敌人销毁
        
        if (collision.gameObject == ground)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject == player)
        {
            
            ballback();
        }
        if (collision.gameObject == enemy)
        {
            Destroy(gameObject);
        }

    }
    void ballback()
    {
        Rigidbody ball = gameObject.GetComponent<Rigidbody>();
        //B到A的向量
        Vector3 backPosition = enemy.transform.position - gameObject.transform.position;
        //单位化（长度为1的向量）
        backPosition = backPosition.normalized;
        ball.velocity = new Vector3(0, 0, 0);
        ball.AddForce(backPosition * forcePower);
    }
}
