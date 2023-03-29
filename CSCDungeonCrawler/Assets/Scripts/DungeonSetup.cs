using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject eastExit;
    public GameObject westExit;

    public bool northOn, southOn, eastOn, westOn;

    // Start is called before the first frame update
    void Start()
    {
        if (this.northOn == false)
        { 
            this.northExit.SetActive(false); 
        }
        else
        {
            this.northExit.SetActive(true);
        }

        if (this.southOn == false)
        {
            this.southExit.SetActive(false);
        }
        else
        {
            this.southExit.SetActive(true);
        }

        if (this.eastOn == false)
        {
            this.eastExit.SetActive(false);
        }
        else
        {
            this.eastExit.SetActive(true);
        }

        if (this.westOn == false)
        {
            this.westExit.SetActive(false);
        }
        else
        {
            this.westExit.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
