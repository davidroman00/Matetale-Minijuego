using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private Vector3 charPos;
    [SerializeField]
    private GameOperationController currentOp;

    void Update()
    {
        PlayerPositions();
    }
    void PlayerPositions()
    {
        switch (currentOp.currentOperation)
        {
            case 1:
                charPos = new Vector3(0f, 3.3f, 0f);
                transform.position = charPos;
                break;
            case 2:
                charPos = new Vector3(-0.099f, 6.366f, 0f);
                transform.position = charPos;
                break;
            case 3:
                charPos = new Vector3(-3.025f, 8.849f, 0f);
                transform.position = charPos;
                break;
            case 4:
                charPos = new Vector3(0.226f, 11.021f, 0f);
                transform.position = charPos;
                break;
            case 5:
                charPos = new Vector3(2.19f, 13.055f, 0f);
                transform.position = charPos;
                break;
            case 6:
                charPos = new Vector3(1.869f, 15.193f, 0f);
                transform.position = charPos;
                break;
            case 7:
                charPos = new Vector3(-0.8f, 16.319f, 0f);
                transform.position = charPos;
                break;
        }
    }
}
