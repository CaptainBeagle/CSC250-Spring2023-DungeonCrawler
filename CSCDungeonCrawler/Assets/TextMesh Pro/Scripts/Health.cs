using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject bar1;
    public GameObject bar2;
    public GameObject bar3;
    public GameObject bar4;
    public GameObject bar5;
    public GameObject bar6;
    public GameObject bar7;
    public GameObject bar8;
    public GameObject bar9;
    public GameObject bar10;
    // Start is called before the first frame update
    void Start()
    {
        if(MasterData.p.hp == MasterData.p.Maxhp)
        {
            this.bar1.SetActive(true);
            this.bar2.SetActive(true);
            this.bar3.SetActive(true);
            this.bar4.SetActive(true);
            this.bar5.SetActive(true);
            this.bar6.SetActive(true);
            this.bar7.SetActive(true);
            this.bar8.SetActive(true);
            this.bar9.SetActive(true);
            this.bar10.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
