using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public int Scorecount = 0;
    public Text Scoretext;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Scorecount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Score")
        {
            Scorecount += 1;
            Scoretext.text = "Score: " + Scorecount;
            if (Scorecount == 60)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }
    }
}
