using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        while(dude1.getInfo("hp") > 0 || dude2.getInfo("hp") > 0)
        {
            if(dude2.getInfo("ac") < Random.Range(9, 20))
            {
                dude2.hp -= dude1.damage;
            }
            
            if(dude1.getInfo("ac") < Random.Range(9,20))
            {
                dude1.hp -= dude2.damage;
            }
            
        }
        if(dude1.getInfo("hp") <= 0)
        {
            print("You Lost. Please Restart Game.");
        }
        else
        {
            print("You Won!");
            SceneManager.LoadScene("DungeonRoom");
        }
    }
}
