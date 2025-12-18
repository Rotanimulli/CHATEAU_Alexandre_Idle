using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mobList : MonoBehaviour
{

    public List<Sprite> KirbyEnnemies;
    public int FrontEnnemie;
    public EnnemiesHealth EnnemiesHealthManager;

  
    
 
    
    
    

    // Update is called once per frame
    void Update()
    {
        if (EnnemiesHealthManager.HP <= 0)
        {
            FrontEnnemie = Random.Range(0, 8);
        }


    }
}