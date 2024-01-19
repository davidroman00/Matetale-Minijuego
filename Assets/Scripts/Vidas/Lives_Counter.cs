using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives_Counter : MonoBehaviour
{
    public int Vidas = 3;
    private string currentSceneName;

    void Awake()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if (Vidas == 0)
        {
            SceneManager.LoadScene(currentSceneName);
        }
    }
    public void DecreaseLives()
    {
        Vidas--;
    }
}
