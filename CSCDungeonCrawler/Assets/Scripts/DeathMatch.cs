using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMatch
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;
    private Rigidbody dude1R;
    private Rigidbody dude2R;

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }

    IEnumerator fight()
    {
        this.dude1R = dude1GO.GetComponent<Rigidbody>();
        this.dude2R = dude2GO.GetComponent<Rigidbody>();
        //see fight in console because text mesh pro is not working for me
        while(dude1.hp > 0 | dude2.hp > 0)
        {
            string a = dude1.getName();
            string b = dude2.getName();
                yield return new WaitForSeconds(0.5f);
                
                if(dude2.getInfo("ac") < Random.Range(9, 20))
                {
                    dude2.hp -= dude1.damage;
                    Refcon.Broadcast(a, b);
                }
                yield return new WaitForSeconds(0.5f);
                if(dude1.getInfo("ac") < Random.Range(9,20))
                {
                    dude1.hp -= dude2.damage;
                    Refcon.Broadcast(b, a);
                }
        }
        if(dude1.hp <= 0)
        {
            Debug.Log("You Lost. Please Restart Game.");
        }
        else
        {
            Debug.Log("You Won!");
            SceneManager.LoadScene("DungeonRoom");
        }
    }
}
