using UnityEngine;

public class RotateComponent : MonoBehaviour
{
    private Vector3 randomRotation;
    void Start()
    {
        float xSpin = Random.Range(0,360);
        float ySpin = Random.Range(0,360);
        float zSpin = Random.Range(0,360);
        randomRotation = new Vector3(xSpin, ySpin, zSpin);
    }

    void FixedUpdate()
    {
        transform.Rotate(randomRotation * Time.deltaTime/GameConst.RotationSpeed);
    }
}
