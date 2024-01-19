using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton_skip : MonoBehaviour
{
    [SerializeField]
    private Button skip;
    [SerializeField]
    private GameObject UIToHide;
    [SerializeField]
    private GameObject UIToShow;
    [SerializeField]
    private GameObject OperationsToShow;
    void Start()
    {
        Button skipBtn = skip.GetComponent<Button>();
        skipBtn.onClick.AddListener(ButtonModifyUI);
    }

    void ButtonModifyUI()
    {
        UIToHide.SetActive(false);
        UIToShow.SetActive(true);
        OperationsToShow.SetActive(true);
    }
}
