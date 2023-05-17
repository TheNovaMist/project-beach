using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBorn : MonoBehaviour
{
    public GameObject enemy_prefeb;
    // Start is called before the first frame update
    private static GameObject enemy;
    // Vector3 bornPointPosition;
    private float m_timer;
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        //enmey = GameObject.FindGameObjectWithTag("Enemy");
        //if (enmey == null)
        //{
        //    enemyBorn();
        //}
        m_timer += Time.deltaTime;
        //Debug.Log("m_timer " + m_timer);
        if (m_timer > 7)
        {
            if (enemy.activeSelf == false)
            {
                enemyBorn();
            }
            m_timer = 0;
        }
        void enemyBorn()
        {
            //enemy = Instantiate(enemy_prefeb, transform.position, Quaternion.identity);
            enemy.SetActive(true);
        }
    }
}
