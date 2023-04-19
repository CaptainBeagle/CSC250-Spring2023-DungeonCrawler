using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inhabitant 
{
    protected int hp;
    protected int ac;
    protected int damage;
    protected string name;

    public Inhabitant(string name)
    {
        this.name = name;
        this.hp = Random.Range(10, 21);
        this.ac = Random.Range(10, 18);
        this.damage = Random.Range(1, 6);
    }
}
