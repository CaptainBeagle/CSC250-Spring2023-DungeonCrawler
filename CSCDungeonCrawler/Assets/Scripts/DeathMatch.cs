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
    private Rigidbody swordR;
    private Rigidbody shieldR;

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }

    public IEnumerator fight()
    {
        while(dude1.hp > 0 && dude2.hp > 0)
        {
            yield return new WaitForSeconds(0.5f);
            this.battle(dude1, dude2);
            if(dude1.hp <= 0)
            {
                break;
            }
            if(dude2.hp<= 0)
            {
                break;
            }
            yield return new WaitForSeconds(0.5f);
            this.battle(dude2, dude1);
        }
        if(dude1.hp <= 0)
        {
            Debug.Log("You Lost. Please Restart Game.");
        }
        else
        {
            Debug.Log("You Won!");
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("DungeonRoom");
        }
    }

    public void battle(Inhabitant sword, Inhabitant shield)
    {
        if(sword == dude1)
        {
            this.swordR = dude1GO.GetComponent<Rigidbody>();
            this.shieldR = dude2GO.GetComponent<Rigidbody>();
        }
        else
        {
            this.swordR = dude2GO.GetComponent<Rigidbody>();
            this.shieldR = dude1GO.GetComponent<Rigidbody>();
        }
        //see fight in console because text mesh pro is not working for me
        
        string a = sword.getName();
        string b = shield.getName();            
        if(shield.getInfo("ac") < Random.Range(9, 20))
        {
            shield.hp -= sword.damage;
            Refcon.Broadcast(a, b);
        }
    }
}
