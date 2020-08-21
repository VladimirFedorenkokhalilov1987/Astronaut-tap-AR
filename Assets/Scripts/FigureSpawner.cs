using UnityEngine;
using Random = UnityEngine.Random;

public class FigureSpawner : MonoBehaviour
{
    public GameObject[] _spawnGameObject;

    private void FixedUpdate()
    {
        GameConst.TimeToSpawn-=Time.deltaTime;
        if (GameConst.TimeToSpawn<=0)
        { 
            Vector3 FigureStartPosition = new Vector3(Random.Range(-.5f,0.5f), 0.2f, 0.7f);
            GameConst.TimeToSpawn = GameConst.NextTimeToSpawn;
            Instantiate(_spawnGameObject[Random.Range(0,_spawnGameObject.Length)], FigureStartPosition, Quaternion.identity,transform);
        }
    }
}
