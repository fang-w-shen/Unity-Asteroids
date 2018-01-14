using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject asteroid;
    public Vector3 spawnValues;
    public int hazardCount;
    public float delay;
    public float startDelay;
    public float waveWait;

    void Start()
    {
        StartCoroutine(spawnAsteroid());
    }


    IEnumerator spawnAsteroid()
    {
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            for (int i=0;i< hazardCount ;i++ )
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),spawnValues.y,spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(asteroid, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(delay);

            }
            yield return new WaitForSeconds(waveWait);

        }
    }
}
