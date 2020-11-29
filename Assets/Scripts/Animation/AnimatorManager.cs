using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatorManager : MonoBehaviour
{
    public GameObject[] m_Animation = new GameObject[5];
    public float[] m_Time = new float[5];
    public int m_count = 0;
    public float auxTime;

    private void Start()
    {
        auxTime = 0;
        m_Animation[m_count].SetActive(true);
    }

    private void Update()
    {
        auxTime += Time.deltaTime;
        m_Animation[m_count].SetActive(true);
        if (auxTime < m_Time[m_count])
            return;
        auxTime = 0;
        m_Animation[m_count].SetActive(false);
        m_count++;
        if (m_count > 4)
        {
            Game();
        }
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
}
