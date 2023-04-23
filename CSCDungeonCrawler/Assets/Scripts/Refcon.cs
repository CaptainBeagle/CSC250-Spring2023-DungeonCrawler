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
        this.theMonster = new Monster("ROUSE");
        print(this.theMonster.getData());
        print(MasterData.p.getData());
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster, this.PlayerGO, this.MonsterGO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
