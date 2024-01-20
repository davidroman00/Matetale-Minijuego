using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class GameOperationController : MonoBehaviour
{
    [SerializeField]
    private GameObject soluciones1;
    [SerializeField]
    private GameObject soluciones2;
    [SerializeField]
    private GameObject soluciones3;
    [SerializeField]
    private GameObject soluciones4;
    [SerializeField]
    private GameObject soluciones5;
    [SerializeField]
    private GameObject soluciones6;
    [SerializeField]
    private GameObject A;
    [SerializeField]
    private GameObject B;
    [SerializeField]
    private GameObject interrogante;
    public int currentOperation;
    private int operation;
    void Start()
    {
        interrogante.GetComponent<Button>().onClick.AddListener(SetOperationInt);
    }
    void Update()
    {
        OperationCases();
        ReactivateOptions();
    }
    void OperationCases()
    {
        switch (currentOperation)
        {
            case 1:
                soluciones1.SetActive(true);
                break;
            case 2:
                soluciones1.SetActive(false);
                soluciones2.SetActive(true);
                break;
            case 3:
                soluciones2.SetActive(false);
                soluciones3.SetActive(true);
                break;
            case 4:
                soluciones3.SetActive(false);
                soluciones4.SetActive(true);
                break;
            case 5:
                soluciones4.SetActive(false);
                soluciones5.SetActive(true);
                break;
            case 6:
                soluciones5.SetActive(false);
                soluciones6.SetActive(true);
                break;
            case 7:
                soluciones6.SetActive(false);
                break;
        }
    }
    private void SetOperationInt()
    {
        operation = currentOperation;
    }
    public void IncreaseCurrentOperation()
    {
        currentOperation++;
    }
    private bool CheckPressedHelp(int operation)
    {
        return operation != currentOperation;
    }
    private void ReactivateOptions()
    {
        if (CheckPressedHelp(operation))
        {
            A.SetActive(true);
            B.SetActive(true);
        }
    }
}
