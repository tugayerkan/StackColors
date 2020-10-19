using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform Player;


    public float forwardForce = 1000f;
    public float sidewaysForward = 500f;
    void Start()
    {

    }

    void FixedUpdate()
    {
       
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        {
            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForward * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForward * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (rb.position.y < -2f)
            {
                FindObjectOfType<GameMonitor>().EndGame();


            }

        }
        

    }
}
