using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton_info : MonoBehaviour
{
    [SerializeField]
    private Button info;
    [SerializeField]
    private GameObject UIToHide;
    [SerializeField]
    private GameObject UIToShow;
    [SerializeField]
    private GameObject OperationsToHide;
    void Start()
    {
        Button infoBtn = info.GetComponent<Button>();
        infoBtn.onClick.AddListener(ButtonModifyUI);
    }

    void ButtonModifyUI()
    {
        UIToHide.SetActive(false);
        UIToShow.SetActive(true);
        OperationsToHide.SetActive(false);
    }
}
