using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** 
 * Esta sera la clase para modelar el objeto Alien (personaje principal)
 * @author Ana Lucia Hernandez (17138).
 * 
 **/
public class Character : MonoBehaviour {


    Rigidbody2D rb2d;
    SpriteRenderer sr;
    Animator anim;
    private float speed = 5f;
    private float jumpForce = 180f;
    private bool facingRight = true;
    public GameObject feet;
    public LayerMask layerMask;
    public GameObject doorOpen; //imagen de la puerta abierta
    public GameObject doorClosed; //imagen de la puerta cerrada
    public SceneChanger cambiador; //para cambiar de escenas cuando el alien llegue a las puertas. 
    public string nextScene;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        doorClosed.SetActive(true);
		doorOpen.SetActive(false);
    }
	

	void Update () {
        float move = Input.GetAxis("Horizontal");
        if (move != 0) {// para mover al personaje
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
            facingRight = move > 0;
        }

        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;

        if (Input.GetButtonDown("Jump")) 
        {
            RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layerMask);
            if (raycast.collider != null) 
            {
                rb2d.AddForce(Vector2.up*jumpForce);
            }
        }
        if (transform.position.x > 8.4f && transform.position.x < 8.9f)//para cambiar de escena una vez el personaje este encima de las
        // puertas
        {
            cambiador.OnStartGame(nextScene);
        }
	}
    private void OnTriggerEnter2D (Collider2D collision)
	{
		doorClosed.SetActive(false);
		doorOpen.SetActive(true);

	}
}
