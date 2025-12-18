using TMPro;
using UnityEngine;

public class EnnemiesHealth : MonoBehaviour
{
    private int baseHP;
    public int HP;
    public int basedamage;
    public int damage;
    public int cakeAmount;
    public TextMeshProUGUI cakeText;
    public TextMeshProUGUI damageText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {  
        baseHP = 1; 
        HP = baseHP;
        basedamage = 1;
        damage = basedamage;
    }

    public void InflictDamage()
    {
        HP -= damage;
    }

    public void ChangeDamage()
    {
        if (cakeAmount >= 10)
        {
            cakeAmount -= 10;
            damage += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Mort de l'ennemi
        if (HP <= 0)
        {
            cakeAmount += 1;
            baseHP += 1;
            HP = baseHP;
        }
        //Mise a jour des textes
        cakeText.text = cakeAmount.ToString("00");
        damageText.text = damage.ToString("00");
    }
}
