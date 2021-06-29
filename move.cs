using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class move : downcount
{
    private Vector2 targetp;
    public float yincre;
    public float speed;
    public float maxh;
    public float minh;
    public GameObject effectu;
    public GameObject effectd;
    public GameObject dp;
    public GameObject up;
    public Text upt;
    public Text dwt;
    private float starttime;
    public Text timer;
    public GameObject gameover;
    public GameObject panl1;
    public Slider slid;
    public Gradient gra;
    public Image fill;
    public Text scorrrre;
    public Text hiscree;
    public GameObject panlhs;



    // Update is called once per frame
    private void Start()
    {
        Time.timeScale = 1;
        starttime = Time.time;
        downct = indown;
        upct = inup;
        targetp = transform.position;
        scrdw.text = downct.ToString();
        scrup.text = upct.ToString();
        lifc.text = life.ToString();
        timer.text = 0.ToString();
        slid.maxValue = life;
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10f,10f),Mathf.Clamp(transform.position.y, -3f, 3f),transform.position.z);
        float t = Time.time - starttime;
       
        transform.position = Vector2.MoveTowards(transform.position, targetp, speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxh && upct>0)
        {
            Instantiate(effectu, dp.transform.position, Quaternion.identity);
            targetp = new Vector2(transform.position.x, transform.position.y + yincre);

            upct -= 1;
            upt.text = upct.ToString();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minh && downct>0)
        {
            Instantiate(effectd, up.transform.position, Quaternion.identity);
            targetp = new Vector2(transform.position.x, transform.position.y - yincre);
            downct -= 1;
            dwt.text = downct.ToString();
        }
        timer.text = t.ToString("f1");
        if (life <= 0)
        {
            
            gameover.SetActive(true);
            
            Time.timeScale = 0;
        }
        slid.value = life;
        fill.color = gra.Evaluate(slid.normalizedValue);
        scorrrre.text ="SCORE :" + t.ToString("f2");
        hiscree.text = "HIGH SCORE :"+PlayerPrefs.GetFloat("hiscr").ToString("f2");
        
        if (PlayerPrefs.GetFloat("hiscr") < t)
        {
            PlayerPrefs.SetFloat("hiscr", t);
            panlhs.SetActive(true);
        }
        
    }
    public void pause1()
    {
        panl1.SetActive(true);
        Time.timeScale = 0;
    }
    public void playy()
    {
        panl1.SetActive(false);
        Time.timeScale = 1;
    }
}
