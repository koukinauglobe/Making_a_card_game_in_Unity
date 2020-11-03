using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardField : MonoBehaviour
{
    public GameObject obj;

    private List<CardObject> cards;

    // Start is called before the first frame update
    void Start()
    {
        cards = new List<CardObject>();
        // プレハブを元にオブジェクトを生成する
        GameObject cardobject = (GameObject)Instantiate(obj,
                                                  this.transform.position + new Vector3(-1.75f, 1.0f, 0.0f),
                                                  Quaternion.identity);
        CardObject card = cardobject.GetComponent<CardObject>();
        card.cardindex = Random.Range(0, card.faces.Length);
        card.ToggleFace(true);
        cards.Add(card);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
