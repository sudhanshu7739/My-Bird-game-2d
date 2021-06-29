using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class downcount : MonoBehaviour
{
    public int downct;
    public int upct;
    public int indown;
    public int inup;
    public int life;
    public GameObject effect;
    public Animator camAnim;
    public Text scrup;
    public Text scrdw;
    public Text lifc;
    public AudioSource pick;
    public AudioSource collide;

   
   
    
   
    // Start is called before the first frame update
    void Start()
    {
        downct = indown;
        upct = inup;
        lifc.text = life.ToString();
        

    }
  


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dcount"))
        {
            downct += 1;
            Destroy(collision.gameObject);
            scrdw.text = downct.ToString();
            pick.Play();
            


        }
        else if (collision.CompareTag("ucount"))
        {
            upct += 1;
            Destroy(collision.gameObject);
            
            scrup.text = upct.ToString();
            pick.Play();
        }
        else if (collision.CompareTag("obstrackle"))
        {
            camAnim.SetTrigger("shake");
            Instantiate(effect, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            life -= 1;
            collide.Play();
            lifc.text = life.ToString();
        }
    }
}
