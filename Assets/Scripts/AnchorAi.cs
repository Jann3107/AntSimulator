using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnchorAi : MonoBehaviour
{
    private int spawned = 0;
    public Button anchorbutton;

    // Start is called before the first frame update
    void Start()
    {
        anchorbutton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        if(spawned <= 10)
        {
            spawnAnt();
        } else if(spawned > 10 && spawned <= 50)
        {
            for(int i = 0; i == 3; i++)
            {
                spawnAnt();
            }
        } else if (spawned > 50 && spawned <= 100)
        {
            for (int i = 0; i == 5; i++)
            {
                spawnAnt();
            }
        } else if (spawned > 100)
        {
            for (int i = 0; i == 10; i++)
            {
                spawnAnt();
            }
        } else {
            spawnAnt();
        }
        spawned++;
    }
    void spawnAnt()
    {
        GameObject prefab = GameObject.Find("Ant");
        Instantiate(prefab, transform.position, Quaternion.identity);
        prefab.SetActive(true);
    }
}
