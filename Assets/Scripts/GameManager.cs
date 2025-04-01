using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private Players playerLeft;
    [SerializeField] private Players playerRight;
    [SerializeField] private TMP_Text timerText;

    private int timer = 100;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        InvokeRepeating(nameof(CountDown), 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Goal()
    {
        playerLeft.Reset();
        playerRight.Reset();
    }


    private void CountDown()
    {
        timer--;
        if (timer <= 0)
        {
            SceneManager.LoadScene("EndGame");
        }
       
        timerText.text = Helpers.FormatTimer(timer);

    }
}
