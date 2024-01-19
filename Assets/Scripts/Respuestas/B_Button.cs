using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Button : MonoBehaviour
{
    [SerializeField]
    private GameObject currentOperation;
    private GameOperationController gameCont;
    [SerializeField]
    private GameObject lives;
     void Start()
    {
        gameCont = currentOperation.GetComponent<GameOperationController>();
        Button BButton = GetComponent<Button>();
        BButton.onClick.AddListener(BButtonCases);
    }
    void BButtonCases()
    {
        switch (gameCont.currentOperation)
        {
            case 1:
                correct();
                break;
            case 2:
                incorrect();
                break;
            case 3:
                correct();
                break;
            case 4:
                incorrect();
                break;
            case 5:
                incorrect();
                break;
            case 6:
                correct();
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
