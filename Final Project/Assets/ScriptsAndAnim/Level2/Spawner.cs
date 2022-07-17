using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PriceObject;
    public GameObject SoapObject;

    void Spawn()
    {
        GameObject spawnObject;

        int choice = Random.Range(0, 2);

        if (choice == 1)

            spawnObject = PriceObject;
        else

            spawnObject = SoapObject;

        int newPosition = Random.Range(-1, 2);

        Vector3 Positionv = transform.position;

        Positionv.x = Positionv.x + (7 * newPosition);

        GameObject newSpawn = Instantiate(spawnObject, Positionv, Quaternion.identity);


    }

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", 2f, 2f);

    }
}
