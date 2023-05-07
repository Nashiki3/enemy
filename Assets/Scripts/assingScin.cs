using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assingScin : MonoBehaviour
{
    public Sprite[] skins; 

    public GameObject Player;
    void Start()
    {
        Player.GetComponent<SpriteRenderer>().sprite = skins[PlayerPrefs.GetInt("skinNum")]; //получаем номер нашого скина, котоорый сохраняется при покупке ну или при выборе
    }

}
