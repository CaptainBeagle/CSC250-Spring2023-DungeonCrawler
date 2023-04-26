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

    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }

    IEnumerator fight()
    {
        //see fight in console because text mesh pro is not working for me
        //It's not even appearing in the console. Why?
        //I think my logic makes sense.
        while(dude1.hp > 0 || dude2.hp > 0)
        {
            string a = dude1.getName();
            string b = dude2.getName();
            if(dude2.getInfo("ac") < Random.Range(9, 20))
            {
                dude2.hp -= dude1.damage;
                Refcon.Broadcast(a, b);
            }
            yield return new WaitForSeconds(1.0f);
            if(dude1.getInfo("ac") < Random.Range(9,20))
            {
                dude1.hp -= dude2.damage;
                Refcon.Broadcast(b, a);
            }
            yield return new WaitForSeconds(1.0f);
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
