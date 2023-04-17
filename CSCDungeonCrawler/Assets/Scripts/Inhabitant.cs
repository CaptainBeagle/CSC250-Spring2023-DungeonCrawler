using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inhabitant 
{
    protected int hp;
    protected int ac;
    protected int damage;
    protected string name;

    public Inhabitant()
    {
        this.name = name;
        Random r = new Random();
        this.hp = r.Next(10, 21);
        this.ac = r.Next(10, 18);
        this.damage = r.Next(1, 6);
    }
}
