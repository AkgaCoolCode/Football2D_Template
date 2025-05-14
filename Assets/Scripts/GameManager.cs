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
    [SerializeField] private GameObject endMenu;
    [SerializeField] private int timer = 100;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        InvokeRepeating(nameof(CountDown), 1, 1);
        timerText.text = Helpers.FormatTimer(timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Reset()
    {
        playerLeft.Reset();
        playerRight.Reset();
        Football.Instance.Reset();
    }


    private void CountDown()
    {
        if (timer <= 0)
        {
            endMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            timer--;
            timerText.text = Helpers.FormatTimer(timer);
        }
    }
}
