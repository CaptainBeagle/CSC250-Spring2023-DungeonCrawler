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
    private bool Aggro;
    Room currentRoom;


    // Start is called before the first frame update
    void Start()
    {
        this.Aggro = false;

        this.rb = this.GetComponent<Rigidbody>();
        this.isMoving = false;
        this.UpdateExits();

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

    private void UpdateExits()
    {
        this.currentRoom = MasterData.p.getCurrentRoom();
        if(currentRoom.hasExit("north") == false)
        {
            this.northExit.SetActive(false);
        }
        if(currentRoom.hasExit("south") == false)
        {
            this.southExit.SetActive(false);
        }
        if(currentRoom.hasExit("east") == false)
        {
            this.eastExit.SetActive(false);
        }
        if(currentRoom.hasExit("west") == false)
        {
            this.westExit.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Origin"))
        {
            this.rb.velocity = Vector3.zero;
            this.rb.Sleep();
            this.isMoving = false;
            int i = Random.Range(1, 10);
            
            if(i < 4)
            {
                this.Aggro = true;
            }
            //this.rb.angularVelocity = Vector3.zero;
        }

        if(other.gameObject.CompareTag("Battle"))
        {
            if(this.Aggro == true)
            {
                SceneManager.LoadScene("FightScene");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Door") && MasterData.isExiting)
        {
            if(other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
                currentRoom.takeExit(MasterData.p, "north");
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
                currentRoom.takeExit(MasterData.p, "south");
            }
            else if (other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
                currentRoom.takeExit(MasterData.p, "east");
            }
            else if (other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
                currentRoom.takeExit(MasterData.p, "west");
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
            if(this.currentRoom.hasExit("north"))
            {
                this.rb.AddForce(this.northExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && this.isMoving == false)
        {
            if(this.currentRoom.hasExit("west"))
            {
                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.isMoving == false)
        {
            if(this.currentRoom.hasExit("east"))
            {
                this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.isMoving == false)
        {
            if(this.currentRoom.hasExit("south"))
            {
                this.rb.AddForce(this.southExit.transform.position * movementSpeed);
                this.isMoving = true;
            }
        }

    }
}
