using UnityEngine;

public class GameConst 
{
    public static float TimeToSpawn = 2;
    public static float TimePast = 0;
    public static float Speed =10;
    public static WaitForSeconds waitTime = new WaitForSeconds(1);

    public const float NextTimeToSpawn = 2;
    public const float RotationSpeed = 5;
    public const float SpeedIncreaseInterval=10;
    public const float IncreaseSpeedAmount=1.2f;
    public const float DestroyOnTheEndOfTarget=-1.7f;
    public const string StartText = "Start!";
}
