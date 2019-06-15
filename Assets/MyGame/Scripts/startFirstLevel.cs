using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startFirstLevel : MonoBehaviour
{
    public Button Play;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Play.onClick.AddListener(startFLvl);
    }
    void startFLvl()
    {
        SceneManager.LoadScene("FirstLevel");
        Time.timeScale = 1;
    }
}
