using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject North, South, East, West;
    public float movementSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.rb.AddForce(this.North.transform.position * movementSpeed);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MasterData.count++;
            SceneManager.LoadScene("DungeonRoom");
        }
    }
}
