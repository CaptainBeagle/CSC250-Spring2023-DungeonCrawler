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
        MasterData.setupDungeon();
        
        if(MasterData.id.Equals("e"))
        {
            this.northOn = true;
            this.southOn = false;
            this.eastOn = false;
            this.westOn = false;
        }
        if(MasterData.id.Equals("h1"))
        {
            this.northOn = true;
            this.southOn = true;
            this.eastOn = false;
            this.westOn = false;
        }
        if(MasterData.id.Equals("h2"))
        {
            this.northOn = false;
            this.southOn = true;
            this.eastOn = true;
            this.westOn = true;
        }
        if(MasterData.id.Equals("h3"))
        {
            this.northOn = false;
            this.southOn = false;
            this.eastOn = false;
            this.westOn = true;
        }
        if(MasterData.id.Equals("h4"))
        {
            this.northOn = false;
            this.southOn = false;
            this.eastOn = true;
            this.westOn = true;
        }
        if(MasterData.id.Equals("h5"))
        {
            this.northOn = true;
            this.southOn = false;
            this.eastOn = true;
            this.westOn = false;
        }
        if(MasterData.id.Equals("s118b"))
        {
            this.northOn = false;
            this.southOn = true;
            this.eastOn = false;
            this.westOn = false;
        }

        if (this.northOn == false)
        { 
            this.northExit.SetActive(false); 
            MasterData.nON = false;
        }
        else
        {
            this.northExit.SetActive(true);
            MasterData.nON = true;
        }

        if (this.southOn == false)
        {
            this.southExit.SetActive(false);
            MasterData.sON = false;
        }
        else
        {
            this.southExit.SetActive(true);
            MasterData.sON = true;
        }

        if (this.eastOn == false)
        {
            this.eastExit.SetActive(false);
            MasterData.eON = false;
        }
        else
        {
            this.eastExit.SetActive(true);
            MasterData.eON = true;
        }

        if (this.westOn == false)
        {
            this.westExit.SetActive(false);
            MasterData.wON = false;
        }
        else
        {
            this.westExit.SetActive(true);
            MasterData.wON = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
