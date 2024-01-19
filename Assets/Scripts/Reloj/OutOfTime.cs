using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OutOfTime : MonoBehaviour
{
    private string currentSceneName;

    void Awake()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
