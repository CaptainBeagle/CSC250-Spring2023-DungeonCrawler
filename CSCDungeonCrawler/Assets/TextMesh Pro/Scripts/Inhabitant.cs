using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inhabitant 
{
    public int hp;
    public int Maxhp;
    public int ac;
    public int damage;
    protected string name;

    public Inhabitant(string name)
    {
        this.name = name;
        this.Maxhp = Random.Range(10, 21);
        this.hp = this.Maxhp;
        this.ac = Random.Range(10, 18);
        this.damage = Random.Range(1, 6);
    }

    public string getData()
    {
        string s = this.name;
        s = s + " - " + this.hp + "/" + this.ac + "/" + this.damage;
        return s;
    }

    public string getName()
    {
        return this.name;
    }

    public int getInfo(string i)
    {
        if(i.Equals("hp"))
        {
            return this.hp;
        }
        if(i.Equals("ac"))
        {
            return this.ac;
        }
        if(i.Equals("damage"))
        {
            return this.damage;
        }
        else
        {
            return 0;
        }
    }
}
