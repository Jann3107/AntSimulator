using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntSpawner : MonoBehaviour
{

    private int timehelper;
    private int spawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            spawnAnt();
        }
        timehelper = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (timehelper == 3000)
        {
            spawnAnt();
            timehelper = 0;
        }
        timehelper++;
    }
    void spawnAnt()
    {
        GameObject prefab = GameObject.Find("Ant");
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        prefab.SetActive(true);
        spawned++;
    }
}
