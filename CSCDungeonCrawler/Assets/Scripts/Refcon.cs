using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Refcon : MonoBehaviour
{
    public GameObject MonsterGO;
    public GameObject PlayerGO;
    public TextMeshPro monsterSB;
    public TextMeshPro PlayerSB;
    private Monster theMonster;
    private DeathMatch theMatch;

    void Start()
    {
        this.theMonster = new Monster("ROUSE");
        this.monsterSB.text = this.theMonster.getData();
        this.PlayerSB.text = MasterData.p.getData();
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster, this.PlayerGO, this.MonsterGO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
