using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject ballLight;
    private GameObject ball;
    private Rigidbody ballRb;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverCanvas");
        gameOverText.SetActive(false);
        ballLight = GameObject.Find("BallPointLight");
        ball = GameObject.Find("Ball");
        ballRb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if(gameOverText.activeSelf == true)
            {
                SceneManager.LoadScene(0);
            }
        }   
    }

    void OnCollisionEnter(Collision collision)
    {
        gameOverText.SetActive(true);
        ballLight.GetComponent<Light>().range = 0;
        ballRb.velocity = Vector3.zero;
    }
}
