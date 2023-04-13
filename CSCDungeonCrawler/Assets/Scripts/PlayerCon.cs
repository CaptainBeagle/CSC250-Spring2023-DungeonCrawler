using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public GameObject westStart, eastStart, northStart, southStart;
    public float movementSpeed = 40.0f;
    private bool isMoving;


    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        this.isMoving = false;

        if (!MasterData.whereDidIComeFrom.Equals("?"))
        {
            this.isMoving = true;
            if(MasterData.whereDidIComeFrom.Equals("north"))
            {
                this.gameObject.transform.position = this.southExit.transform.position;
                this.rb.AddForce(Vector3.forward * 150.0f);
            }
            else if (MasterData.whereDidIComeFrom.Equals("south"))
            {
                this.gameObject.transform.position = this.northExit.transform.position;
                this.rb.AddForce(Vector3.back * 150.0f);
            }
            else if (MasterData.whereDidIComeFrom.Equals("west"))
            {
                this.gameObject.transform.position = this.eastExit.transform.position;
                this.rb.AddForce(Vector3.left * 150.0f);
            }
            else if (MasterData.whereDidIComeFrom.Equals("east"))
            {
                this.gameObject.transform.position = this.westExit.transform.position;
                this.rb.AddForce(Vector3.right * 150.0f);
            }
        }
        
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Origin"))
        {
            this.rb.velocity = Vector3.zero;
            this.rb.Sleep();
            this.isMoving = false;
            //this.rb.angularVelocity = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Door") && MasterData.isExiting)
        {
            if(other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
                if(MasterData.id.Equals("e"))
                {
                    MasterData.id = "h1";
                }
                else if(MasterData.id.Equals("h1"))
                {
                    MasterData.id = "h2";
                }
                else if(MasterData.id.Equals("h5"))
                {
                    MasterData.id = "s118b";
                }
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
                if(MasterData.id.Equals("h1"))
                {
                    MasterData.id = "e";
                }
                else if(MasterData.id.Equals("h2"))
                {
                    MasterData.id = "h1";
                }
                else if(MasterData.id.Equals("s118b"))
                {
                    MasterData.id = "h5";
                }
            }
            else if (other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
                if(MasterData.id.Equals("h2"))
                {
                    MasterData.id = "h3";
                }
                else if(MasterData.id.Equals("h4"))
                {
                    MasterData.id = "h2";
                }
                else if(MasterData.id.Equals("h5"))
                {
                    MasterData.id = "h4";
                }
            }
            else if (other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
                if(MasterData.id.Equals("h2"))
                {
                    MasterData.id = "h4";
                }
                else if(MasterData.id.Equals("h3"))
                {
                    MasterData.id = "h2";
                }
                else if(MasterData.id.Equals("h4"))
                {
                    MasterData.id = "h5";
                }
            }
            MasterData.isExiting = false;
            SceneManager.LoadScene("DungeonRoom");
        }
        else if(other.gameObject.CompareTag("Door") && !MasterData.isExiting)
        {
            MasterData.isExiting = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && this.isMoving == false)
        {
            if(MasterData.nON == true)
            {
                this.rb.AddForce(this.northExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && this.isMoving == false)
        {
            if(MasterData.wON == true)
            {
                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.isMoving == false)
        {
            if(MasterData.eON == true)
            {
                this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.isMoving == false)
        {
            if(MasterData.sON == true)
            {
                this.rb.AddForce(this.southExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }

    }
}
