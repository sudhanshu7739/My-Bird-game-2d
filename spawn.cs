using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public spawn04[] obstrackle;
    private float timebwspawn;
    private float strtbwspawn;
    public float leasttsp;
    public float maxtsp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        strtbwspawn = Random.Range(leasttsp, maxtsp);
        int rand = Random.Range(0, 100);
        if (timebwspawn <= 0)
        {
            for(int j = 0; j < obstrackle.Length; j++)
            {
                if(rand >=obstrackle[j].minpran && rand <= obstrackle[j].maxpran)
                {
                    Instantiate(obstrackle[j].spawnobject, transform.position, Quaternion.identity);
                    break;
                }
            }
            timebwspawn = strtbwspawn;

        }
        else
        {
            timebwspawn -= Time.deltaTime;
        }
        
    }
    
}
[System.Serializable]
public class spawn04
{
    public GameObject spawnobject;
    public int minpran ;
    public int maxpran ;

}
