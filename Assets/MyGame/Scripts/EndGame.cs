using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text Score;
    protected float lastScore;
    float rResult = 0;
    public GameObject gameOverImage;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverImage = GameObject.FindGameObjectWithTag("gameOverImage");
        gameOverImage.SetActive(false);
        Score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.timeScale != 0)
        {
            lastScore = Time.time;
            var result = (Mathf.Round(lastScore * 100)) / 100;
            Score.text = result.ToString();
            rResult = result;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        gameOverImage.SetActive(true);
        Score.text = rResult.ToString();
        Time.timeScale = 0;
    }
}
