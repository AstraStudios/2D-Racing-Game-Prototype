using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAssignedFan : MonoBehaviour
{
    Sprite fanSprite;
    [SerializeField] Sprite StandCharacterOne;
    // When make more sprites add them

    int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        fanSprite = gameObject.GetComponent<Sprite>();
        randomNum = Random.Range(0, 4);
        if (randomNum == 0)
        {
            fanSprite = StandCharacterOne;
        }
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
