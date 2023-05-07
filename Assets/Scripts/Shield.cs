using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public float cooldown; //длительность таймера
    [HideInInspector] public bool isCooldown; //включен ли таймер

    private Image shieldImage; //Картинку щита
    private Player player; // игрока
    // Start is called before the first frame update
    void Start()
    {
        shieldImage = GetComponent<Image>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        isCooldown = true; // таймер начался
    }

    // Update is called once per frame
    void Update()
    {
        if (isCooldown)
        {
            shieldImage.fillAmount -= 1/cooldown * Time.deltaTime; // каждый кадр будет уменьшанся
            if (shieldImage.fillAmount <= 0) // если время таймера закончилось
            {
                shieldImage.fillAmount = 1;// картинка польнотью заполняется
                isCooldown = false; // отключаетм таймер
                player.shield.SetActive(false); // щит выключаем
                gameObject.SetActive(false); // картинка таймера удаляется
            }
        }
    }
    public void ResetTimer()
    {
        shieldImage.fillAmount = 1; // чтобы перезапустить таймер
    }
    //public void ReduceTime(int damage)
    //{
    //    shieldImage.fillAmount += damage / 7f;
    //}
}
