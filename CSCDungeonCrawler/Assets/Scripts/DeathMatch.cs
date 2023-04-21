using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMatch : MonoBehaviour
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }

    public void fight()
    {
        //see fight in console because text mesh pro is not working for me
        
    }
}
