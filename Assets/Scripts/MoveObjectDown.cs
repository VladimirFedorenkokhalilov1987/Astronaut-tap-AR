using UnityEngine;

public class MoveObjectDown : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(-Vector3.forward*Time.deltaTime/GameConst.Speed);
    }
}
