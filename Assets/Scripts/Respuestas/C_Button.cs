using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_Button : MonoBehaviour
{
    [SerializeField]
    private GameObject currentOperation;
    private GameOperationController gameCont;
    [SerializeField]
    private GameObject lives;

    void Start()
    {
        gameCont = currentOperation.GetComponent<GameOperationController>();
        Button CButton = GetComponent<Button>();
        CButton.onClick.AddListener(CButtonCases);
    }
    void CButtonCases()
    {
        switch (gameCont.currentOperation)
        {
            case 1:
                incorrect();
                break;
            case 2:
                incorrect();
                break;
            case 3:
                incorrect();
                break;
            case 4:
                correct();
                break;
            case 5:
                correct();
                break;
            case 6:
                incorrect();
                break;
        }
    }
    void correct()
    {
        gameCont.IncreaseCurrentOperation();
    }
    void incorrect()
    {
        lives.GetComponent<Lives_Counter>().DecreaseLives();
    }
}
