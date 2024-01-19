using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton_skip : MonoBehaviour
{
    [SerializeField]
    private GameObject UIToHide;
    [SerializeField]
    private GameObject UIToShow;
    [SerializeField]
    private GameObject operationsToShow;
    [SerializeField]
    private Animator clock;
    void Start()
    {
        Button skipBtn = GetComponent<Button>();
        skipBtn.onClick.AddListener(ButtonModifyUI);
    }

    void ButtonModifyUI()
    {
        UIToHide.SetActive(false);
        UIToShow.SetActive(true);
        operationsToShow.SetActive(true);
        clock.GetComponent<Animator>().speed = 1;
    }
}
