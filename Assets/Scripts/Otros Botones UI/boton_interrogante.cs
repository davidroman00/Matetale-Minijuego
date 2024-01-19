using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton_interrogante : MonoBehaviour
{
    [SerializeField]
    private GameObject A;
    [SerializeField]
    private GameObject B;
    [SerializeField]
    private GameOperationController currentOp;
    [SerializeField]
    private GameObject self;
    private Button interrogante;

    void Start()
    {
        interrogante = GetComponent<Button>();
        interrogante.onClick.AddListener(HelpCases);
    }
    void HelpCases()
    {
        switch (currentOp.currentOperation)
        {
            case 1:
                A.SetActive(false);
                break;
            case 2:
                B.SetActive(false);
                break;
            case 3:
                A.SetActive(false);
                break;
            case 4:
                B.SetActive(false);
                break;
            case 5:
                A.SetActive(false);
                break;
            case 6:
                A.SetActive(false);
                break;
        }
        interrogante.enabled = false;
        self.SetActive(false);
    }
}
