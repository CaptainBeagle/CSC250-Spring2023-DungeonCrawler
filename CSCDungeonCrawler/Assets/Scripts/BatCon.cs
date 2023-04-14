using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //This works in the roll-a-ball project but in this one. Why?
using TMPro;

public class BatCon : MonoBehaviour
{
    private int hp; //player health
    private int ac; //player armor class
    private int mhp; //monster health
    private int mac; //monster armor class
    public TextMeshProUGUI Stats; //I also set the code for the text up the same as I did in the previous project, it does not work.

    // Start is called before the first frame update
    void Start()
    {
        this.hp = Random.Range(50, 100);
        this.ac = Random.Range(1, 12);
        this.mhp = Random.Range(50, 100);
        this.mac = Random.Range(1, 12);

        print(this.hp);
        print(this.ac);
        print(this.mhp);
        print(this.mac);

        this.Stats.text = "HP: " + this.hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
