using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;// qua bong tiep theo
    float m_spawnTime;
    int m_score=0;
    bool m_isGameover;
    UIManager m_UI;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_UI = FindObjectOfType<UIManager>();
        m_UI.SetScoreTxt("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime; //giam den 0 or <0 thi them bong
        if(m_spawnTime <= 0)
        {
            SpawnBall();

            m_spawnTime =  spawnTime;
        }
    }
    public void SpawnBall()
    {
        if (m_isGameover==true) 
        {
            m_spawnTime=0;
            m_UI.ShowGameOverPanel(true);
            return;
        }
        Vector2 spawnPos = new Vector2(Random.Range(-8, 8), 6);
        if(ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity); // Quaternion.identity ko cho xuay cg ca
        }
    }
    public int Score { get => m_score; set => m_score=value; }
    public void IncrementScore()
    {
        m_score++;
        m_UI.SetScoreTxt("Score: " + m_score);
    }
    public bool IsGameover { get => m_isGameover; set => m_isGameover=value; }

    //
    public void Replay()
    {
        m_score = 0;
        m_isGameover = false;
        m_UI.SetScoreTxt("Score: " + m_score);
        m_UI.ShowGameOverPanel(false);
    }
}
