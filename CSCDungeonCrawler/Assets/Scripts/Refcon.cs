using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refcon : MonoBehaviour
{
    //public 
    //public
    //public 
    private Monster theMonster;
    private DeathMatch theMatch;

    void Start()
    {
        this.theMonster = new Monster("ROUSE");
        this.theMonster.getData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
