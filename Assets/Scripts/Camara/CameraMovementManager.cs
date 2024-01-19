using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementManager : MonoBehaviour
{
    private Vector3 camY;
    [SerializeField]
    private GameOperationController currentOp;
    void Update()
    {
        CameraPositions();
    }
    void CameraPositions()
    {
        switch (currentOp.currentOperation)
        {
            case 1:
                camY = new Vector3(0f, 5.38f, -10f);
                transform.position = camY;
                break;
            case 2:
                camY = new Vector3(0f, 8.17f, -10f);
                transform.position = camY;
                break;
            case 3:
                camY = new Vector3(0f, 10.67f, -10f);
                transform.position = camY;
                break;
            case 4:
                camY = new Vector3(0f, 12.53f, -10f);
                transform.position = camY;
                break;
            case 5:
                camY = new Vector3(0f, 14.65f, -10f);
                transform.position = camY;
                break;
            case 6:
                camY = new Vector3(0f, 16.23f, -10f);
                transform.position = camY;
                break;
        }
    }
}
