using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControlller : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] AudioSource quick, crashPlataform;
    [SerializeField] int speed;
    [SerializeField] GameObject Painel_lose;

    public int score = 0;
    public int continue_score;

    private void Start()
    {
        score = PlayerPrefs.GetInt("condicion", score);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (Painel_lose.activeInHierarchy == false)
            {
                quick.Play();
                rb.velocity = Vector3.zero;
                rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
            }
        }



        else if (collision.gameObject.CompareTag("NextLevel"))
        {

            SceneManager.LoadScene(0);
            PlayerPrefs.SetInt("condicion", score);

        }



        else if (collision.gameObject.CompareTag("Lose"))
        {
            Time.timeScale = 0;
            PlayerPrefs.SetInt("condicion", score = 0);
            rb.AddForce(Vector3.zero);
            Painel_lose.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collisor"))
        {

            crashPlataform.Play();
            score += 5;
        }
    }

    private void Update()
    {

    }
}