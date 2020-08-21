using UnityEngine;

public class IncreaseSpeedOfFigures : MonoBehaviour
{
    private bool _timeToUpdateSpeed;
    private void Update()
    {
        GameConst.TimePast += Time.deltaTime;
        if (GameConst.TimePast >GameConst.SpeedIncreaseInterval)
        {
            _timeToUpdateSpeed = true;
            GameConst.TimePast = 0;
        }

        if(_timeToUpdateSpeed)
        {
            UpdateSpeed();
        }
    }

    void UpdateSpeed()
    {
        GameConst.Speed/= GameConst.IncreaseSpeedAmount;
        _timeToUpdateSpeed = false;
    }
}
