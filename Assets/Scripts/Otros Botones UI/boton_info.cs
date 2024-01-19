using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton_info : MonoBehaviour
{
    [SerializeField]
    private GameObject UIToHide;
    [SerializeField]
    private GameObject UIToShow;
    [SerializeField]
    private GameObject OperationsToHide;
    [SerializeField]
    private Animator clock;
    void Start()
    {
        Button infoBtn = GetComponent<Button>();
        infoBtn.onClick.AddListener(ButtonModifyUI);
    }

    void ButtonModifyUI()
    {
        UIToHide.SetActive(false);
        UIToShow.SetActive(true);
        OperationsToHide.SetActive(false);
        clock.GetComponent<Animator>().speed = 0;
    }
}
