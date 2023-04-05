using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject North, South, East, West, Origin;
    public float movementSpeed = 90.0f;
    private bool mv;
    private bool ExitOn;


    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
        print(MasterData.where);
        this.ExitOn = false;
        if(MasterData.where == "North")
        {
            this.mv = true;
            this.transform.position = this.South.transform.position;
            this.rb.AddForce(Vector3.forward * movementSpeed);
        }
        if(MasterData.where == "South")
        {
            this.mv = true;
            this.transform.position = this.North.transform.position;
        }
        if(MasterData.where == "East")
        {
            this.mv = true;
            this.transform.position = this.West.transform.position;
        }
        if(MasterData.where == "West")
        {
            this.mv = true;
            this.transform.position = this.East.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(mv.Equals(false))
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                this.rb.AddForce(this.North.transform.position * movementSpeed);
                this.mv = true;
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                this.rb.AddForce(this.West.transform.position * movementSpeed);
                this.mv = true;
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                this.rb.AddForce(this.East.transform.position * movementSpeed);
                this.mv = true;
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                this.rb.AddForce(this.South.transform.position * movementSpeed);
                this.mv = true;
            }
        }
        if(this.transform.position == this.Origin.transform.position)
        {
            this.mv = false;
            this.ExitOn = true;
        }
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(this.ExitOn == true)
        {
            if(other.tag.Equals("Door"))
            {
                MasterData.count++;
                if(other.gameObject == (this.North))
                {
                    MasterData.where = "North";
                }
                if(other.gameObject == (this.South))
                {
                    MasterData.where = "South";
                }
                if(other.gameObject == (this.East))
                {
                    MasterData.where = "East";
                }
                if(other.gameObject == (this.West))
                {
                    MasterData.where = "West";
                }
                SceneManager.LoadScene("DungeonRoom");
            }
        }
        else
        {
            
        }
        if(other.tag.Equals("Origin"))
        {
            this.rb.angularVelocity = Vector3.zero;
            this.mv = false;
            this.ExitOn = true;
        }
    }
}
