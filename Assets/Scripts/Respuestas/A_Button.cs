using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A_Button : MonoBehaviour
{
    [SerializeField]
    private GameObject currentOperation;
    private GameOperationController gameCont;
    [SerializeField]
    private GameObject lives;

    void Start()
    {
        gameCont = currentOperation.GetComponent<GameOperationController>();
        Button AButton = GetComponent<Button>();
        AButton.onClick.AddListener(AButtonCases);
    }
    void AButtonCases()
    {
        switch (gameCont.currentOperation)
        {
            case 1:
                incorrect();
                break;
            case 2:
                correct();
                break;
            case 3:
                incorrect();
                break;
            case 4:
                incorrect();
                break;
            case 5:
                incorrect();
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
