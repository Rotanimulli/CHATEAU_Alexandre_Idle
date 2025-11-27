using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Damage : MonoBehaviour
{
    public int AttackDamage;
    public TextMeshProUGUI goldText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackDamage = 1;
    }
   

}
