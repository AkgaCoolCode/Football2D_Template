using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net.NetworkInformation;

public class Goal : MonoBehaviour
{
    [SerializeField] private TMP_Text Enemyscoretext;
    [SerializeField] private GameObject goalText;
    private bool canScore = true;                 

    private int Enemyscore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.TryGetComponent(out Football ball))
        {
            CancelInvoke(nameof(Reset));
            canScore = false;
            goalText.SetActive(true);
            Enemyscore = Enemyscore + 1;
            Enemyscoretext.text = Enemyscore.ToString();
            Invoke(nameof(Reset),2);
        }

    }

    private void Reset()
    {
        canScore = true;
        goalText.SetActive(false);
        GameManager.Instance.Reset();
    }
}
