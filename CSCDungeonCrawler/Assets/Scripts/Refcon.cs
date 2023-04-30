using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refcon : MonoBehaviour
{
    public GameObject MonsterGO;
    public GameObject PlayerGO;
    private Monster theMonster;
    private DeathMatch theMatch;

    void Start()
    {
        this.theMonster = new Monster("ROUS");
        print(this.theMonster.getData());
        print(MasterData.p.getData());
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster, this.PlayerGO, this.MonsterGO);
        this.theMatch.fight();
    }

    
    public static void Broadcast(string dude1Name, string dude2Name)
    {
        print(dude1Name + " attacks " + dude2Name);
    }
}
