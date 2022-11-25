using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour
{
    GameController m_gc;
    private void Start()
    {
        m_gc = FindObjectOfType<GameController>();// tim kiem doi tuong cung ieu
    }
    private void OnCollisionEnter2D(Collision2D collision) // vùng các ??i t??ng game va ch?m vs nhau
    {
        if (collision.gameObject.CompareTag("Player")) //CompareTag("") so sanhs xem chua tag do k
        {   
            Destroy(gameObject);
            m_gc.IncrementScore();
            //Debug.Log("aloo");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeathZone")) //CompareTag("") so sanhs xem chua tag do k
        {
            m_gc.IsGameover = true;
           // Debug.Log("alooaaaaa");
        }
    }
}
