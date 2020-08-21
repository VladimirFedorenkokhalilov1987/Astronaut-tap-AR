using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class RandomColor: MonoBehaviour
{
    private Color randomColor;
    void Start()
    {
        randomColor =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        GetComponent <MeshRenderer> ().material.color = randomColor;
    }
}
