using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{

    //マウスの座標
    public static Vector2 mousePos;
    Vector2 Rotate;
    
    float MaxRotate;
    float MinRotate;

    // Use this for initialization
    void Start()
    {
        Rotate = new Vector2(0,0);
        Cursor.lockState = CursorLockMode.Locked;
        MaxRotate = 90;
        MinRotate = -90;
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Input.mousePosition;
        mousePos = new Vector3(Input.GetAxis("Mouse X") * 5, Input.GetAxis("Mouse Y") * 5);

        Rotate += mousePos;

        if(MinRotate >= Rotate.y)
        {
            Rotate.y = MinRotate;
        }
        if (MaxRotate <= Rotate.y)
        {
            Rotate.y = MaxRotate;
        }

        this.transform.rotation = Quaternion.Euler(-Rotate.y, -Rotate.x, 0);
    }
}
