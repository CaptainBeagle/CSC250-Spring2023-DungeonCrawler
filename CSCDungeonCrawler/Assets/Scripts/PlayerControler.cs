using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject North, South, East, West;
    public float movementSpeed = 40.0f;
    private bool mv = false;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
    }

    // Update is called once per frame
    void Update()
    {
        if(mv.Equals(false))
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                this.rb.AddForce(this.North.transform.position * movementSpeed);
                mv = true;
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                this.rb.AddForce(this.West.transform.position * movementSpeed);
                mv = true;
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                this.rb.AddForce(this.East.transform.position * movementSpeed);
                mv = true;
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                this.rb.AddForce(this.South.transform.position * movementSpeed);
                mv = true;
            }
        }
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Door"))
        {
            MasterData.count++;
            SceneManager.LoadScene("DungeonRoom");
        }
    }
}
