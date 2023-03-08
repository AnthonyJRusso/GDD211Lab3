using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playerscript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Image Lifebar;
    [SerializeField] private GameObject Losescreen;
    private bool canMove;

    //Score
    private float T;
    [SerializeField] private TMP_Text Score;


    //Shooting
    private float bulletcd;
    [SerializeField] private GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        bulletcd = 0;
        T = 0;
        Losescreen.SetActive(false);
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        //bool for movememt/shooting allowing it to be turned off 
        if (canMove == true)
        {
            //2-directional movement for player
            float x_value = (Input.GetAxisRaw("Horizontal") * speed);

            transform.position += new Vector3(x_value * Time.deltaTime, 0f, 0f);

            //Shooting
            bulletcd -= Time.deltaTime;

            if (Input.GetKey(KeyCode.Space) && bulletcd <= 0)
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.9f, transform.position.z), Quaternion.identity);
                bulletcd = 0.25f;
            }

            //Score counter
            T += Time.deltaTime;
            Score.text = "" + Mathf.Round(T) / 1f;

        }

        

        //Lose State
        if(Lifebar.fillAmount <= 0)
        {
            Losescreen.SetActive(true);
            canMove = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bugs b = collision.gameObject.GetComponent<Bugs>();

        if (b)
        {
            Destroy(collision.gameObject);
            Lifebar.fillAmount -= 0.2f;

        }
    }
}
