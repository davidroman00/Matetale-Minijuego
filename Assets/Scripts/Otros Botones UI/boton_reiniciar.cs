using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class boton_reiniciar : MonoBehaviour
{
    private String currentSceneName;
    void Start()
    {
        Button infoBtn = GetComponent<Button>();
        infoBtn.onClick.AddListener(Restart);
        currentSceneName = SceneManager.GetActiveScene().name;

    }
    void Restart()
    {
        SceneManager.LoadScene(currentSceneName);

    }
}
