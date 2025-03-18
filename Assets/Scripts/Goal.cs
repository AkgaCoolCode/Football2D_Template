using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    [SerializeField] private TMP_Text Enemyscoretext;

      

    private int Enemyscore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.TryGetComponent(out Football ball))
        {
            ball.Reset();
            Enemyscore = Enemyscore + 1;
            Enemyscoretext.text = Enemyscore.ToString();
        }

    }






}
