using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // ��������
    public int enemyHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Health: " + enemyHealth);
            if(--enemyHealth == 0)
            {
                //Destroy(gameObject);
                gameObject.SetActive(false);
                enemyHealth = 5; // ��ʼ������
            }
            
        }
    }
}
