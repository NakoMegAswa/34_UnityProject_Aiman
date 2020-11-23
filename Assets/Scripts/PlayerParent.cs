using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerParent : MonoBehaviour
{
    
    public GameObject TimerCountDownText;
    public Animator playerAnim;

    public float speed;
   
    public Rigidbody playerRb;

    //time coundown 
    public float timeRemaining = 10;


    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();

        TimerCountDownText.GetComponent<Text>().text = "Start Function";

        TimerCountDownText.GetComponent<Text>().text = "Timer CountDown: " + timeRemaining.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("W is pressed");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("isRun", true);
        }

        else if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isRun", false);
        }

     

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("isRun", false);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("isRun", false);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        else if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("isRun", false);
        }
        //if (PowerUpCounter == Totalcounter)
        //{
        //    SceneManager.LoadScene("WinScene");
        //}

        if (Input.GetKeyDown(KeyCode.Space))
       {
          
       
       }

          if(Input.GetKeyUp(KeyCode.Space))
         {

        
         }

          if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            TimerCountDownText.GetComponent<Text>().text = "Timer Countdown: " + timeRemaining.ToString();
        }

    }
    void StartRun()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        playerAnim.SetBool("isRun", true);
        playerAnim.SetFloat("startRun", 0.26f);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TagCone"))
        {
            Debug.Log("Activated Plane");

        }
    }
}
