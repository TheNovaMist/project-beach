using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject ScoreBoard;
    // Start is called before the first frame update
    private float playerScore;
    AudioSource v_audio;
    private string scoretext;
    TMPro.TextMeshProUGUI textmesh;
    void Start()
    {
        v_audio = GetComponent<AudioSource>();
        textmesh = ScoreBoard.GetComponent<TMPro.TextMeshProUGUI>();
        playerScore = 0.0f;
        scoretext = "Score : ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);

        
        if (collision.gameObject.tag == "Ball" )
        {
            // ≤•∑≈…˘“Ù
            v_audio.Play();
            // º”∑÷
            playerScore += 200;
            string score = scoretext + playerScore;
            textmesh.text = score;
        }

    }
}
