using UnityEngine;

public class DestroyOnEnd : MonoBehaviour
{
    void LateUpdate()
    {
        if(gameObject.transform.localPosition.z<GameConst.DestroyOnTheEndOfTarget)
            Destroy(gameObject);
    }
}
